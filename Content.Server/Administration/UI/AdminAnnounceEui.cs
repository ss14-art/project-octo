using Content.Server._Starlight.Administration.Systems; //Starlight
using Content.Server.Administration.Logs; // Art-change
using Content.Server.Administration.Managers;
using Content.Server.Chat.Managers;
using Content.Server.Chat.Systems;
using Content.Server.EUI;
using Content.Shared.Administration;
using Content.Shared.CCVar; // Art-change
using Content.Shared.Chat; // Art-change
using Content.Shared.Eui;
using Content.Shared.Database; // Art-change
using Robust.Shared.Audio; // Art-change
using Robust.Shared.Configuration; // Art-change
using Robust.Shared.ContentPack; // Art-change
using Robust.Shared.Map; // Art-change
using Robust.Shared.Player; // Art-change
using System.Linq; // Art-change

namespace Content.Server.Administration.UI
{
    public sealed partial class AdminAnnounceEui : BaseEui // Art-change add partial
    {
        // Art-changes start
        [Dependency] private IAdminManager _adminManager = default!;
        [Dependency] private IChatManager _chatManager = default!;
        [Dependency] private IConfigurationManager _cfg = default!;
        [Dependency] private IResourceManager _res = default!;
        [Dependency] private IAdminLogManager _adminLogger = default!;
        [Dependency] private IEntityManager _entityManager = default!;
        [Dependency] private ISharedPlayerManager _playerManager = default!;
        // Art-changes end

        private readonly ChatSystem _chatSystem;
        private readonly AutoDiscordLogSystem _autoLog; //Starlight

        public AdminAnnounceEui()
        {
            IoCManager.InjectDependencies(this);

            // Art-change start
            var sysMan = IoCManager.Resolve<IEntitySystemManager>();
            _chatSystem = sysMan.GetEntitySystem<ChatSystem>();
            // Art-change end
            _autoLog = sysMan.GetEntitySystem<AutoDiscordLogSystem>(); //Starlight
        }

        public override EuiStateBase GetNewState() => new AdminAnnounceEuiState(); // Art-change

        public override void HandleMessage(EuiMessageBase msg)
        {
            base.HandleMessage(msg);

            // Art-changes start
            if (msg is not AdminAnnounceEuiMsg.DoAnnounce doAnnounce)
                return;

            if (!_adminManager.HasAdminFlag(Player, AdminFlags.Admin))
            {
                Close();
                return;
            }

            var maxLength = _cfg.GetCVar(CCVars.ChatMaxAnnouncementLength);
            var announcement = SharedChatSystem.SanitizeAnnouncement(doAnnounce.Announcement, maxLength);

            if (string.IsNullOrWhiteSpace(announcement))
                return;

            var color = AdminAnnounceHelpers.GetColor(doAnnounce.AnnounceType, doAnnounce.ColorHex);

            switch (doAnnounce.AnnounceType)
            {
                case AdminAnnounceType.Server:
                    _chatManager.DispatchServerAnnouncement(announcement, color);
                    _adminLogger.Add(LogType.Chat, LogImpact.Low,
                        $"{Player.Name} has sent the following server announcement: {announcement}");
                    break;
                // TODO: Per-station announcement support
                case AdminAnnounceType.Station:
                    var normalizedAnnouncer = AdminAnnounceHelpers.NormalizeText(doAnnounce.Announcer);
                    var announcer = string.IsNullOrWhiteSpace(normalizedAnnouncer)
                        ? Loc.GetString("admin-announce-announcer-default")
                        : normalizedAnnouncer;

                    var sound = SharedChatSystem.DefaultAnnouncementSound;
                    var soundPath = AdminAnnounceHelpers.NormalizeSoundPath(doAnnounce.SoundPath);

                    if (_res.ContentFileExists(soundPath))
                        sound = new SoundPathSpecifier(soundPath);

                    var finalContent = AdminAnnounceHelpers.FormatAnnouncement(announcement, doAnnounce.Sender);

                    MapId? adminMapId = null;
                    if (Player.AttachedEntity is { } adminEntity
                        && _entityManager.TryGetComponent<TransformComponent>(adminEntity, out var adminXform))
                    {
                        adminMapId = adminXform.MapID;
                    }

                    var mapId = adminMapId ?? MapId.Nullspace;
                    var sentPerMap = !doAnnounce.Global && mapId != MapId.Nullspace;

                    if (sentPerMap)
                    {
                        var mapFilter = GetPlayersOnMap(mapId);

                        if (mapFilter.Recipients.Any())
                        {
                            _chatSystem.DispatchFilteredAnnouncement(
                                mapFilter,
                                finalContent,
                                sender: announcer,
                                playSound: true,
                                announcementSound: sound,
                                colorOverride: color
                            );
                        }
                        else
                        {
                            sentPerMap = false;
                        }
                    }

                    if (!sentPerMap)
                    {
                        _chatSystem.DispatchGlobalAnnouncement(
                            finalContent,
                            announcer,
                            colorOverride: color,
                            playSound: true,
                            announcementSound: sound
                        );
                    }
                    _adminLogger.Add(LogType.Chat, LogImpact.Low,
                        $"{Player.Name} has sent the following {(sentPerMap ? "map" : "global")} announcement as {announcer}: {announcement}");

                    var admin = Player?.Name ?? "Unknown"; //Starlight
                    _autoLog.LogToDiscord(Loc.GetString("autolog-announce", ("sender", doAnnounce.Announcer), ("message", doAnnounce.Announcement), ("admin", admin)), admin); //Starlight
                    break;
            }

            if (doAnnounce.CloseAfter)
                Close();
            // Art-changes end
        }

        // Art-changes start
        private Filter GetPlayersOnMap(MapId mapId)
        {
            var filter = Filter.Empty();
            foreach (var session in _playerManager.Sessions)
            {
                if (session.AttachedEntity is { } entity
                    && _entityManager.TryGetComponent<TransformComponent>(entity, out var xform)
                    && xform.MapID == mapId)
                {
                    filter.AddPlayer(session);
                }
            }
            return filter;
        }
        // Art-changes end
    }
}

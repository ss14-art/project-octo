# SS14 Localization Required

Treat localization as mandatory work for gameplay, UI, admin-facing, and prototype-backed player text.

## Required

- Localize every player-facing string.
- Add or update FTL in `Resources/Locale/en-US/_sh` for Shine-specific text.
- Use feature-scoped `kebab-case` keys.
- Store reusable localization keys in data as `LocId` when local patterns support it.

## Applies To

- Popups, chat text, examine text, UI labels, button text, tooltips, and alerts.
- Prototype names, descriptions, dataset entries, marking names, reagent names, and similar content data.
- Admin/operator text shown in the game client.

## Do Not

- Hardcode user-facing English in C#.
- Compare localized strings in logic.
- Show raw enum `ToString()` or raw prototype IDs to players.

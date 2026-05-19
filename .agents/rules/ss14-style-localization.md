# SS14 Style And Localization

## C# Style

- Use file-scoped namespaces.
- Mark classes `sealed`, `abstract`, `static`, or `[Virtual]`.
- Put fields and auto-properties before methods.
- Use `Entity<T?>` public system APIs and resolve components at the start.
- Name handlers `OnXEvent`.
- Use the `On -> Try -> Can -> Do` shape for public flows:
  - `OnXEvent` receives event callbacks.
  - `TryX` returns success and performs validation.
  - `CanX` answers permission/capability questions.
  - `DoX` performs already-validated mutation.
- Put gameplay logic in systems, never in components.
- Use `[Access]`/`[Friend]` where component mutation should be restricted.
- Prefer EntitySystem dependencies over `EntitySystem.Get<T>()` or `IoCManager.Resolve<T>()` inside systems.

## Data And Prototypes

- Prefer prototypes over enums for in-game kinds/types.
- Use `ProtoId<T>` for prototype IDs in data fields.
- Use `[DataField]` without explicit key unless a custom YAML key is truly needed.
- Use `SoundSpecifier` and `SpriteSpecifier`.
- Use `TimeSpan` and `IGameTiming.CurTime` for simulation time.

## Localization

- Localize every player-facing string.
- Use kebab-case localization IDs, scoped by subsystem.
- Prefer `Loc.GetString(id, ("arg", value))` over concatenation.
- Use Fluent entity helpers such as `THE`, `INDEFINITE`, `SUBJECT`, `OBJECT`, `POSS-ADJ`, and conjugation helpers when sentence grammar depends on entities.
- Put Shine FTL under `Resources/Locale/en-US/_sh/...`.

## YAML

- Keep SS14 component indentation style: `components:` then `- type: Foo` with no extra indent.
- Prototype order: `type`, `abstract`, `parent`, `id`, `categories`, `name`, `suffix`, `description`, `components`.
- Use inline lists for categories and regular lists elsewhere.
- Separate prototypes by one blank line.
- Use suffixes for spawn-menu differentiation instead of changing player-facing names.

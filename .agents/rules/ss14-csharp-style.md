# SS14 C# Style

Use this rule for new gameplay C# in `Content.Shared`, `Content.Server`, `Content.Client`, and tests.

## Naming

- Event handlers use `On...Event`.
- Public action methods use `Try...` when they can fail.
- Check methods use `Can...` and must not mutate state.
- Execution helpers use `Do...` when validation already happened.
- Dependency fields use underscore style such as `_popup`, `_audio`, `_hands`.

## Entity APIs

- Prefer `Entity<T?>` when the caller may already have a component pair.
- Call `Resolve(...)` early in public system methods that accept optional component pairs.
- Use `EntityUid?` for optional references instead of `EntityUid.Invalid`.
- Use `NetEntity` in network payloads instead of raw `EntityUid`.

## Data And Prototypes

- Prefer `[DataField]` without string keys unless compatibility requires a serialized key.
- Prefer `ProtoId<T>` or `EntProtoId` over raw prototype ID strings.
- Keep localized identifiers as `LocId` when they are stored in component or prototype-backed data.

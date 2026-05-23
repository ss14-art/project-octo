# SS14-ART-CORE Hard Guardrails

These rules are non-negotiable for SS14-ART-CORE work.

## Absolute Rules

- Do not edit `RobustToolbox/**`. Read it for context only. If an engine change seems required, stop and explain the required escalation.
- New SS14-ART-CORE-only code goes under a path segment named `_Art` unless a maintainer explicitly chooses a different fork-owned directory.
- Do not add new mechanics by duplicating existing mechanics. Search first, extend or compose existing systems, and make the feature configurable through components, prototypes, CVars, or data definitions.
- Do not hardcode prototype IDs, localization IDs, magic numbers, sound paths, sprite paths, or department/job names when a typed ID, `ProtoId<T>`, `SoundSpecifier`, `SpriteSpecifier`, CVar, data field, or prototype relation can express it.
- Do not write "temporary" code, reflection hacks, static global state, one-off update loops, or server-only shortcuts for predicted gameplay.
- Every player-facing string must be localized.
- Treat client-sent network data as untrusted. Validate permissions, range, ownership, cooldowns, and entity state on the server.

## .NET 10 Freshness

The repo currently pins .NET SDK `10.0.100` in `global.json`.

Before framework-sensitive work:

- Read `global.json`, `Directory.Packages.props`, and the relevant `.csproj`.
- Prefer APIs and patterns valid for the pinned .NET 10 SDK and current package versions.
- Use repo analyzers and existing patterns over memory of older SS14/.NET examples.
- If uncertain about a .NET 10 API, verify against current official documentation or the installed SDK before coding.

## Quality Bar

- Keep changes narrow and reviewable.
- Make APIs reusable by other systems.
- Prefer data-driven behavior over branching on concrete prototype IDs.
- Use ECS correctly: components store data, systems own behavior.
- Prefer events, system APIs, and typed data over stringly-typed glue.
- Add focused tests or a clear validation path for risky changes.

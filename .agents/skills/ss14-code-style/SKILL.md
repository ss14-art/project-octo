---
name: ss14-code-style
description: SS14 C# and YAML code style for Shine Project, including handler naming, dependency naming, Entity generic APIs, On/Try/Can/Do method shape, DataField/ProtoId/Prototype style, localization naming, comments, classes, TimeSpan, and performance guardrails.
---

# SS14 Code Style

## C#

- Use file-scoped namespaces.
- Mark classes `sealed`, `abstract`, `static`, or `[Virtual]`.
- Fields and auto-properties come before methods.
- DataFields and public APIs need useful XML docs when non-obvious.
- Comments explain why, not mechanical what.
- Avoid magic strings/numbers and copy-paste code.
- Use `TimeSpan`, `IGameTiming.CurTime`, paused fields, and serializers for runtime timers.
- Avoid extension methods on simulation types; prefer EntitySystem public APIs.

## Naming

- Event handlers: `OnXEvent`.
- Dependencies: private readonly `_systemName` or `_managerName`.
- Public system flow: `On -> Try -> Can -> Do`.
- Localization IDs: kebab-case and subsystem-scoped.
- Shared types get `Shared` prefix only when server/client derived types exist.

## Data

- Use `Entity<T?>` public APIs and `Resolve`.
- Use `[DataField]`, `ProtoId<T>`, `[Prototype]`, `SoundSpecifier`, `SpriteSpecifier`.
- Prefer prototypes over enums for gameplay kinds.
- Use `TimeSpan` for durations and paused fields/serializers where needed.

## YAML

Follow `.agents/rules/ss14-style-localization.md`.

## Bundled References

- `references/csharp-review-checklist.md`: C#, ECS, event, dependency, TimeSpan, and performance checks from WizDen conventions.
- `references/yaml-ftl-style.md`: YAML, prototype, FTL, sprite metadata, and localization style reminders.

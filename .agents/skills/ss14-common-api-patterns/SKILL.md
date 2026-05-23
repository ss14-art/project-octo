---
name: ss14-common-api-patterns
description: Common SS14 EntitySystem API patterns for dependencies, prototypes, audio, popups, appearance, containers, DoAfter, timing, admin logs, CVars, and public system APIs. Use when implementing reusable game logic in SS14-ART-CORE.
---

# SS14 Common API Patterns

## EntitySystem APIs

- Use `[Dependency]` fields for other systems and managers.
- Use EntitySystem proxy helpers when available.
- Public methods that act on entities should start with `Entity<T?>` arguments and resolve components.
- Prefer `TryX`, `CanX`, and setter methods over direct external component mutation.

## Data APIs

- Use `IPrototypeManager` and `ProtoId<T>` for prototypes.
- Store IDs, not cached prototype objects, unless the local pattern requires caching.
- Use `CVarDef<T>` in subsystem-specific CVar classes.
- Use `TimeSpan` and `IGameTiming.CurTime` for simulation time.

## Presentation APIs

- Use localized strings for popups, examine text, UI labels, and admin-facing player text.
- Use predicted popup/audio APIs in predicted paths.
- Use `ToPrettyString` for entities in admin logs.

## Resource Specifiers

- Use `SoundSpecifier` for sounds.
- Use `SpriteSpecifier` for sprites/textures.
- Prefer sound collections when reusable.

## Bundled References

- `references/entitysystem-functions.md`: public system APIs, dependencies, `Resolve`, and mutation boundaries.
- `references/prototype-manager-and-spawn.md`: prototype lookups, typed IDs, spawning, and avoiding magic IDs.
- `references/audio-popup-random.md`: predicted feedback, localization, random, and user-facing effects.

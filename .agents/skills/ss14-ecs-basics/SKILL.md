---
name: ss14-ecs-basics
description: ECS guidance for SS14 components, entity systems, events, APIs, and data-only components. Use when adding or reviewing components, systems, events, entity queries, access restrictions, or gameplay logic in SS14-ART-CORE.
---

# SS14 ECS Basics

## Core Model

- Entities are IDs with components.
- Components hold data only.
- EntitySystems own behavior, validation, mutation, events, and public APIs.
- Prefer composition and reusable components over inheritance-heavy mechanics.

## Bundled References

- `references/ecs-primer.md`: ECS mental model and split between entities, components, systems, and events.
- `references/simple-system-walkthrough.md`: minimal component/system flow for new gameplay.
- `references/event-reading-guide.md`: event naming, by-ref events, handled/cancellable events, and method-event alternatives.

## Component Rules

- Use `[RegisterComponent]` and `partial`.
- Keep fields public unless a local pattern requires otherwise.
- Use `[DataField]` for serialized/prototype data.
- Use `[Access]` and `[Friend]` to restrict mutation when practical.
- Do not put logic in setters except narrow ViewVariables support.

## EntitySystem Rules

- Subscribe in `Initialize`.
- Name handlers `OnXEvent`.
- Use dependencies, not ad hoc system lookups.
- Prefer public API methods over method events.
- Use `Entity<T?>` in public APIs and `Resolve` at method start.
- Make setter methods guard unchanged values before dirtying/networking.

## Events

- Event names end in `Event`.
- Prefer struct by-ref events for performance-sensitive events.
- Use cancellable/handled events intentionally.
- Use method events only behind an EntitySystem public method.

## Sources

See `ss14-wizden-docs` for:

- `robust-toolbox/ecs.md`
- `general-development/codebase-info/conventions.md`
- `ss14-by-example/adding-a-simple-bikehorn.md`

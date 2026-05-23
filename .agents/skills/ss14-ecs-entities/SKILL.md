---
name: ss14-ecs-entities
description: Entity API guidance for SS14-ART-CORE SS14 work. Use when passing EntityUid, Entity generic pairs, optional entity references, NetEntity conversion, Resolve/TryComp usage, entity spawning, deletion, or entity lifetime handling.
---

# SS14 ECS Entities

Use entity APIs so callers can pass already-resolved component pairs without wasting queries.

## Workflow

1. Open `references/entity-api-patterns.md`.
2. Open `references/optional-and-weak-entities.md`.
3. Open `references/spawn-delete-and-lifetime.md`.

## Rules

- Prefer `Entity<T?>` for public system APIs that need a component.
- Resolve at method start.
- Use `EntityUid?` for optional references, not `EntityUid.Invalid`.
- Use `NetEntity` in network payloads.

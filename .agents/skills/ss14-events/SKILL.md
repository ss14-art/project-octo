---
name: ss14-events
description: Event guidance for SS14-ART-CORE SS14 ECS work. Use when creating, subscribing to, raising, reviewing, or replacing local events, broadcast events, cancellable events, handled events, network events, and method-event-like flows.
---

# SS14 Events

Events decouple systems; they are not a replacement for public system APIs.

## Workflow

1. Open `references/event-patterns.md`.
2. Open `references/cancellable-and-handled-events.md`.
3. Open `references/method-event-avoidance.md`.

## Rules

- Event names end with `Event`.
- Handlers use `OnXEvent`.
- Prefer directed events when entity-specific.
- Avoid method events unless wrapped by an EntitySystem method.

# Event Patterns

## Directed Events

Use for entity-specific behavior. Prefer these for component interactions.

## Broadcast Events

Use when no single entity owns the event. Include enough context for subscribers.

## Naming

- End names with `Event`.
- Handler names use `On...Event`.
- Document event purpose and mutable fields.

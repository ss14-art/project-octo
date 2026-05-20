# Component Networking

## Shared Networked Component

Use:

- `[NetworkedComponent]`;
- `[AutoGenerateComponentState]`;
- `[AutoNetworkedField]` on replicated fields.

## Dirty

Dirty when authoritative values change. Use `DirtyField` for field-delta components.

## Avoid

- networking server-only components;
- mutable reference fields without clone handling;
- leaking hidden data to all clients.

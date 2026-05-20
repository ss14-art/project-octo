# Networked Component State

Use:

- `[NetworkedComponent]` on shared components;
- `[AutoGenerateComponentState]`;
- `[AutoNetworkedField]`;
- `Dirty` or `DirtyField`.

Do not network fields clients should not know.

Use field deltas when independently changing fields would otherwise resend too much state.

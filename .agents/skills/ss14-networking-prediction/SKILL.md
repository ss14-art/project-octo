---
name: ss14-networking-prediction
description: Prediction and networking guidance for SS14 component states, AutoNetworkedField, Dirty/DirtyField, predicted popups/audio, predicted BUIs, NetEntity, network events, and client/server validation. Use for any interactive, networked, or shared gameplay code.
---

# SS14 Networking Prediction

## Default

Make new interactive gameplay predicted when feasible. If prediction is impossible, document why.

## Bundled References

- `references/predicted-api-selection.md`: choose predicted popup, audio, spawn/delete, and BUI APIs.
- `references/dirty-and-field-deltas.md`: when to call `Dirty`, when to use `DirtyField`, and how to avoid noisy networking.

## Component State

- Shared networked components live in `Content.Shared/_sh`.
- Use `[NetworkedComponent]` only on shared components.
- Prefer `[AutoGenerateComponentState]` and `[AutoNetworkedField]`.
- Dirty every changed networked field.
- Use `DirtyField` with field deltas when fields change independently.
- Use `IRobustCloneable` or equivalent deep-copy handling for networked mutable reference types.

## Predicted Effects

- Use `PopupPredicted` or `PopupClient`, not `PopupEntity`, in predicted paths.
- Use `PlayPredicted`, not `PlayPvs`, in predicted paths.
- Use predicted spawn/delete APIs for shared predicted entity creation.
- Use `SendPredictedMessage` for predicted BUI button/input messages.
- Guard non-idempotent client effects with prediction timing helpers.

## Security

- Treat client network messages as untrusted.
- Validate user, range, ownership, cooldown, permissions, entity lifestage, and target state on the server.
- Do not network hidden data to all clients for convenience.
- Use PVS/session-specific networking when the client only needs owner, role, admin, camera, or subscribed-view data.
- Convert entity references with `NetEntity` at network boundaries and clear nullable entity refs when entities can be deleted or leave PVS.

## Testing

Use fake lag, two clients, server/client VV, and component value comparison to find mispredicts.

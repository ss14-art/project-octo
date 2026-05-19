# SS14 Prediction And Networking

Prediction is the default for new interactive gameplay when feasible.

## Checklist

- Put predicted components and systems in `Content.Shared/_sh`.
- Use `[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]` on shared networked components.
- Mark changed networked fields with `[AutoNetworkedField]`.
- Call `Dirty` or `DirtyField` whenever a networked field changes.
- Use field deltas for independently changing fields on larger components.
- Guard setters so unchanged values do not dirty.
- Use predicted APIs such as `PopupPredicted`, `PopupClient`, `PlayPredicted`, predicted entity spawn/delete, and `SendPredictedMessage`.
- Use `IGameTiming.IsFirstTimePredicted` or equivalent guards for non-idempotent client-side effects.
- Avoid unpredicted server-only handling for client input unless prediction is impossible.
- Validate all client-origin network messages on the server.

## PVS And Visibility

- Do not network hidden information to every client for convenience.
- Use owner-only/session-specific networking where only one player should know data.
- Use PVS overrides sparingly and document why.
- Test with fake lag and two clients for visible gameplay.

## Red Flags

- `[NetworkedComponent]` outside `Content.Shared`.
- Shared code calling server-only systems directly.
- `IRobustRandom` in predicted shared logic without a deterministic prediction-safe seed.
- `PopupEntity` or `PlayPvs` inside predicted paths.
- `Dirty` every tick without a rate or state model.

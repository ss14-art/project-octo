---
name: ss14-prediction
description: Prediction guidance for SS14-ART-CORE SS14 work. Use when player actions should feel immediate, when touching shared systems, networked components, predicted popups/audio/spawn/delete, predicted BUI messages, or misprediction debugging.
---

# SS14 Prediction

Prediction is required for new interactive gameplay unless impossible.

## Workflow

1. Open `references/prediction-checklist.md`.
2. Open `references/networked-component-state.md`.
3. Open `references/predicted-feedback.md`.
4. Open `references/bui-prediction.md` for UI input.

## Reference Split

- `references/prediction-checklist.md`: first-pass review of whether a feature can and should be predicted.
- `references/networked-component-state.md`: `[NetworkedComponent]`, auto state generation, dirtying, field deltas, and cloneable state.
- `references/predicted-feedback.md`: popups, audio, spawn/delete, random, and idempotent predicted feedback.
- `references/bui-prediction.md`: component-backed BUI and `SendPredictedMessage`.

## Rules

- Put predicted logic in shared.
- Dirty authoritative state changes.
- Use predicted feedback APIs.
- Test with fake lag and two clients for visible gameplay.

---
name: ss14-prediction
description: Prediction guidance for Shine Project SS14 work. Use when player actions should feel immediate, when touching shared systems, networked components, predicted popups/audio/spawn/delete, predicted BUI messages, or misprediction debugging.
---

# SS14 Prediction

Prediction is required for new interactive gameplay unless impossible.

## Workflow

1. Open `references/prediction-checklist.md`.
2. Open `references/networked-component-state.md`.
3. Open `references/predicted-feedback.md`.
4. Open `references/bui-prediction.md` for UI input.

## Rules

- Put predicted logic in shared.
- Dirty authoritative state changes.
- Use predicted feedback APIs.
- Test with fake lag and two clients for visible gameplay.

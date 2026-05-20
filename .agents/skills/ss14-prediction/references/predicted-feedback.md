# Predicted Feedback

## Popup

Use `PopupPredicted` or `PopupClient` in predicted paths.

## Audio

Use `PlayPredicted` when the predicting user should hear immediate feedback.

## Spawn/Delete

Use predicted spawn/delete helpers where shared predicted code creates or removes entities.

## Guard

Non-idempotent client effects must account for prediction replay.

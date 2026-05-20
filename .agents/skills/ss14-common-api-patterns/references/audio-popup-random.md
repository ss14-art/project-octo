# Audio Popup Random

## Audio

- Use `SoundSpecifier`.
- Use `PlayPredicted` in predicted shared code.
- Use PVS/local variants only when prediction does not apply.

## Popup

- Use localized strings.
- Use `PopupPredicted` or `PopupClient` in predicted paths.

## Random

- Do not use nondeterministic `IRobustRandom` in predicted shared logic unless the local code has a prediction-safe helper or seed.

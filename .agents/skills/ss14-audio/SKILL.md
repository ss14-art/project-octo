---
name: ss14-audio
description: Audio guidance for SS14 Shine work, including SoundSpecifier, sound collections, predicted audio, MIDI/soundfonts, resource placement, localization-adjacent feedback, and avoiding duplicated or hardcoded sound playback.
---

# SS14 Audio

## Rules

- Put new Shine audio under `Resources/Audio/_sh`.
- Use `SoundSpecifier`; prefer `SoundCollectionSpecifier` for reusable sets.
- Do not hardcode sound paths in gameplay logic when a data field or prototype can configure them.
- Use `SharedAudioSystem.PlayPredicted` in predicted paths.
- Use server/PVS/local playback only when the local pattern and prediction requirements allow it.
- Avoid playing sounds from predicted update loops unless explicitly designed and guarded.

## MIDI

If MIDI or soundfont behavior changes, read the local WizDen MIDI docs and current repo code first.

## Sources

See `ss14-wizden-docs` for conventions and `robust-toolbox/midi.md`.

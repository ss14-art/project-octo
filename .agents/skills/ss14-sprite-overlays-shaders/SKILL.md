---
name: ss14-sprite-overlays-shaders
description: Sprite, overlay, shader, RSI, and rendering resource guidance for Shine Project SS14 work. Use when adding or reviewing sprite states, overlays, shaders, icons, displacement maps, RSI metadata, visual resources, or client rendering code.
---

# SS14 Sprite Overlays Shaders

This is the rendering-resource companion to `ss14-graphics-generic-visualizer-appearance`.

## Workflow

1. Open `references/sprite-resource-checklist.md`.
2. Open `references/overlay-patterns.md`.
3. Open `references/shader-and-displacement-notes.md`.

## Rules

- Put Shine textures under `Resources/Textures/_sh`.
- Preserve asset attribution.
- Keep render code client-side.
- Prefer data-driven visual state over hardcoded sprite switches.

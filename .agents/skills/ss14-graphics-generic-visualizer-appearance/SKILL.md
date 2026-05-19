---
name: ss14-graphics-generic-visualizer-appearance
description: Appearance and GenericVisualizer guidance for Shine Project SS14 work. Use when adding or reviewing AppearanceComponent data, GenericVisualizer YAML, sprite-layer state changes, dynamic sprites, or old visualizer ports.
---

# SS14 Appearance Visualizers

Prefer data-driven visuals through appearance data and prototype visualizers.

## Workflow

1. Open `references/appearance-data-flow.md`.
2. Open `references/generic-visualizer-patterns.md`.
3. Open `references/visual-prototype-anchors.md`.

## Rules

- Keep visual state data explicit and networked when clients need it.
- Use `AppearanceSystem.SetData` from systems.
- Keep sprite state names in prototypes/data where possible.
- Put Shine visuals under `_sh` resource and client paths.

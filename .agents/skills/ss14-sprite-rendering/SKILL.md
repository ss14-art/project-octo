---
name: ss14-sprite-rendering
description: Sprite, RSI, icon, appearance visualizer, overlay, shader, displacement map, and rendering guidance for SS14 Shine work. Use when changing visuals, dynamic sprites, GenericVisualizer, overlays, textures, or shader resources.
---

# SS14 Sprite Rendering

## Resources

- Put new Shine textures under `Resources/Textures/_sh`.
- Keep RSI `meta.json` ordered and formatted.
- Preserve license and copyright metadata.
- Use `SpriteSpecifier` for configurable sprite fields.

## Visuals

- Prefer `AppearanceComponent` plus `GenericVisualizer` for data-driven visuals.
- Port old appearance visualizers by separating data from logic, ECS-ifying state, and using prototypes where possible.
- Keep overlays/shaders client-side unless shared data is needed.
- Do not hardcode sprite states in gameplay systems when a data field/prototype can configure them.

## Sources

See rendering sprites/icons, lighting/FOV, shaders, displacement maps, and dynamic sprite docs through `ss14-wizden-docs`.

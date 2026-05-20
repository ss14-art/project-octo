---
name: ss14-transform-physics
description: Transform, coordinates, grids, maps, anchoring, fixtures, collision, joints, and physics guidance for Shine Project SS14 work. Use when changing movement, placement, anchoring, collision layers/masks, grid behavior, or map coordinates.
---

# SS14 Transform Physics

## Transform

- Use transform/anchoring system APIs.
- Prefer `EntityCoordinates`/map/grid-aware APIs over raw coordinates.
- Be explicit about nullspace, map IDs, grid IDs, and anchored state.

## Physics

- Use existing collision layers/masks and constants.
- Do not invent hardcoded bitmasks.
- Prefer transform anchoring; use static physics bodies only when the choice is deliberate.
- Keep fixtures, density, masks, and layers prototype/data-driven where possible.

## Bundled References

- `references/coordinate-and-grid-rules.md`: entity/map/grid coordinates, nullspace, anchoring, and map-aware placement.
- `references/collision-and-fixtures.md`: fixture/layer/mask/joint review and physics performance checks.

## Prediction

Movement and interaction code often needs prediction. Load `ss14-networking-prediction` for client-visible behavior.

## Sources

See `robust-toolbox/coordinate-systems.md`, `transform/entity-coordinates.md`, `transform/grids.md`, and `transform/physics.md` through `ss14-wizden-docs`.

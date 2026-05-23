---
name: ss14-ecs-prototypes
description: Prototype-focused ECS guidance for SS14-ART-CORE SS14 work. Use when creating or reviewing entity prototypes, abstract parents, reusable prototype components, reagent prototypes, GenericVisualizer YAML, localized prototypes, or test anchors.
---

# SS14 ECS Prototypes

Use this when the feature is expressed through YAML and data composition.

## Workflow

1. Open `references/prototype-structure.md`.
2. Open `references/item-and-structure-examples.md` for entities.
3. Open domain examples as needed: reagents, visualizers, localization, test anchors.
4. Put new SS14-ART-CORE prototypes under `Resources/Prototypes/_Art`.

## Rules

- Prefer prototypes over enums for gameplay categories.
- Keep abstract parents reusable.
- Avoid hardcoded IDs in systems; reference typed prototype IDs from data.

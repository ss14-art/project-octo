---
name: ss14-ecs-components
description: Component-specific ECS guidance for Shine Project SS14 work. Use when adding, moving, networking, serializing, reviewing, or refactoring components, DataFields, access restrictions, ProtoId fields, and component examples.
---

# SS14 ECS Components

Components are data. Systems own behavior.

## Workflow

1. Open `references/component-checklist.md`.
2. Open `references/datafield-and-protoid-style.md`.
3. Open `references/component-networking.md` if the component is shared/networked.
4. Put new Shine components under the relevant `_sh` assembly path.

## Rules

- Use `[RegisterComponent]` and `partial`.
- Use `[Access]` or `[Friend]` to restrict mutation when practical.
- Do not put gameplay logic or side-effecting setters in components.
- Prefer typed IDs and specifiers over raw strings.

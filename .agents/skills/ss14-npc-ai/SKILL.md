---
name: ss14-npc-ai
description: NPC and AI guidance for SS14 Shine work, including blackboards, tasks, planning, pathfinding, collision avoidance, updates, behavior reuse, and data-driven NPC prototypes.
---

# SS14 NPC AI

## Rules

- Reuse existing NPC systems, tasks, blackboard keys, and pathfinding services.
- Keep behavior data-driven through prototypes/components.
- Avoid one-off AI branches for specific prototype IDs.
- Do not add broad per-tick scans when event or task scheduling can work.
- Validate combat/interaction authority on the server.
- Localize player-facing feedback.

## Design

NPC behavior should be composable: sensing, planning, movement, action, and feedback should be separable enough that future NPCs can reuse them.

## Sources

Read `space-station-14/core-tech/npcs.md` through `ss14-wizden-docs`.

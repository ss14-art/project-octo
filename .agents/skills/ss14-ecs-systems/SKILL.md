---
name: ss14-ecs-systems
description: EntitySystem guidance for Shine Project SS14 work. Use when adding or reviewing systems, system dependencies, event subscriptions, public APIs, Try/Can/Do flow, shared/server/client splits, or component mutation methods.
---

# SS14 ECS Systems

Systems are where gameplay behavior lives.

## Workflow

1. Open `references/system-patterns.md`.
2. Open `references/dependency-and-subscription-style.md`.
3. Open `references/try-can-do-pattern.md` for action APIs.
4. Open `references/shared-server-client-split.md` if prediction or side-specific behavior matters.

## Rules

- Keep handlers thin.
- Use system dependencies.
- Make public APIs reusable and entity-first.
- Mutate components through setter/action methods that dirty and raise events correctly.

---
name: shine-project
description: Master workflow for working in the Shine Project SS14 fork. Use for any code, content, resource, test, review, or agent-instruction change in this repository, especially Content.Shared, Content.Server, Content.Client, Resources, .agents, CodeRabbit, and fork/upstream merge-sensitive work.
---

# Shine Project

This is the root skill for Shine Project. Use it first, then load narrower SS14 skills only as needed.

## Required Preflight

1. Read `.agents/rules/shine-hard-guardrails.md`.
2. Read `.agents/rules/shine-upstream-edit-markers.md`.
3. Read `.agents/rules/ss14-skill-preflight-and-refresh.md`.
4. Identify affected assemblies and load the matching skills.
5. Search the repo for current patterns before coding.

## Hard Rules

- Never edit `RobustToolbox/**`.
- Put new Shine-only code under `_sh`.
- Wrap every change outside `_sh` in a narrow marker block:

```csharp
// shine-edit start: reason
CODE
// shine-edit end
```

- Keep mechanics modular and data-driven.
- Do not duplicate existing mechanics.
- Do not hardcode when a prototype, CVar, `ProtoId<T>`, `DataField`, `SoundSpecifier`, `SpriteSpecifier`, or localization key can express the behavior.
- Use .NET 10-current APIs by checking `global.json`, package versions, local code, and official docs when framework details matter.

## Work Shape

Prefer this order:

1. Understand existing implementation.
2. Decide whether the change belongs in Shared, Server, Client, Resources, or tests.
3. Add fork-only code under `_sh`.
4. Touch upstream files only for integration points and mark them.
5. Add localization and prototypes with namespaced IDs.
6. Validate with the narrowest useful command.
7. Review the diff against `.agents/rules/ss14-review-checklist.md`.

## Skill Routing

Use `.agents/rules/ss14-skill-preflight-and-refresh.md` for exact routing. Common pairings:

- Gameplay feature: `ss14-ecs-basics`, `ss14-client-server-shared`, `ss14-networking-prediction`, `ss14-prototype-basics`.
- UI: `ss14-ui-xaml`, `ss14-ui-bui` or `ss14-ui-eui`.
- Resources: `ss14-prototype-basics`, `ss14-sprite-rendering`, `ss14-audio`.
- Persistence: `ss14-databases-migrations`.
- Review bot work: `ss14-ai-workflow`, `ss14-code-style`, `ss14-testing`.

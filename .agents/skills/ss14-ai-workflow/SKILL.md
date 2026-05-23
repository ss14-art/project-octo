---
name: ss14-ai-workflow
description: Preflight, implementation, and self-review workflow for AI agents working on SS14-ART-CORE SS14 code. Use when planning or making any repository change, reviewing PRs, hardening instructions, or deciding which .agents skills/rules apply.
---

# SS14 AI Workflow

Use this skill to keep agent work boring, narrow, and reviewable.

## Workflow

1. Load `ss14-art-core`.
2. Read subtree `AGENTS.md` files in every edited area.
3. Search for existing systems, components, prototypes, localization IDs, tests, and configs.
4. Choose the smallest domain skills for the change.
5. Implement through existing public system APIs where possible.
6. Add new APIs only when they remove real duplication or make future extension safer.
7. Validate, then self-review with `.agents/rules/ss14-review-checklist.md`.

## Bundled References

- `references/ai-strengths-and-risks.md`: where agents help and where they usually create review noise.
- `references/prompting-patterns.md`: how bridge files should route requests into canon without duplicating policy.
- `references/verification-rules.md`: validation and self-review loop for code, resources, docs, and bot config.

## Anti-Patterns To Stop

- Writing code before checking current local patterns.
- Copying old WizDen examples without updating to this repo and .NET 10.
- Touching upstream files for convenience.
- Adding hardcoded prototype or localization IDs in systems.
- Making server-only interactive mechanics when shared prediction is feasible.
- Adding a second implementation of an existing mechanic instead of extending it.

## CodeRabbit And Review Bots

When editing bot instructions:

- Keep `.agents/rules` as the canon.
- Adapters should route to canon, not duplicate long policy.
- Path-specific instructions should be concrete and low-noise.
- Treat assertive review profiles as something to tune after real PRs.

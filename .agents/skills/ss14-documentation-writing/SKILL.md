---
name: ss14-documentation-writing
description: Documentation guidance for SS14-ART-CORE SS14 changes. Use when writing or updating markdown docs, guidebook entries, XML docs, design docs, comments, PR explanations, changelog notes, or agent-facing documentation.
---

# SS14 Documentation Writing

Use docs to make code discoverable and reviewable, not to excuse unclear architecture.

## Workflow

1. Open `references/docs-discoverability.md`.
2. Open `references/code-change-docs.md` for XML docs and comments.
3. Open `references/design-docs-and-prs.md` for feature proposals or PR text.
4. Keep SS14-ART-CORE policy in `.agents`; do not make `docs/` the source of truth for agents.

## Rules

- Explain why and how to use a system.
- Avoid duplicating implementation line-by-line.
- Keep public EntitySystem APIs and non-obvious DataFields documented.
- Update guidebook/FTL/prototype docs in the same pass when player-facing behavior changes.

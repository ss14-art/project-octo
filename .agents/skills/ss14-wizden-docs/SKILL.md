---
name: ss14-wizden-docs
description: Route and summarize the local WizDen documentation snapshot for Shine Project SS14 work. Use when an agent needs SS14/RobustToolbox docs context for ECS, prediction, networking, UI, prototypes, mapping, departments, design docs, rendering, toolshed, setup, debugging, porting, or licensing.
---

# SS14 WizDen Docs

The local docs snapshot is at `D:\.avid\docs\src\en`. Use it for domain context, then prefer current repo code and Shine rules when there is a conflict.

## Canon Rule

Docs are reference material. `.agents/rules` and `.agents/skills` are the source of truth for Shine behavior.

## How To Use

1. Read `references/wizden-docs-notes.md` for distilled Shine-facing takeaways.
2. Read `references/wizden-docs-index.md` for the manually curated map of the high-value docs the project cares about most.
3. Read `references/wizden-docs-full-catalog.md` when the task mentions a niche subsystem, admin/server-hosting/staff docs, maintainer notes, or any document not present in the curated map.
4. Read the local source docs named there if a change touches that domain.
5. Apply Shine guardrails: `_sh` placement, no RobustToolbox edits, markers outside `_sh`, prediction, localization, and modular ECS.
6. If a doc is stale, follow current repo code and leave/update a skill note rather than copying stale guidance.

## Bundled References

- `references/wizden-docs-notes.md`: compressed engineering/design takeaways from the docs.
- `references/wizden-docs-index.md`: curated routing map for the files most relevant to code, resources, gameplay, UI, mapping, and review.
- `references/wizden-docs-full-catalog.md`: generated heading catalog of every markdown file under `D:\.avid\docs\src\en`.
- `scripts/build_wizden_catalog.py`: regenerate the full catalog after the local docs snapshot changes.

## High-Value Docs

- Code style: `general-development/codebase-info/conventions.md`
- Fork rules: `general-development/tips/forking.md`
- Prediction: `ss14-by-example/prediction-guide.md`
- Networking: `ss14-by-example/basic-networking-and-you.md`
- ECS: `robust-toolbox/ecs.md`
- UI: `robust-toolbox/user-interface.md`, `ss14-by-example/ui-and-you.md`
- Localization: `ss14-by-example/fluent-and-localization.md`
- Debugging: `general-development/tips/debugging-tools.md`
- Mapping: `space-station-14/mapping/guides/general-guide.md`

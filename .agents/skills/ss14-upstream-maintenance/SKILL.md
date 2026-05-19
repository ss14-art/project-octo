---
name: ss14-upstream-maintenance
description: Upstream/fork maintenance guidance for Shine Project. Use when touching non-_sh files, reviewing upstream diffs, preserving path similarity, porting fork code, marking shine-edit blocks, or deciding whether an engine/content change is allowed.
---

# SS14 Upstream Maintenance

This skill protects Shine from painful upstream merges.

## Workflow

1. Open `references/engine-boundaries.md`.
2. Open `references/fork-only-content.md`.
3. Open `references/edit-strategy.md`.
4. Open `references/edit-types.md` and `references/path-similarity.md` for ports.

## Rules

- Never edit `RobustToolbox`.
- Prefer `_sh` fork-owned files.
- Mark every non-`_sh` change with narrow `shine-edit` blocks.
- Keep upstream diffs small and intentional.

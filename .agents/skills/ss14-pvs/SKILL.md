---
name: ss14-pvs
description: PVS-specific networking guidance for Shine Project SS14 work. Use when dealing with Potentially Visible Set, visibility overrides, nullspace, owner-only data, hidden role data, session-specific networking, cameras, or data leakage risk.
---

# SS14 PVS

This is the narrow PVS skill. For broader networking, use `ss14-netcode` and `ss14-prediction`.

## Workflow

1. Open `references/pvs-checklist.md`.
2. Open `references/visibility-overrides.md`.
3. Open `references/hidden-data-and-nullspace.md`.

## Rules

- Network only what a client should know.
- Use overrides sparingly and remove them.
- Treat hidden role/objective/inventory data as sensitive.
- Test PVS edge cases when entities move out of range.

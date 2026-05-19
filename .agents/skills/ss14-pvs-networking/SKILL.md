---
name: ss14-pvs-networking
description: PVS and visibility guidance for SS14 Shine work, including Potentially Visible Set, session-specific networking, owner-only data, PVS overrides, nullspace entities, hidden information, and anti-cheat-sensitive prediction.
---

# SS14 PVS Networking

## Rules

- Clients only receive entities in PVS unless overrides/subscriptions apply.
- Do not network hidden information globally for convenience.
- Use owner-only/session-specific state for private data.
- Use PVS overrides sparingly and remove them when no longer needed.
- Consider nullspace entities for abstract data, but remember they are not normally visible to clients.

## Review Questions

- Which clients actually need this data?
- Can a cheater infer hidden roles, inventory, objectives, or contraband from it?
- Does leaving PVS pause or detach the entity and break predicted logic?
- Is an override temporary, scoped, and documented?

## Sources

Read prediction guide PVS sections and `basic-networking-and-you.md` through `ss14-wizden-docs`.

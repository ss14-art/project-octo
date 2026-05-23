---
name: ss14-netcode
description: Netcode guidance for SS14-ART-CORE SS14 work. Use when adding or reviewing network events, NetEntity conversions, replicated state, component states, client/server request handling, session-specific data, and shared network payloads.
---

# SS14 Netcode

Keep network payloads explicit, small, shared, and validated.

## Workflow

1. Open `references/network-event-patterns.md`.
2. Open `references/netentity-and-state.md`.
3. Open `references/shared-server-client-routing.md`.

## Rules

- Put network payload types in shared.
- Use `NetEntity`, not raw `EntityUid`, across the wire.
- Validate client-to-server requests on the server.
- Prefer replicated component state when it is simpler than ad hoc events.

# Network Event Patterns

Use network events for explicit client/server messages.

Rules:

- payload types live in shared;
- mark payloads serializable/net-serializable when local patterns require it;
- keep payloads small;
- validate client-to-server requests;
- prefer replicated state for persistent data.

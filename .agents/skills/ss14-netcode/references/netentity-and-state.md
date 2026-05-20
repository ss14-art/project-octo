# NetEntity And State

Use `NetEntity` across the network and convert at boundaries.

Replicated state belongs in shared networked components when clients need ongoing data.

Avoid:

- raw `EntityUid` in network payloads;
- server-only types in shared messages;
- sending full state repeatedly when a dirty field or BUI state is enough.

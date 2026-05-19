# Content.Server Agent Rules

Use `ss14-client-server-shared`, `ss14-ecs-basics`, and domain skills for server-only systems.

- Put new Shine server code under `Content.Server/_sh`.
- Server code is authoritative; validate all client input.
- Use server-only code for persistence, admin/server services, and systems that cannot be predicted.
- If an upstream server file must be changed, wrap the exact diff in `shine-edit` markers.

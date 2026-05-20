# SS14 Netcode Security

Use this rule for network events, BUI messages, EUI messages, commands, and client-origin requests.

## Server Validation

Validate all of these on the server:

- sender session and attached entity;
- permissions/admin status;
- range and line of sight when relevant;
- target lifestage and ownership;
- cooldowns, hands, containers, inventory, and action availability;
- whether the request is still valid after prediction.

## Hidden Data

- Do not network antagonist status, objectives, inventory secrets, contraband flags, or admin-only data globally.
- Prefer owner-only or session-specific state.
- Use PVS overrides sparingly and with removal logic.

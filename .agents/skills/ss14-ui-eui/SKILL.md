---
name: ss14-ui-eui
description: EUI guidance for SS14 SS14-ART-CORE work. Use for admin/server-driven external UI flows, EUI messages, permission checks, server validation, and deciding when EUI is more appropriate than BUI or regular XAML UI.
---

# SS14 UI EUI

## Use EUI When

- The UI is admin/server-service oriented.
- It does not belong to a specific in-world entity.
- Server authority and permissions are central to the workflow.

## Rules

- Validate permissions server-side for every action.
- Keep state minimal and explicit.
- Localize visible strings.
- Avoid using EUI for normal entity-bound gameplay; use BUI for that.
- Keep client presentation in `Content.Client/_Art` and authority in `Content.Server/_Art`.

## Review

Check for authorization, spoofed messages, stale state, and leaks of sensitive data.

## Bundled References

- `references/eui-vs-bui.md`: when EUI is appropriate and when BUI/XAML is the better fit.
- `references/eui-security.md`: permission, spoofing, stale-state, and data-leak checks.

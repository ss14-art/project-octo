---
name: ss14-ui-bui
description: Bound User Interface guidance for SS14 Shine work. Use for BUI state, messages, predicted BUI interactions, component-backed UI, server validation, UI update methods, and separating BUI from XAML/EUI guidance.
---

# SS14 UI BUI

## Scope

Use this skill only for Bound User Interfaces. For XAML layout/style, use `ss14-ui-xaml`. For admin/external EUI, use `ss14-ui-eui`.

## Rules

- Server validates all BUI messages.
- Use `SendPredictedMessage` for predicted BUI input.
- Prefer component-backed UI data when networked fields already exist.
- Avoid duplicating component state into BUI state unless needed.
- Use `AfterAutoHandleStateEvent` and shared virtual update methods when predicted UI should react to component state.
- Keep UI labels localized.

## Placement

- Shared BUI state/message types: `Content.Shared/_sh`.
- Server BUI handling: `Content.Server/_sh`.
- Client window/controller code: `Content.Client/_sh`.

## Bundled References

- `references/ui-flow-map.md`: decide between XAML, BUI, EUI, shared state, and server handlers.
- `references/predicted-bui-patterns.md`: predicted BUI state/message patterns and common duplication traps.

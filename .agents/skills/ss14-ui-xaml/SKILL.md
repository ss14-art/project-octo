---
name: ss14-ui-xaml
description: XAML UI guidance for SS14 Shine work, including Robust UI controls, styles, containers, UI controllers, responsive layout, localization, and avoiding C#-only UI when XAML is appropriate.
---

# SS14 UI XAML

## Rules

- Prefer XAML over entirely C#-defined UI for new windows/layouts.
- Use existing controls, containers, style classes, and local UI patterns.
- Do not hardcode player-facing labels.
- Keep layout robust for localization and different window sizes.
- Avoid duplicating style definitions when a shared style class fits.
- Unsubscribe C# events when windows/controllers shut down.

## Placement

- XAML and client code go under `Content.Client/_sh`.
- Shared messages/state go under `Content.Shared/_sh`.
- FTL goes under `Resources/Locale/en-US/_sh`.

## Sources

See Robust UI docs, UI containers, `ui-and-you.md`, UI survival guide, and UI cookbook through `ss14-wizden-docs`.

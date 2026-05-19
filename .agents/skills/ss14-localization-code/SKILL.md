---
name: ss14-localization-code
description: C# localization guidance for Shine Project SS14 work. Use when adding popups, examine text, UI labels, admin/player messages, component-backed localization IDs, Loc.GetString calls, or entity grammar in code.
---

# SS14 Localization Code

No player-facing English in C#.

## Workflow

1. Open `references/localization-in-code.md`.
2. Open `references/entity-name-and-popup-patterns.md`.
3. Open `references/locid-and-component-fields.md` when localization IDs are stored in data.

## Rules

- Use `Loc.GetString`.
- Pass variables instead of concatenating grammar.
- Use entity grammar helpers in FTL for pronouns/articles.
- Store configurable localization IDs as `LocId` where local patterns support it.

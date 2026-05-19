# GitHub Copilot Instructions

This repo uses `.agents` as the canonical instruction layer.

Before suggesting code, follow:

- `.agents/rules/shine-hard-guardrails.md`
- `.agents/rules/shine-upstream-edit-markers.md`
- `.agents/rules/ss14-skill-preflight-and-refresh.md`

Do not suggest edits to `RobustToolbox/**`. New Shine code belongs in `_sh`. Any non-`_sh` edit must be surrounded by `shine-edit` markers. Prefer SS14 ECS, prediction, localization, typed prototypes, and .NET 10-current APIs.

# Shine Project Claude Adapter

Use `.agents/rules` and `.agents/skills` as the canonical instructions.

Start with:

- `.agents/rules/shine-hard-guardrails.md`
- `.agents/rules/shine-upstream-edit-markers.md`
- `.agents/rules/ss14-skill-preflight-and-refresh.md`

Never edit `RobustToolbox/**`. New Shine code belongs in `_sh`. Any edit outside `_sh` needs a tight `shine-edit` marker block. Prefer SS14 ECS, prediction, localization, typed data, and .NET 10-current APIs.

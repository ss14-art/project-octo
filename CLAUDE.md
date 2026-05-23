# SS14-ART-CORE Claude Adapter

Use `.agents/rules` and `.agents/skills` as the canonical instructions.

Start with:

- `.agents/rules/ss14-art-hard-guardrails.md`
- `.agents/rules/ss14-art-upstream-edit-markers.md`
- `.agents/rules/ss14-skill-preflight-and-refresh.md`

Never edit `RobustToolbox/**`. New SS14-ART-CORE code belongs in `_Art`. Any edit outside `_Art` needs a tight `ss14-art-edit` marker block. Prefer SS14 ECS, prediction, localization, typed data, and .NET 10-current APIs.

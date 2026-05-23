# SS14-ART-CORE Agent Router

This repository is an SS14 fork. Before making changes, load the canonical instruction layer:

1. `.agents/rules/ss14-art-hard-guardrails.md`
2. `.agents/rules/ss14-art-upstream-edit-markers.md`
3. `.agents/rules/ss14-skill-preflight-and-refresh.md`
4. The smallest relevant skill under `.agents/skills/`
5. If using Codex-specific automation, `.codex/config.toml` only bridges back to `.agents`; `.agents` remains canonical.

Hard rules:

- Never edit `RobustToolbox/**`.
- New SS14-ART-CORE code goes under `_Art`.
- Any file changed outside `_Art` needs a tight `ss14-art-edit` marker block.
- Prefer prediction, localization, data-driven prototypes, modular ECS systems, and .NET 10-current code.
- Do not duplicate mechanics or hardcode one-off behavior.

Subtree `AGENTS.md` files add local routing; follow them in addition to this root file.

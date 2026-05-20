# WizDen Docs Routing

The local WizDen docs snapshot is a reference library, not the source of truth for Shine policy.

- Canonical Shine policy lives in `.agents/rules` and `.agents/skills`.
- Use local docs at `D:\.avid\docs\src\en\...` to refresh domain knowledge before code changes.
- If local docs conflict with current repo code, prefer current repo code and update/extend the skill note instead of blindly following old docs.
- If docs conflict with Shine guardrails, Shine guardrails win.

Use `.agents/skills/ss14-wizden-docs/references/wizden-docs-index.md` for the curated map and `.agents/skills/ss14-wizden-docs/references/wizden-docs-full-catalog.md` for the complete local markdown catalog.

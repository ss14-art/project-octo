# SS14 Engine Boundaries

Use this rule whenever a task smells like it might require engine work.

## SS14-ART-CORE Default

- Do not edit `RobustToolbox/**`.
- Assume gameplay, prediction, UI, prototype, and localization issues belong in content code first.
- Treat engine edits as escalation, not cleanup.

## Before Proposing Engine Work

1. Confirm the issue cannot be solved in `Content.Shared`, `Content.Server`, `Content.Client`, or `Resources`.
2. Check whether SS14-ART-CORE can add an extension point under `_Art`.
3. Prefer extending an existing public content API over patching engine internals.
4. Explain the missing engine hook to the user/maintainer before editing.

## Bad Escalations

- Moving fork-only gameplay into the engine.
- Editing engine code because it feels cleaner than using content architecture.
- Refactoring engine internals while fixing a content bug.

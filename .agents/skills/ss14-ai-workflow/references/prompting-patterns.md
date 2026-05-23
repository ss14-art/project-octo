# Prompting Patterns

## Good Agent Prompts

- Name the subsystem and target assembly.
- Say whether prediction is required.
- Mention localization and `_Art` placement.
- Ask to search for existing mechanics first.
- Ask for reusable component/system APIs, not one-off prototype branches.

## Example

> Add a SS14-ART-CORE-only reusable component/system under `_Art` for this interaction. Keep it predicted if possible, localize all text, do not edit RobustToolbox, and mark any non-`_Art` integration edits.

## Bad Prompt Smells

- "Just make it work."
- "Copy this other feature" without asking for adaptation.
- "Hardcode this prototype for now."

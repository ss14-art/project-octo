# Prompting Patterns

## Good Agent Prompts

- Name the subsystem and target assembly.
- Say whether prediction is required.
- Mention localization and `_sh` placement.
- Ask to search for existing mechanics first.
- Ask for reusable component/system APIs, not one-off prototype branches.

## Example

> Add a Shine-only reusable component/system under `_sh` for this interaction. Keep it predicted if possible, localize all text, do not edit RobustToolbox, and mark any non-`_sh` integration edits.

## Bad Prompt Smells

- "Just make it work."
- "Copy this other feature" without asking for adaptation.
- "Hardcode this prototype for now."

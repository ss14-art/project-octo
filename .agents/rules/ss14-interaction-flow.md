# SS14 Interaction Flow

Use the repo-standard interaction flow for actions, verbs, in-hand use, BUI actions, and other entity-driven gameplay APIs.

## Required Shape

- `OnXEvent(...)`: event entry point.
- `TryX(...)`: reusable public action API.
- `CanX(...)`: checks only.
- `DoX(...)`: mutation after validation, or an execution section inside `TryX`.

## Handler Rules

- Keep `On...` handlers thin.
- Handle `args.Handled`, cancellation flags, or obvious routing conditions there.
- Forward to `Try...` instead of embedding full gameplay logic in the handler.

## Can Rules

- Do not mutate component or entity state inside `Can...`.
- It is acceptable to emit popup feedback when `quiet == false`.
- Prefer `bool quiet = false` where callers may need silent checks.

## Anti-Patterns

- Thick event handlers that cannot be reused from verbs, UI, or other systems.
- `Can...` methods that decrement ammo, change visuals, or dirty components.
- `Try...` methods that skip checks and trust the caller.

# Try Can Do Pattern

## Pattern

- `On...`: receive event and route.
- `Try...`: reusable action API, returns success.
- `Can...`: checks only.
- `Do...`: performs mutation after validation.

## Rules

- `Try...` calls `Can...`; do not trust callers.
- `Can...` can optionally emit feedback with `quiet = false`.
- `Do...` may assume validation but should still be safe around deleted/missing entities.

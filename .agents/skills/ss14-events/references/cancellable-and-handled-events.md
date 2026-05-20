# Cancellable And Handled Events

## Cancellable

Use when subscribers can prevent an action. Check cancellation before mutation.

## Handled

Use when only one subscriber should handle something. Respect `Handled`.

## Rules

- Do not uncancel casually.
- Keep input fields clear.
- Document whether fields are input, output, or both.

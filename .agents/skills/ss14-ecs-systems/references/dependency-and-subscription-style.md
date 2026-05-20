# Dependency And Subscription Style

## Dependencies

Use `[Dependency] private readonly SomeSystem _some = default!;`.

Avoid resolving systems in method bodies.

## Subscriptions

Subscribe in `Initialize`.

Use handler names like `OnActivateEvent`, `OnComponentInit`, or the local subsystem convention.

Unsubscribe manual C# events when needed; Robust event subscriptions usually follow system lifetime.

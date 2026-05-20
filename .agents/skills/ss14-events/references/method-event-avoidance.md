# Method Event Avoidance

Method events behave like hidden method calls and make flow harder to reason about.

Prefer:

- public EntitySystem APIs;
- directed informative events after mutation;
- cancellable attempt events before mutation.

If a method-event-like pattern exists, wrap it behind a public system method so callers do not raise it directly.

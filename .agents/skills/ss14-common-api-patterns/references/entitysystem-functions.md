# EntitySystem Functions

## Public API Shape

```csharp
public bool TryDoThing(Entity<MyComponent?> ent, EntityUid user)
{
    if (!Resolve(ent, ref ent.Comp))
        return false;

    if (!CanDoThing(ent, user))
        return false;

    DoThing((ent.Owner, ent.Comp), user);
    return true;
}
```

## Rules

- Entity arguments first.
- Resolve early.
- Return `bool` for standard attempts.
- Keep `Can...` mutation-free.

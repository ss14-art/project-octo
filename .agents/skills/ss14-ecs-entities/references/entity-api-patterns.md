# Entity API Patterns

Use entity-first APIs:

```csharp
public void SetEnabled(Entity<MyComponent?> ent, bool enabled)
{
    if (!Resolve(ent, ref ent.Comp))
        return;

    if (ent.Comp.Enabled == enabled)
        return;

    ent.Comp.Enabled = enabled;
    Dirty(ent);
}
```

This supports callers with either just a UID or a resolved pair.

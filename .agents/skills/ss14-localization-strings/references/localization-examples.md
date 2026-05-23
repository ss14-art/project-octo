# Localization Examples

```ftl
art-core-widget-popup-locked = { CAPITALIZE(THE($target)) } is locked.
art-core-widget-popup-user-locks = { CAPITALIZE(THE($user)) } locks {THE($target)}.
```

```csharp
Loc.GetString("art-core-widget-popup-user-locks", ("user", user), ("target", target))
```

Keep IDs feature-scoped.

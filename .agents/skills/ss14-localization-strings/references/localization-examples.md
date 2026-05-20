# Localization Examples

```ftl
shine-widget-popup-locked = { CAPITALIZE(THE($target)) } is locked.
shine-widget-popup-user-locks = { CAPITALIZE(THE($user)) } locks {THE($target)}.
```

```csharp
Loc.GetString("shine-widget-popup-user-locks", ("user", user), ("target", target))
```

Keep IDs feature-scoped.

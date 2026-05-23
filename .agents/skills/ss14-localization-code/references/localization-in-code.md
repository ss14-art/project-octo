# Localization In Code

Use:

```csharp
Loc.GetString("art-core-feature-message", ("user", user), ("target", target))
```

Avoid:

- raw English strings;
- string concatenation for grammar;
- comparing localized output;
- showing raw IDs to players.

Put matching FTL under `Resources/Locale/en-US/_Art`.

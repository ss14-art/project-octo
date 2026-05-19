# Shine Upstream Edit Markers

Shine must stay easy to merge with upstream.

## Rule

Any modification to a file outside a `_sh` path segment must be surrounded by Shine markers:

```csharp
// shine-edit start: short reason
CODE
// shine-edit end
```

Use the same marker shape for comments in C#, YAML, FTL, XAML, TOML, JSON-with-comments, and Markdown when practical. For formats where `//` is invalid, use the native comment delimiter:

```yaml
# shine-edit start: short reason
code: here
# shine-edit end
```

```xml
<!-- shine-edit start: short reason -->
<Control />
<!-- shine-edit end -->
```

## Scope

- Marker blocks must be as small as possible.
- Do not wrap whole files unless the whole file is a Shine-owned adapter.
- Do not use markers in `RobustToolbox/**`; engine edits are forbidden.
- Do not hide unrelated formatting or reorder-only changes inside marker blocks.
- If a file already has a nearby Shine marker, extend the smallest existing block instead of creating marker noise.

## Preferred Alternative

Avoid upstream edits by adding or overriding fork-only code under `_sh`:

- `Content.Shared/_sh/...`
- `Content.Server/_sh/...`
- `Content.Client/_sh/...`
- `Resources/Prototypes/_sh/...`
- `Resources/Locale/en-US/_sh/...`
- `Resources/Textures/_sh/...`
- `Resources/Audio/_sh/...`

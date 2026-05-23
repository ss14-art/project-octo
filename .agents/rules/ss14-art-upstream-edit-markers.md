# SS14-ART-CORE Upstream Edit Markers

SS14-ART-CORE must stay easy to merge with upstream.

## Rule

Any modification to a file outside a `_Art` path segment must be surrounded by SS14-ART-CORE markers.

For multi-line changes:

```csharp
// ss14-art-edit start: short reason
CODE
// ss14-art-edit end
```

For single-line changes:

```csharp
CODE // ss14-art-edit: reason
```

Use the same marker shape for comments in C#, YAML, FTL, XAML, TOML, JSON-with-comments, and Markdown when practical. For formats where `//` is invalid, use the native comment delimiter:

```yaml
# ss14-art-edit start: short reason
code: here
# ss14-art-edit end

single_line: here # ss14-art-edit
```

```xml
<!-- ss14-art-edit start: short reason -->
<Control />
<!-- ss14-art-edit end -->

<Control Property="Value" /> <!-- ss14-art-edit -->
```

## Scope

- Marker blocks must be as small as possible.
- Do not wrap whole files unless the whole file is an SS14-ART-CORE-owned adapter.
- Do not use markers in `RobustToolbox/**`; engine edits are forbidden.
- Do not hide unrelated formatting or reorder-only changes inside marker blocks.
- If a file already has a nearby SS14-ART-CORE marker, extend the smallest existing block instead of creating marker noise.

## Preferred Alternative

Avoid upstream edits by adding or overriding fork-only code under `_Art`:

- `Content.Shared/_Art/...`
- `Content.Server/_Art/...`
- `Content.Client/_Art/...`
- `Resources/Prototypes/_Art/...`
- `Resources/Locale/en-US/_Art/...`
- `Resources/Textures/_Art/...`
- `Resources/Audio/_Art/...`

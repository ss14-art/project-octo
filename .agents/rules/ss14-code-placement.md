# SS14 Code Placement

## Assembly Boundaries

- `Content.Shared`: data and logic both client and server may run; predicted gameplay belongs here when possible.
- `Content.Server`: authoritative-only logic, persistence, admin-only server work, atmos/power-only flows that cannot be predicted.
- `Content.Client`: rendering, XAML/BUI client windows, visualizers, overlays, input UI, client-only presentation.
- `Resources`: prototypes, maps, textures, audio, localization, guidebook data.
- `Content.Tests` and `Content.IntegrationTests`: focused validation.
- `RobustToolbox`: read-only for Shine agents.

## Shine Placement

New Shine code must use `_sh` path segments:

- `Content.Shared/_sh/<Subsystem>/...`
- `Content.Server/_sh/<Subsystem>/...`
- `Content.Client/_sh/<Subsystem>/...`
- `Resources/Prototypes/_sh/<Subsystem>/...`
- `Resources/Locale/en-US/_sh/<Subsystem>/...`

Preserve SS14 folder semantics under `_sh`: `Components`, `EntitySystems`, `UI`, `Visualizers`, `Prototypes`, etc.

## Upstream Files

Only touch non-`_sh` files when integration requires it. Keep the diff narrow and apply `shine-edit` markers around the exact changed lines.

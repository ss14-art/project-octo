# SS14 Prototype YAML

Use this rule for YAML prototypes and serialized component data.

## Layout

- Prototype order: `type`, `abstract`, `parent`, `id`, `categories`, `name`, `suffix`, `description`, `components`.
- Components under `components:` are not extra-indented.
- Separate prototypes by one blank line.
- Use inline lists for categories and regular lists elsewhere.

## SS14-ART-CORE Placement

- New prototypes: `Resources/Prototypes/_Art/<Subsystem>/`.
- New locale: `Resources/Locale/en-US/_Art/<Subsystem>/`.
- New textures/audio: `Resources/Textures/_Art` and `Resources/Audio/_Art`.

## IDs

- Prototype IDs use PascalCase.
- FTL IDs use kebab-case.
- Fork-owned IDs should be art-core-namespaced enough to avoid collisions.

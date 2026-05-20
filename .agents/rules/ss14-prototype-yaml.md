# SS14 Prototype YAML

Use this rule for YAML prototypes and serialized component data.

## Layout

- Prototype order: `type`, `abstract`, `parent`, `id`, `categories`, `name`, `suffix`, `description`, `components`.
- Components under `components:` are not extra-indented.
- Separate prototypes by one blank line.
- Use inline lists for categories and regular lists elsewhere.

## Shine Placement

- New prototypes: `Resources/Prototypes/_sh/<Subsystem>/`.
- New locale: `Resources/Locale/en-US/_sh/<Subsystem>/`.
- New textures/audio: `Resources/Textures/_sh` and `Resources/Audio/_sh`.

## IDs

- Prototype IDs use PascalCase.
- FTL IDs use kebab-case.
- Fork-owned IDs should be Shine-namespaced enough to avoid collisions.

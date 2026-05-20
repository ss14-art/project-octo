# LocId And Component Fields

Use `LocId` for configurable localization keys when the local codebase supports that pattern.

Good for:

- component-provided popup messages;
- action names/descriptions;
- reusable UI labels;
- prototype-configurable feedback.

Do not store localized output strings in components. Store keys and arguments.

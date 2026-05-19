---
name: ss14-naming-conventions
description: Naming guidance for Shine Project SS14 C#, YAML, FTL, prototypes, components, systems, events, CVars, migrations, and fork-owned serialized types. Use whenever adding new names or reviewing naming consistency.
---

# SS14 Naming Conventions

Names are part of the API and merge strategy.

## Workflow

1. Open `references/csharp-and-ftl-naming.md`.
2. Open `references/prototype-and-resource-naming.md`.
3. Open `references/shine-prefixes-and-namespaces.md`.

## Rules

- Namespace fork-owned serializable types, prototypes, CVars, and migrations.
- Use PascalCase prototype IDs and component names.
- Use kebab-case FTL IDs.
- Keep Shine-specific paths under `_sh`.

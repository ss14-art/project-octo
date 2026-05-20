---
name: ss14-porting-and-licensing
description: Porting, attribution, fork isolation, upstream merge, and license guidance for Shine Project. Use before importing code/assets from WizDen, Delta-V, other SS14 forks, tgstation, assets, or external repositories, and before modifying upstream files.
---

# SS14 Porting And Licensing

## Before Porting

- Identify source repository, commit, original author, and license.
- Check whether code/assets are MIT, AGPL, MPL, CC-BY-SA, CC-BY-NC-SA, or another license.
- Do not import incompatible assets or hidden-source-incompatible code.
- Preserve attribution in metadata, comments, or license files as appropriate.

## Fork Isolation

- Put new Shine code/assets under `_sh`.
- Namespace serialized types and prototype IDs with a Shine prefix.
- Avoid changing upstream files. If required, use tight `shine-edit` markers.
- Preserve path similarity under `_sh` so upstream equivalents are easy to compare.

## Database Porting

- Avoid modifying upstream tables.
- Prefer one-to-one fork-owned tables for Shine-only data.
- Namespace migrations.
- Test SQLite and Postgres paths when persistence changes.

## Bundled References

- `references/source-license-checklist.md`: source, commit, author, license, compatibility, and import decision checks.
- `references/attribution-patterns.md`: code, asset, RSI, station image, and generic attribution placement.

## Sources

See `ss14-wizden-docs` for forking tips, PRs with engine changes, generic attribution, station image specs, and PR guidelines.

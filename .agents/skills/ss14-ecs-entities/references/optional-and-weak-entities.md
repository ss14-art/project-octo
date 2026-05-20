# Optional And Weak Entities

## Optional

Use `EntityUid?` when an entity reference may be absent.

Do not use `EntityUid.Invalid` for optional data.

## Deleted Entities

Networked entity references can break if the referenced entity is deleted. Clear references on deletion/removal events where needed.

## Network

Use `NetEntity` in network payloads and convert at boundaries.

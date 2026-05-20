# Networking And Dirty

## Dirty Rules

- Dirty after authoritative networked state changes.
- Use `DirtyField` for field deltas.
- Guard no-op setter calls to avoid unnecessary network traffic.
- Do not dirty in tight loops unless the data model requires it.

## Placement

Networked component fields belong in shared. Server-only components should not use `[NetworkedComponent]`.

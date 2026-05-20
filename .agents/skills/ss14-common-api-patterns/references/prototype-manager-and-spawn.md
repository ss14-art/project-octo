# Prototype Manager And Spawn

## Prototypes

- Store typed prototype IDs in data.
- Index through `IPrototypeManager` when needed.
- Avoid caching prototype objects unless a current subsystem pattern requires it.

## Spawning

- Use predicted spawn APIs in shared predicted paths.
- Keep spawned prototype IDs configurable.
- For abstract data, consider nullspace behavior and PVS visibility.

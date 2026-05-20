# DataField And ProtoId Style

## DataField

- Prefer `[DataField]` without an explicit serialized key.
- Add XML docs for public/non-obvious fields.
- Use custom serializers only when needed.

## Prototype IDs

- Use `ProtoId<T>` for prototype references.
- Use `EntProtoId` for entity prototype IDs when the local code uses it.
- Avoid raw strings in systems.

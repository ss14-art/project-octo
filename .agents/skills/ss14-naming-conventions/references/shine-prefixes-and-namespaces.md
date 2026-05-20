# Shine Prefixes And Namespaces

Fork-owned serialized names should avoid upstream collisions.

Use Shine-specific prefixes for:

- prototype IDs;
- CVars;
- migrations;
- serializable component-like types where global names can collide;
- localization keys.

Do not rename existing upstream IDs for cosmetic consistency.

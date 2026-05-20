# Overlay Patterns

Overlays are client presentation.

Rules:

- keep gameplay state in shared/server components;
- pass only required visual data to client;
- avoid doing authority checks in overlay code;
- clean up subscriptions and cached entities when views close or entities delete.

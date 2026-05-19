# Content.Shared Agent Rules

Use `ss14-client-server-shared`, `ss14-ecs-basics`, and `ss14-networking-prediction`.

- Put new Shine shared code under `Content.Shared/_sh`.
- Shared code must only depend on shared APIs.
- Predicted interactive gameplay should live here when possible.
- Networked shared components need `NetworkedComponent`, component state generation, `AutoNetworkedField`, and correct `Dirty`/`DirtyField`.
- Keep components data-only and behavior in EntitySystems.

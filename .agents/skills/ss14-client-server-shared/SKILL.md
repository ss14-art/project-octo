---
name: ss14-client-server-shared
description: Placement and dependency rules for SS14 Content.Shared, Content.Server, Content.Client, Resources, and tests. Use when deciding where Shine code belongs or when splitting predicted/shared logic from server authority and client presentation.
---

# SS14 Client Server Shared

## Placement Decisions

- `Content.Shared/_sh`: predicted gameplay, shared components, network event definitions, shared public APIs, data used by both sides.
- `Content.Server/_sh`: authority-only logic, persistence, admin/server services, systems impossible to predict.
- `Content.Client/_sh`: UI, visualizers, overlays, client-only presentation, client BUI windows.
- `Resources/_sh`: prototypes, maps, audio, textures, localization.
- Tests go in `Content.Tests` or `Content.IntegrationTests` based on scope.

## Dependency Direction

- Shared cannot depend on Server or Client.
- Server and Client may depend on Shared.
- Client code is never authoritative.
- Server must validate client-origin actions.

## Bundled References

- `references/client-server-primer.md`: assembly responsibilities and dependency direction.
- `references/shared-and-prediction.md`: shared abstract systems, client/server derived systems, and predicted split choices.
- `references/networking-and-dirty.md`: dirtying, component state, and server validation reminders.

## Predicted Split Pattern

When a system needs side-specific code:

- Put common logic in an abstract shared system.
- Inherit from it on server and client.
- Add an empty client system if needed so shared predicted logic runs client-side.

## Upstream Files

Touch non-`_sh` files only for integration points and mark those edits.

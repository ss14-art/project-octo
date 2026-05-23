# SS14 Skill Preflight And Refresh

Before changing code, identify the affected area and load the smallest relevant skills.

## Always Start With

- `ss14-art-core`
- `ss14-ai-workflow`
- `ss14-code-style`
- `ss14-naming-conventions`
- `ss14-upstream-maintenance`

## Route By Area

- New gameplay feature spanning code/resources: `ss14-gameplay-feature`
- Components: `ss14-ecs-components`
- Systems: `ss14-ecs-systems`
- Entities, optional entity refs, spawn/delete: `ss14-ecs-entities`
- Events: `ss14-events`
- Prototype, YAML, FTL: `ss14-prototype-basics`, `ss14-ecs-prototypes`, `ss14-prototypes-locale`
- Shared/server/client placement: `ss14-client-server-shared`
- Networked component, `Dirty`, client prediction, BUI prediction: `ss14-networking-prediction`, `ss14-prediction`, `ss14-netcode`
- PVS, visibility, session-specific state: `ss14-pvs-networking`, `ss14-pvs`
- Debugging, VV, fake lag, logs: `ss14-debugging-workflow`
- Common APIs, EntitySystem dependencies, audio, popup, prototypes: `ss14-common-api-patterns`
- Porting, attribution, licenses, fork isolation: `ss14-porting-and-licensing`
- Tests, YAML linter, integration tests: `ss14-testing`, `ss14-tests-authoring`
- Hot paths, update loops, allocations: `ss14-standard-optimizations`
- Documentation, XML docs, PR text, guidebook: `ss14-documentation-writing`
- Audio or MIDI: `ss14-audio`
- Atmos, gas, pipes, air alarms, vents, scrubbers: `ss14-atmos`
- Transform, maps, grids, physics, anchoring, collision: `ss14-transform-physics`
- BUI: `ss14-ui-bui`
- XAML controls/styles: `ss14-ui-xaml`
- EUI/admin UI: `ss14-ui-eui`
- Sprites, icons, RSI, overlays, shaders, visualizers: `ss14-sprite-rendering`, `ss14-sprite-overlays-shaders`, `ss14-graphics-generic-visualizer-appearance`
- EF Core, migrations, SQLite/Postgres, database schema: `ss14-databases-migrations`
- NPCs, AI, pathfinding, blackboards: `ss14-npc-ai`
- Reagents, reactions, metabolism, solution containers: `ss14-chemistry`
- Maps, departments, design docs, game-area proposals: `ss14-mapping-design`
- WizDen documentation lookup: `ss14-wizden-docs`

## Refresh Step

Before writing code, search the repo for the current implementation:

- `rg --files` for likely filenames.
- `rg` for component/system/prototype/localization IDs.
- Read nearby code before copying a pattern.
- Prefer the newest local pattern over old docs or old upstream examples.

# SS14 Skill Preflight And Refresh

Before changing code, identify the affected area and load the smallest relevant skills.

## Always Start With

- `shine-project`
- `ss14-ai-workflow`
- `ss14-code-style`

## Route By Area

- Components, systems, events: `ss14-ecs-basics`
- Prototype, YAML, FTL: `ss14-prototype-basics`
- Shared/server/client placement: `ss14-client-server-shared`
- Networked component, `Dirty`, client prediction, BUI prediction: `ss14-networking-prediction`
- PVS, visibility, session-specific state: `ss14-pvs-networking`
- Debugging, VV, fake lag, logs: `ss14-debugging-workflow`
- Common APIs, EntitySystem dependencies, audio, popup, prototypes: `ss14-common-api-patterns`
- Porting, attribution, licenses, fork isolation: `ss14-porting-and-licensing`
- Tests, YAML linter, integration tests: `ss14-testing`
- Audio or MIDI: `ss14-audio`
- Atmos, gas, pipes, air alarms, vents, scrubbers: `ss14-atmos`
- Transform, maps, grids, physics, anchoring, collision: `ss14-transform-physics`
- BUI: `ss14-ui-bui`
- XAML controls/styles: `ss14-ui-xaml`
- EUI/admin UI: `ss14-ui-eui`
- Sprites, icons, RSI, overlays, shaders, visualizers: `ss14-sprite-rendering`
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

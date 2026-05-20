# WizDen Docs Index For Shine Agents

Local docs root: `D:\.avid\docs\src\en`.

Use this as the curated routing map for the docs most often needed by code agents. Read the named local document before changing the matching subsystem. If the document is stale, follow current repo code and Shine rules.

For the complete local docs snapshot, including community, server-hosting, staff, admin, engine-development, and meeting-note documents not listed below, use `wizden-docs-full-catalog.md`.

## Development And Contribution

- `general-development/codebase-info.md`: landing page for codebase structure.
- `general-development/contributing-translations.md`: translation contribution flow and coordination.
- `general-development/feature-proposals.md`: when and how to write feature/design proposals.
- `general-development/game-area-design-doc.md`: game-area design doc template: concept, intended experience, responsibilities, desired/undesired gameplay.
- `general-development/github-moderation-guidelines.md`: moderation categories and actions for GitHub interactions.
- `general-development/setup.md`: setup landing page.
- `general-development/tips.md`: tips landing page.
- `general-development/tips/beginner-faq.md`: beginner contribution FAQ, where to search for code/text, and local development basics.
- `general-development/tips/config-file-reference.md`: TOML basics, CVars, and config specification methods.
- `general-development/tips/debugging-tools.md`: VV, dev window, tests, scripting, console usage, run configs, performance debugging, external tools.
- `general-development/tips/forking.md`: fork isolation, licensing, code organization, namespaced serializable types/prototypes/CVars, DB layout.
- `general-development/tips/prs-with-engine-changes.md`: engine submodule workflow and engine-change PR expectations. For Shine, engine edits are escalation-only.
- `general-development/tips/troubleshooting-faq.md`: client/server troubleshooting.
- `general-development/tips/writing-guidebook-entries.md`: guidebook controls, entries, IDs, priority, children, integration, and best practices.
- `general-development/tips/yaml-crash-course.md`: YAML scalar/list/dictionary/nesting basics.
- `general-development/setup/git-for-the-ss14-developer.md`: Git workflow, branches, remotes, conflicts, pushing, PRs.
- `general-development/setup/howdoicode.md`: beginner programming resources.
- `general-development/setup/server-hosting-tutorial.md`: local through production server hosting, hub config, watchdog, DB, metrics, logging.
- `general-development/setup/setting-up-a-development-environment.md`: clone, submodules, IDE setup, build options, Nix, troubleshooting.
- `general-development/feature-proposals/expected-feature-proposal-decorum.md`: proposal discussion etiquette.

## Codebase Info

- `general-development/codebase-info/acronyms-and-nomenclature.md`: common SS14/Robust terms.
- `general-development/codebase-info/codebase-organization.md`: Client/Shared/Server assemblies, game-code folder structure, resource organization.
- `general-development/codebase-info/conventions.md`: core C#, ECS, components, systems, events, prototypes, localization, YAML, performance, field deltas, TimeSpan rules.
- `general-development/codebase-info/pull-request-guidelines.md`: PR structure, testing, review, changelog.
- `general-development/codebase-info/releases.md`: release process, hotfixes, branching, review flow.

## Meta Docs

- `meta/docs-are-for-discoverability.md`: docs should help users discover concepts and next steps.
- `meta/docs-example-page.md`: markdown, templates, admonishments, LaTeX, Mermaid examples.
- `meta/guide-to-editing-docs.md`: docs style, building, testing, review.

## Robust Toolbox Reference

- `robust-toolbox/ioc.md`: IoC registration and dependency retrieval.
- `robust-toolbox/midi.md`: MIDI crackling, soundfonts, loading order.
- `robust-toolbox/preprocessor-defines.md`: common and uncommon defines.
- `robust-toolbox/publishing-robusttoolbox.md`: publishing RT.
- `robust-toolbox/robust-modules.md`: optional modules and module versions.
- `robust-toolbox/sandboxing.md`: sandbox implementation and violation debugging.
- `robust-toolbox/serialization.md`: serialization APIs, data definitions, DataField, serializers, inheritance behavior, contexts.
- `robust-toolbox/server-http-api.md`: `/status`, `/info`, watchdog APIs, info icons, standard tags, tag inference.
- `robust-toolbox/toolshed.md`: toolshed commands, help, explain, common commands, terminators, errors.
- `robust-toolbox/user-data-directory.md`: server/client/integration-test data paths.
- `robust-toolbox/user-interface.md`: Controls, layout, XAML, UI controllers, state/system change hooks.
- `robust-toolbox/versioning-compatibility.md`: version numbers and compatibility guarantees.
- `robust-toolbox/acz.md`: automatic client zip modes.
- `robust-toolbox/asset-packaging.md`: asset graphs.
- `robust-toolbox/build-configurations.md`: build configs for Rider, Visual Studio, VS Code.
- `robust-toolbox/content-manifests.md`: content manifest examples.
- `robust-toolbox/coordinate-systems.md`: world, entity local, view/projection, screen/UI coordinate systems.
- `robust-toolbox/ecs.md`: composition, data-only components, EntitySystems, events, system dependencies, ECS FAQ.
- `robust-toolbox/user-interface/containers.md`: BoxContainer, GridContainer, ScrollContainer, LayoutContainer.
- `robust-toolbox/transform/entity-coordinates.md`: entity coordinate gotchas.
- `robust-toolbox/transform/grids.md`: grid collision, splitting, debugging commands.
- `robust-toolbox/transform/physics.md`: physics pipeline, CCD, CVars, PhysicsComponent, fixtures, contacts, joints, debugging.
- `robust-toolbox/toolshed/blocks.md`: command blocks.
- `robust-toolbox/toolshed/commands.md`: command notation.
- `robust-toolbox/toolshed/development.md`: creating commands, parsers, piped input, permissions, localization, error reporting.
- `robust-toolbox/toolshed/environments.md`: toolshed environments and best practices.
- `robust-toolbox/toolshed/invocation-contexts.md`: invocation context best practices.
- `robust-toolbox/toolshed/toolshed-and-scsi.md`: Toolshed/SCSI call semantics.
- `robust-toolbox/toolshed/toolshed-examples.md`: usage examples.
- `robust-toolbox/toolshed/types.md`: command type system.
- `robust-toolbox/toolshed/variables.md`: toolshed variables.
- `robust-toolbox/toolshed/commands/emplace.md`: emplace commands.
- `robust-toolbox/toolshed/commands/entity-control.md`: entity-control commands.
- `robust-toolbox/toolshed/commands/general.md`: general commands.
- `robust-toolbox/toolshed/commands/misc.md`: misc commands.
- `robust-toolbox/rendering/lighting-and-fov.md`: lighting/FOV behavior.
- `robust-toolbox/rendering/shaders.md`: shader guidance.
- `robust-toolbox/rendering/sprites-and-icons.md`: sprites and icons.
- `robust-toolbox/netcode/connection-sequence.md`: connection sequence.
- `robust-toolbox/netcode/net-entities.md`: NetEntity concept.

## Space Station 14 Design And Gameplay

- `space-station-14/accessibility.md`: accessibility design.
- `space-station-14/admin-tools.md`: admin tools.
- `space-station-14/art.md`: art direction.
- `space-station-14/characters-species.md`: character species overview.
- `space-station-14/combat.md`: combat design.
- `space-station-14/core-design.md`: core design overview.
- `space-station-14/departments.md`: department overview.
- `space-station-14/mapping.md`: mapping overview.
- `space-station-14/player-interaction.md`: interaction overview.
- `space-station-14/roleplay-lore.md`: roleplay/lore overview.
- `space-station-14/round-flow.md`: round-flow overview.
- `space-station-14/user-interface.md`: SS14 UI overview.
- `space-station-14/core-design/design-principles.md`: chaos, seriously silly, dynamic environment, inter-connected simulation, player interaction, player agency.
- `space-station-14/character-species/guidelines.md`: species identity, balance, accessibility, admin burden, porting, ongoing changes.
- `space-station-14/art/displacement-maps.md`: displacement map format, shader, RSI params, Aseprite scripts.

## UI Proposals

- `space-station-14/user-interface/proposals/playtimereminders.md`: playtime reminder proposal.
- `space-station-14/user-interface/proposals/statpanels.md`: stat panel proposal.

## Round Flow And Antagonists

- `space-station-14/round-flow/antagonists.md`: antagonist overview.
- `space-station-14/round-flow/antagonists/exterminator.md`: exterminator concept, goals, components.
- `space-station-14/round-flow/antagonists/pursuer.md`: pursuer features, rationale, roundflow, technical considerations.
- `space-station-14/round-flow/antagonists/space-ninja.md`: ninja features, design pillars, interaction, admin impact.
- `space-station-14/round-flow/antagonists/thief.md`: thief goals and expected gameplay.
- `space-station-14/round-flow/antagonists/traitors.md`: traitor tools, objectives, solo-antag design.
- `space-station-14/round-flow/antagonists/Wizard.md`: wizard grimoire, spells, base, roundflow, technical considerations.
- `space-station-14/round-flow/antagonists/Xenoborgs.md`: xenoborgs, mothership, modules, resolution.
- `space-station-14/round-flow/proposals/changeling.md`: changeling abilities, minions, stealth, combat, required changes.
- `space-station-14/round-flow/proposals/cleanup-crew-gamemode.md`: cleanup crew, intruders, scoring, map saving.
- `space-station-14/round-flow/proposals/departmental-economy.md`: departmental funds, requisitions, research funding, transfers.
- `space-station-14/round-flow/proposals/game-director.md`: chaos/story/metrics/event director model.
- `space-station-14/round-flow/proposals/paradox-clone.md`: paradox clone ghost role/objectives.
- `space-station-14/round-flow/proposals/pizza-delivery-critter.md`: delivery critter role and traitor/nukeops interactions.
- `space-station-14/round-flow/proposals/revolutionaries-codeword-rework.md`: rev goals, win conditions, loyalty, codewords, items.
- `space-station-14/round-flow/proposals/rogue-drones.md`: rogue drone mechanics and lore.
- `space-station-14/round-flow/proposals/station-ecosystem.md`: ecology, critters, food, role interactions.
- `space-station-14/round-flow/proposals/tourists.md`: tourist camera gameplay and expansions.
- `space-station-14/round-flow/proposals/turf-war.md`: turf war goals and gameplay.

## Player Interaction

- `space-station-14/player-interaction/accent-guidelines.md`: accent definitions and rules.
- `space-station-14/player-interaction/cartridge-loaders.md`: cartridge insertion, installation, activation, event relay, background programs, UI fragments.
- `space-station-14/player-interaction/proposals/grid-inventory.md`: grid inventory, item/storage model, slots.
- `space-station-14/player-interaction/proposals/pda-messaging.md`: PDA messaging storage, active/inactive servers, users list, optional channels/admin console/pAI.

## Mapping And Departments

- `space-station-14/mapping/dungeons.md`: dungeon templates, presets, rooms, making content.
- `space-station-14/mapping/guidelines.md`: mapping sins, checklist, department-specific map review.
- `space-station-14/mapping/guides/general-guide.md`: mapping setup, workflow, commands, multigrid, screenshots, troubleshooting, atmos, power, decals, warp points, cameras, telecoms, docking.
- `space-station-14/departments/atmos.md`: atmos concept, design pillars, progression, simulation/devices/flows/reactions.
- `space-station-14/departments/cargo.md`: cargo concept, intended experience, responsibilities, desired/undesired gameplay.
- `space-station-14/departments/command.md`: command concept, player story, pillars, objectives, progression, flow.
- `space-station-14/departments/engineering.md`: engineering concept and mechanics template.
- `space-station-14/departments/medical.md`: wounds, damage, medicine, information-resource pillars.
- `space-station-14/departments/science.md`: science concept and mechanics template.
- `space-station-14/departments/security.md`: security concept, responsibilities, desired/undesired gameplay.
- `space-station-14/departments/service.md`: service concept and mechanics template.
- `space-station-14/departments/silicon.md`: silicon identity, laws, neutrality, specialization, gameplay, interactions.

## Core Tech

- `space-station-14/core-tech/body.md`: BodySystem, VisualBodyComponent, organs, missing areas.
- `space-station-14/core-tech/chemistry.md`: chemistry overview.
- `space-station-14/core-tech/chemistry/metabolism.md`: organs, metabolizers, species.
- `space-station-14/core-tech/chemistry/reactions.md`: reactions.
- `space-station-14/core-tech/chemistry/reagents.md`: reagent definitions, effects, conditions.
- `space-station-14/core-tech/chemistry/solution-containers.md`: solution capabilities, target solution specification.
- `space-station-14/core-tech/construction.md`: construction graph, nodes, edges, recipe prototypes, menu, ghosts, crafting.
- `space-station-14/core-tech/destructible.md`: destructible entities, triggers, behaviors.
- `space-station-14/core-tech/device-network.md`: device network components, payloads, constants, send/receive examples.
- `space-station-14/core-tech/entity-tables.md`: selectors, value selectors, custom selectors.
- `space-station-14/core-tech/node-networks.md`: node containers, nodes, node groups, factories.
- `space-station-14/core-tech/npcs.md`: blackboards, planning, tasks, primitives, updates, collision avoidance, pathfinding, commands.

## Specifications

- `specifications/robust-generic-attribution.md`: generic attribution YAML and design goals.
- `specifications/robust-station-image.md`: station image JSON states, loading params, design goals.

## SS14 By Example

- `ss14-by-example/adding-a-simple-bikehorn.md`: entity/component/system basics and client-server paradigm.
- `ss14-by-example/basic-networking-and-you.md`: component states, auto state generation, manual state, network events, PVS.
- `ss14-by-example/converting-oldbody-to-nubody.md`: species nubody conversion checklist.
- `ss14-by-example/fluent-and-localization.md`: Fluent basics, variables, selectors, functions, prototype localization.
- `ss14-by-example/introduction-to-ss14-by-example.md`: examples landing page.
- `ss14-by-example/making-a-sprite-dynamic.md`: appearance data, GenericVisualizer, sprite layers/states, animations.
- `ss14-by-example/making-a-sprite-dynamic/porting-appearance-visualizers.md`: separate data/logic, ECS-ify, update YAML, generalize.
- `ss14-by-example/prediction-guide.md`: prediction model, checklist, component networking, predicted popups/audio/spawn/delete/randomness/BUI/PVS.
- `ss14-by-example/ui-and-you.md`: FancyWindow, style classes, stylesheets, BUI intro.
- `ss14-by-example/ui-survival-guide.md`: UI learning path and common dangers.
- `ss14-by-example/ui-and-you/ui-cookbook.md`: status colors and multiple style classes.

## Templates

- `templates/department-design-template.md`: department design skeleton.
- `templates/legacy.md`: legacy marker template.
- `templates/outdated.md`: outdated marker template.
- `templates/porting.md`: porting marker template.
- `templates/proposal.md`: proposal template: overview, background, features, rationale, roundflow, admin impact, technical considerations.
- `templates/stub.md`: stub marker template.
- `templates/toolshed-command-head.md`: toolshed command header template.
- `templates/wip.md`: WIP marker template.

## General Proposals

- `general-proposals/robusthub.md`: RobustHub, games/hubs, launcher changes, game-specific mode.

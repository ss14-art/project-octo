---
name: ss14-debugging-workflow
description: Debugging workflow for SS14 Shine work, including ViewVariables, quickinspect, console commands, fake lag, logs, breakpoints, tests, run configurations, YAML linter, lobby testing, and performance debugging.
---

# SS14 Debugging Workflow

## First Tools

- Search logs for errors and warnings.
- Use ViewVariables for entity/component state.
- Use `quickinspect` where available to compare server/client components.
- Use breakpoints carefully in predicted code because client code may run many times.
- Use fake lag to expose prediction problems.

## Common Checks

- Does the component exist on server and client?
- Is the field networked and dirtied?
- Does the entity leave PVS?
- Is the client missing a prototype, sprite, FTL key, or state?
- Did the server reject a client action?
- Is a map/prototype load failure hiding the real error?

## Bundled References

- `references/debugging-mindset.md`: isolate whether the issue is code, data, resources, networking, or prediction.
- `references/logs-vv-breakpoints.md`: logs, ViewVariables, quickinspect, breakpoints, and predicted-code caveats.
- `references/console-and-runtime-tools.md`: console/dev-window/fake-lag/lobby/manual runtime checks.

## Validation

Pick the narrowest useful command:

- Build the touched project.
- Run YAML linter for resource changes.
- Run focused tests for system logic.
- Run integration tests for networking, prediction, prototypes, and DB behavior.

## Sources

See `ss14-wizden-docs` for `general-development/tips/debugging-tools.md` and troubleshooting docs.

---
name: ss14-testing
description: Test and validation guidance for Shine Project SS14 changes. Use when choosing build, YAML linter, unit, integration, database, prediction, or manual validation for code, prototypes, maps, resources, and review-bot changes.
---

# SS14 Testing

## Choose Focused Validation

- C# logic: build touched project and run focused tests.
- Prototypes/resources: run YAML/prototype validation.
- Networking/prediction: use integration tests or manual fake-lag two-client checks.
- Database: test SQLite and Postgres migration paths.
- UI: open the UI path in-game when possible and check localization and resizing.
- Agent configs: validate YAML/JSON and skill frontmatter.

## Test Design

- Test public EntitySystem APIs, not private implementation details.
- Keep fixtures minimal and prototype IDs namespaced.
- Add regression tests for bug fixes.
- Avoid nondeterministic timing/randomness.

## Manual Validation Notes

When tests are not practical, document:

- command(s) run;
- scenario tested;
- fake lag/client count if prediction is involved;
- residual risk.

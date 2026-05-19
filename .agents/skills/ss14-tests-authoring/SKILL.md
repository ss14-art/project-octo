---
name: ss14-tests-authoring
description: Test authoring guidance for Shine Project SS14 work. Use when adding or reviewing content tests, integration tests, YAML/prototype validation, migration tests, prediction/netcode tests, or choosing what verification a PR needs.
---

# SS14 Tests Authoring

Choose the smallest test that catches the regression.

## Workflow

1. Open `references/test-selection.md`.
2. Open `references/content-test-anchors.md`.
3. Open `references/integration-test-anchors.md`.

## Rules

- Test public system APIs.
- Use minimal prototypes/fixtures.
- Keep tests deterministic.
- Use integration tests for networking, prediction, full prototype load, and DB behavior.

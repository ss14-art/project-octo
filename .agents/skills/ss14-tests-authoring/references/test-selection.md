# Test Selection

Use:

- unit/content tests for system APIs and prototype validation;
- integration tests for networking, prediction, full startup, DB, and cross-assembly behavior;
- manual fake-lag testing for visible prediction behavior;
- YAML linter for resources.

Do not add broad slow tests for tiny local behavior.

---
name: ss14-standard-optimizations
description: Performance and allocation guidance for SS14-ART-CORE SS14 work. Use when touching Update loops, hot events, entity queries, networking Dirty calls, lambdas, allocations, collections, physics/atmos loops, or high-frequency UI/rendering code.
---

# SS14 Standard Optimizations

Optimize the obvious SS14 footguns before inventing cleverness.

## Workflow

1. Open `references/optimization-checklist.md`.
2. Open `references/entity-query-patterns.md`.
3. Open `references/event-hotpath-patterns.md`.

## Rules

- Prefer events over polling.
- Avoid per-tick dirtying and broad scans.
- Avoid capturing lambdas in hot paths.
- Use entity queries and local patterns for iteration.

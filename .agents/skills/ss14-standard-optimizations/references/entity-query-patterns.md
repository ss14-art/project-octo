# Entity Query Patterns

Prefer local entity-query patterns already used in the subsystem.

Guidelines:

- query only needed components;
- avoid repeated `TryComp` inside hot loops when a query can include the component;
- avoid broad global scans in response to local events;
- respect paused/PVS behavior.

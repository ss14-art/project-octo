---
name: ss14-atmos
description: Atmospherics guidance for SS14 SS14-ART-CORE work, including gas simulation, pipes, vents, scrubbers, air alarms, mapping atmos, flow/reaction design, performance, and why most atmos logic is authoritative/server-side rather than predicted.
---

# SS14 Atmos

## Placement

- Most atmos simulation is server-authoritative and belongs in `Content.Server/_Art`.
- Shared data/events may live in `Content.Shared/_Art` when UI, prediction-adjacent data, or prototypes need it.
- Client code is presentation only.

## Rules

- Do not predict atmos simulation unless a current local pattern proves it is safe.
- Avoid per-tick broad scans; use existing atmos update flows.
- Keep gas/device behavior configurable through components/prototypes.
- For mapping-related atmos, check map/grid/device assumptions.
- Use localized UI/examine text.

## Bundled References

- `references/atmos-authority.md`: why atmos usually stays server-authoritative and how to split shared data safely.
- `references/atmos-mapping-checks.md`: mapping and prototype checks for pipes, vents, scrubbers, air alarms, and gas assumptions.

## Sources

See `ss14-wizden-docs` for atmos department design, mapping atmos guidance, and transform/physics/grid docs.

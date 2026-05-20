# Atmos Authority

Atmos is normally server-authoritative.

Rules:

- Do not predict full atmos simulation.
- Keep client code presentation-only.
- Use shared types only for UI/state contracts that both sides need.
- Avoid broad per-tick scans outside existing atmos update patterns.

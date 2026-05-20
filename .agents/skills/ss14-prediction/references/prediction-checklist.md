# Prediction Checklist

- Is the action player-visible and latency-sensitive?
- Can the client know enough state to simulate it?
- Are components and systems in shared?
- Are dependencies predicted/shared?
- Are changed fields networked and dirtied?
- Are popups/audio/spawn/delete using predicted APIs?
- Is randomness deterministic or server-only?
- Was it tested with fake lag?

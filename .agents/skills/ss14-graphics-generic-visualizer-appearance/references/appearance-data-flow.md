# Appearance Data Flow

Typical flow:

1. System changes component state.
2. System calls `AppearanceSystem.SetData`.
3. Server replicates appearance data to clients.
4. GenericVisualizer or client visualizer updates sprite layers.

Keep gameplay state and visual state consistent. Do not update only visuals when gameplay state changed.

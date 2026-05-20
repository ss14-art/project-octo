# Component Checklist

- Is this component data-only?
- Does it need `[RegisterComponent]` and `partial`?
- Does it belong in Shared, Server, or Client?
- Does it need `[NetworkedComponent]`?
- Are fields configurable with `[DataField]`?
- Are mutation restrictions useful via `[Access]` or `[Friend]`?
- Are prototype IDs typed?
- Are runtime timers pause-safe?

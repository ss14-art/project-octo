# Dirty And Field Deltas

- Dirty after networked state changes.
- Use `DirtyField` for field-delta components.
- Guard unchanged values before dirtying.
- Do not dirty every tick if clients can infer state from timestamp/rate data.

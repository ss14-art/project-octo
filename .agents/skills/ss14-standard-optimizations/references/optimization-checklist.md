# Optimization Checklist

- Is this in `Update` or a high-frequency event?
- Can it be event-driven instead?
- Does it allocate per entity or per tick?
- Does it dirty/network too often?
- Does it capture lambdas?
- Does it query more components than needed?
- Can data be cached safely by ID instead of object?

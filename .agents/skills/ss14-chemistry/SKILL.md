---
name: ss14-chemistry
description: Chemistry guidance for SS14 SS14-ART-CORE work, including reagents, reactions, metabolism, solution containers, reagent effects/conditions, entity solutions, and chemistry prototype localization.
---

# SS14 Chemistry

## Rules

- Put new SS14-ART-CORE chemistry prototypes under `Resources/Prototypes/_Art`.
- Keep reagent/reaction/metabolism behavior data-driven.
- Use existing solution container APIs.
- Be careful with predicted code that resolves solution entities leaving PVS.
- Localize reagent names, examine text, UI, and feedback.
- Avoid hardcoding reagent IDs in systems when `ProtoId<ReagentPrototype>` or prototype data can be used.

## Bundled References

- `references/reagent-reaction-solution.md`: reagent, reaction, metabolism, and solution-container modeling checks.
- `references/chemistry-prediction-pvs.md`: prediction/PVS pitfalls for solution entities and chemistry feedback.

## Sources

See chemistry, metabolism, reactions, reagents, and solution containers docs through `ss14-wizden-docs`.

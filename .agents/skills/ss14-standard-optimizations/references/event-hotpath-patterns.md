# Event Hotpath Patterns

Hot event handlers should:

- return early;
- avoid allocation;
- avoid closure captures;
- avoid localization unless feedback is actually shown;
- avoid dirtying unchanged state;
- avoid sorted events unless order is required.

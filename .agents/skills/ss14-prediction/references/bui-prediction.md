# BUI Prediction

Predicted BUI paths should:

- use predicted messages for user input;
- read replicated component state where possible;
- avoid duplicating BUI state when component state already exists;
- keep server validation authoritative;
- update UI idempotently during prediction replay.

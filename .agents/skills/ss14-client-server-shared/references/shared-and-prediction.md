# Shared And Prediction

## Put Logic In Shared When

- player input should feel immediate;
- the client needs to simulate the same action;
- the data is replicated through component state;
- both sides need the event or payload type.

## Split Pattern

- Shared abstract system contains common API.
- Server subclass performs authority-only effects.
- Client subclass performs presentation-only effects.
- Empty client subclasses are valid when they make shared predicted logic instantiate client-side.

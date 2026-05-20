# Debugging Mindset

Start from the observed symptom and work backward through assembly boundaries.

Ask:

- Did the event run on server, client, or both?
- Did the component exist on both sides?
- Did replicated state dirty?
- Did PVS hide the entity?
- Did localization/prototype loading fail first?
- Did prediction replay the effect multiple times?

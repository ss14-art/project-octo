# Event Reading Guide

When reading an event flow:

1. Find where the event is raised.
2. Find all `SubscribeLocalEvent` or network subscriptions.
3. Check ordering and cancellation/handled behavior.
4. Identify which side runs the handler.
5. Check whether the event is predicted or server-only.

Directed events are entity-specific. Broadcast events are broader and should be used deliberately.

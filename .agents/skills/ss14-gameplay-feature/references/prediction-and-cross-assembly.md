# Prediction And Cross Assembly

Interactive player actions usually need shared predicted code.

## If Shared Cannot Depend On Something

- Move reusable API to shared if appropriate.
- Add virtual shared methods with server overrides for authority-only effects.
- Keep client presentation separate.

## If Prediction Is Impossible

Document why:

- server-only hidden data;
- atmos/power style simulation;
- no safe client-side state;
- security-sensitive randomness.

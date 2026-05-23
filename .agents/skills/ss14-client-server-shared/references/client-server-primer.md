# Client Server Primer

## Content.Shared

Shared holds data and logic both client and server need. Prediction normally requires shared systems and components.

## Content.Server

Server code is authoritative. It owns persistence, final validation, and server-only systems.

## Content.Client

Client code displays state and handles UI/visual presentation. It cannot be trusted for gameplay authority.

## SS14-ART-CORE Placement

Use `_Art` under each assembly for new SS14-ART-CORE code.

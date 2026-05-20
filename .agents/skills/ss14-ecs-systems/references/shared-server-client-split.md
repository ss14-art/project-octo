# Shared Server Client Split

## Shared

Common predicted logic, data, events, and public API.

## Server

Authority, persistence, final validation, admin/server services.

## Client

UI, visualizers, overlays, local presentation.

## Empty Client System

If shared predicted logic uses a shared abstract system, an empty client subclass may be required so the client instantiates it.

# Migration Validation

For DB changes:

- build database projects;
- run migration generation/checks using local workflow;
- test SQLite when used locally;
- test Postgres behavior for production-like paths;
- verify downgrade/backup risk if data could be lost.

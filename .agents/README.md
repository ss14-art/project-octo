# Shine Project Agent Layer

This directory is the canonical instruction layer for AI agents and review bots.

- `rules/`: mandatory policy and review guardrails.
- `skills/`: task/domain skills using Codex skill format.
- `plugins/marketplace.json`: repo-local Codex plugin marketplace entry.

Adapters outside this directory, such as `AGENTS.md`, `.cursor/rules`, `.github/copilot-instructions.md`, `CLAUDE.md`, `GEMINI.md`, `QWEN.md`, `MISTRAL.md`, and `.coderabbit.yaml`, must route back here.

For code changes, start with `.agents/skills/shine-project/SKILL.md`.

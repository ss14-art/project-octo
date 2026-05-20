"""Lightweight reminder hook for Shine guardrails.

This hook is intentionally advisory. It does not block tools because the exact
hook payload can vary between Codex runtimes.
"""

print("Shine guardrails: avoid RobustToolbox, prefer _sh, mark non-_sh edits.")

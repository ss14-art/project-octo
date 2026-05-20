"""Print the Shine instruction entry points for Codex sessions."""

from pathlib import Path

ROOT = Path(__file__).resolve().parents[2]

print("Shine Project: load .agents/skills/shine-project/SKILL.md first.")
print("Hard rules: no RobustToolbox edits, new code under _sh, marker non-_sh edits.")
print(f"Rules: {ROOT / '.agents' / 'rules'}")

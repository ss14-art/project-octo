$replacements = @(
    @{ Pattern = "Shine Project"; Replacement = "SS14-ART-CORE" },
    @{ Pattern = "Shine project"; Replacement = "SS14-ART-CORE" },
    @{ Pattern = "shine-project"; Replacement = "ss14-art-core" },
    @{ Pattern = "shine-edit"; Replacement = "ss14-art-edit" },
    @{ Pattern = "shine-hard-guardrails\.md"; Replacement = "ss14-art-hard-guardrails.md" },
    @{ Pattern = "shine-upstream-edit-markers\.md"; Replacement = "ss14-art-upstream-edit-markers.md" },
    @{ Pattern = "shine-review-bot-guidelines\.md"; Replacement = "ss14-art-review-bot-guidelines.md" },
    @{ Pattern = "shine-path-map\.md"; Replacement = "ss14-art-path-map.md" },
    @{ Pattern = "shine-gameplay-map\.md"; Replacement = "ss14-art-gameplay-map.md" },
    @{ Pattern = "ent-ShineExample"; Replacement = "ent-ArtCoreExample" },
    @{ Pattern = "ShineExample"; Replacement = "ArtCoreExample" },
    @{ Pattern = "shine-"; Replacement = "art-core-" },
    @{ Pattern = "Shine"; Replacement = "SS14-ART-CORE" },
    @{ Pattern = "_sh"; Replacement = "_Art" }
)

$files = Get-ChildItem -Path "D:\.avid\space-station-14\.agents" -Filter *.md -Recurse

foreach ($file in $files) {
    $content = Get-Content -Path $file.FullName -Raw
    $originalContent = $content
    
    foreach ($r in $replacements) {
        if ($r.Pattern -eq "Shine") {
             # Case-sensitive for singular Shine to avoid matching "shine-" which is handled separately
             $content = [regex]::Replace($content, "Shine", $r.Replacement)
             # Also handle lowercase "shine" if it's a standalone word (not prefix)
             $content = [regex]::Replace($content, "\bshine\b", "SS14-ART-CORE")
        } elseif ($r.Pattern -eq "_sh") {
             $content = [regex]::Replace($content, "_sh", $r.Replacement)
        } else {
             $content = [regex]::Replace($content, $r.Pattern, $r.Replacement, [System.Text.RegularExpressions.RegexOptions]::IgnoreCase)
        }
    }
    
    if ($content -ne $originalContent) {
        Set-Content -Path $file.FullName -Value $content -NoNewline
        Write-Output "Updated: $($file.FullName)"
    }
}

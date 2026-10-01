---
schema_version: 6
type: tests
file_count: 138
avg_lines_per_file: 63
move_to_legacy_percent: 45
generated_date: 2026-10-01
generated_time: 16:40:22
github_source_url: 
last_build_ok: 
last_build_date: 
last_tests_run_date: 
covered_lines: 
total_lines: 
---

## Description

Sbírka testovacích projektů k balíčkům `Sunamo*` z PlatformIndependentNuGetPackages (Cl, Clipboard, DevCode, FileIO, GoPay, Roslyn, Shared, Sqlite, SqlServer, String, TextBuilder, TextOutputGenerator, WinStd, LogMessage) a testovací data. Obsahuje také 47 ukázkových souborů `Roslyn.Tests` číslovaných po složkách (procvičování Roslynu) a skripty na reorganizaci balíčků do podsložek, které popisuje README.

## Původ zdrojáků

Staženo z GitHubu: **ne** — vlastní testy, remote je GitHub `sunamo/PlatformIndependentNuGetPackages.Tests` (vlastní účet), historie 131 commitů od 2020-05-18.

- Ověřeno: `git remote -v` (vlastní účet `sunamo`), `git log` (autoři účty uživatele, první commit `init` 2020-05-18, průběžná historie), zdrojáky s `Sunamo*` jmennými prostory a vlastními komentáři.
- Složky `Roslyn.Tests/2..16` připomínají číslované díly tutoriálu „Learn Roslyn Now“; `gh search repos "learn roslyn now"` našel kandidáta `racoltacalin/Roslyn-exampleToLearn` (2949 blobů), hash porovnání 0 shod; původ z tutoriálu proto není ověřen ani potvrzen.

## Doporučení přesunu do legacy

Doporučení přesunu do sunamocz-legacy.visualstudio.com: **45 %** — část je zastaralá, část jsou jen cvičné ukázky.

- Testy odkazují na názvy balíčků z doby před rozdělením monolitu (např. `SunamoDevCode.Tests`) a část projektů má jen minimální obsah (např. `UnitTest1.cs`).
- `Roslyn.Tests` jsou procvičovací ukázky bez produkčního užití.
- Poslední změna obsahu je z 2026-08-17 (úprava řešení), testy tedy nejsou zcela opuštěné, proto ne vyšší hodnota.

## Vazby na moje repa

- Submoduly: žádné
- ProjectReference / PackageReference: FluentAssertions

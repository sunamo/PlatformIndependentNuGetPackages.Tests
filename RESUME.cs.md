---
schema_version: 5
type: tests
file_count: 138
delete_recommendation_percent: 45
generated_date: 2026-09-30
generated_time: 16:47:07
github_origin: no
github_source_url: 
first_commit_date: 2020-05-18
last_commit_date: 2026-08-17
commit_count: 128
---

## Description

Sbírka testovacích projektů k balíčkům `Sunamo*` z PlatformIndependentNuGetPackages (Cl, Clipboard, DevCode, FileIO, GoPay, Roslyn, Shared, Sqlite, SqlServer, String, TextBuilder, TextOutputGenerator, WinStd, LogMessage) a testovací data. Obsahuje také 47 ukázkových souborů `Roslyn.Tests` číslovaných po složkách (procvičování Roslynu) a skripty na reorganizaci balíčků do podsložek, které popisuje README.

## Původ zdrojáků

Staženo z GitHubu: **ne** — vlastní testy, remote je GitHub `sunamo/PlatformIndependentNuGetPackages.Tests` (vlastní účet), historie 131 commitů od 2020-05-18.

- Ověřeno: `git remote -v` (vlastní účet `sunamo`), `git log` (autoři účty uživatele, první commit `init` 2020-05-18, průběžná historie), zdrojáky s `Sunamo*` jmennými prostory a vlastními komentáři.
- Složky `Roslyn.Tests/2..16` připomínají číslované díly tutoriálu „Learn Roslyn Now“; `gh search repos "learn roslyn now"` našel kandidáta `racoltacalin/Roslyn-exampleToLearn` (2949 blobů), hash porovnání 0 shod; původ z tutoriálu proto není ověřen ani potvrzen.

## Doporučení ke smazání

Doporučení ke smazání: **45 %** — část je zastaralá, část jsou jen cvičné ukázky.

- Testy odkazují na názvy balíčků z doby před rozdělením monolitu (např. `SunamoDevCode.Tests`) a část projektů má jen minimální obsah (např. `UnitTest1.cs`).
- `Roslyn.Tests` jsou procvičovací ukázky bez produkčního užití.
- Poslední změna obsahu je z 2026-08-17 (úprava řešení), testy tedy nejsou zcela opuštěné, proto ne vyšší hodnota.

## Historie commitů

- První commit: 2020-05-18
- Poslední commit: 2026-08-17
- Celkem commitů: 128

- Počítá se bez commitů, které jen generovaly RESUME.cs.md nebo README.md.

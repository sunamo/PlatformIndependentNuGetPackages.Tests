---
schema_version: 11
type: tests
category_override: none
file_count: 138
file_extensions: cs:123, csproj:23, png:21, old:7, noext:5, xaml:5, txt:4, appxmanifest:3, config:3, jsonanddelete:3, ps1:3, slnx:3, xml:3, bigram_freqs:2, bigrams:2, csx:2, json:2, md:2, numbers:2, punc:2, tif:2, training_text:2, unicharambigs:2, unigram_freqs:2, wordlist:2, yml:2, html:1, tests:1, vsixmanifest:1
file_extensions_updated: 2026-10-04
avg_lines_per_file: 63
total_lines: 4173
metrics_lm: 2026-10-01 16:40:22
move_to_legacy_percent: 45
description_updated: 2026-10-01
links_updated: 2026-10-01
github_source_url: not found
origin_status: found
origin_checked: 2026-10-01
article_source_url: not run
article_status: pending
article_checked: not run
last_build_ok: no
last_build_date: 2026-10-02
last_tests_run_date: not run
covered_lines: not run
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
- ProjectReference / PackageReference: `SunamoExceptions` (PackageReference), `SunamoPaths` (PackageReference), `SunamoShared` (PackageReference), `SunamoStringGetLines` (PackageReference), `SunamoTest` (PackageReference), `SunamoWinStd` (PackageReference), `SunamoCl` (ProjectReference, cíl chybí), `SunamoClipboard` (ProjectReference, cíl chybí), `SunamoDevCode` (ProjectReference, cíl chybí), `SunamoFileIO` (ProjectReference, cíl chybí), `SunamoRoslyn2_LaterMergeToSunamoRoslyn` (ProjectReference, cíl chybí), `SunamoShared` (ProjectReference, cíl chybí), `SunamoSqlite` (ProjectReference, cíl chybí), `SunamoSqlServer` (ProjectReference, cíl chybí), `SunamoString` (ProjectReference, cíl chybí), `SunamoTextBuilder` (ProjectReference, cíl chybí), `SunamoTextOutputGenerator` (ProjectReference, cíl chybí), `SunamoWinStd` (ProjectReference, cíl chybí)

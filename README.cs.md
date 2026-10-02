# Reorganization Scripts for NuGet Packages

## Short description

Sbírka testovacích projektů k balíčkům `Sunamo*` z PlatformIndependentNuGetPackages (Cl, Clipboard, DevCode, FileIO, GoPay, Roslyn, Shared, Sqlite, SqlServer, String, TextBuilder, TextOutputGenerator, WinStd, LogMessage) a testovací data. Obsahuje také 47 ukázkových souborů `Roslyn.Tests` číslovaných po složkách (procvičování Roslynu) a skripty na reorganizaci balíčků do podsložek, které popisuje README.

This directory contains scripts to reorganize NuGet packages into individual subdirectories.

## Files

- `create_backup.ps1` - Creates a backup before reorganization
- `reorganize_packages.ps1` - Main reorganization script
- `restore_from_backup.ps1` - Restores from backup if needed

## Usage

### 1. Create Backup (Recommended)

```powershell
.\create_backup.ps1
```

This will create a timestamped backup directory with all files that will be moved.

### 2. Run Reorganization

```powershell
.\reorganize_packages.ps1
```

This will:

- Create a subdirectory for each Sunamo package
- Move the following into each subdirectory:
  - `Sunamo*.sln` file
  - `Runner*` directory
  - `Sunamo*.Tests` directory
- Update all paths in .sln and .csproj files to maintain functionality

### 3. Restore from Backup (if needed)

```powershell
.\restore_from_backup.ps1 -BackupDir "E:\vs\Projects\_ut2\PlatformIndependentNuGetPackages.Tests_BACKUP_20250730_123456"
```

Replace the backup directory path with the actual backup created in step 1.

## What Changes

### Before:

```
PlatformIndependentNuGetPackages.Tests/
├── SunamoArgs.sln
├── RunnerArgs/
├── SunamoArgs.Tests/
├── SunamoAsync.sln
├── RunnerAsync/
├── SunamoAsync.Tests/
└── ...
```

### After:

```
PlatformIndependentNuGetPackages.Tests/
├── SunamoArgs/
│   ├── SunamoArgs.sln
│   ├── RunnerArgs/
│   └── SunamoArgs.Tests/
├── SunamoAsync/
│   ├── SunamoAsync.sln
│   ├── RunnerAsync/
│   └── SunamoAsync.Tests/
└── ...
```

## Path Updates

The scripts automatically update:

1. **In .sln files**: References to main packages in `E:\vs\Projects\PlatformIndependentNuGetPackages\`
2. **In Runner\*.csproj files**: Project references to maintain build functionality

All relative paths are adjusted to account for the new directory structure while preserving references to the main package location.

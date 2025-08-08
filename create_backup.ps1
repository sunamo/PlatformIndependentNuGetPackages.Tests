# PowerShell script to create backup before reorganization
param(
    [string]$BaseDir = "E:\vs\Projects\_ut2\PlatformIndependentNuGetPackages.Tests",
    [string]$BackupDir = "E:\vs\Projects\_ut2\PlatformIndependentNuGetPackages.Tests_BACKUP_$(Get-Date -Format 'yyyyMMdd_HHmmss')"
)

Write-Host "Creating backup before reorganization..." -ForegroundColor Green
Write-Host "Source: $BaseDir" -ForegroundColor White
Write-Host "Backup: $BackupDir" -ForegroundColor White

try {
    # Create backup directory
    New-Item -ItemType Directory -Path $BackupDir -Force | Out-Null
    
    # Copy all .sln files
    Write-Host "Backing up .sln files..." -ForegroundColor Yellow
    Get-ChildItem -Path $BaseDir -Name "Sunamo*.sln" | ForEach-Object {
        Copy-Item -Path (Join-Path $BaseDir $_) -Destination $BackupDir -Force
        Write-Host "  Copied: $_" -ForegroundColor Cyan
    }
    
    # Copy all Runner* directories
    Write-Host "Backing up Runner* directories..." -ForegroundColor Yellow
    Get-ChildItem -Path $BaseDir -Directory -Name "Runner*" | ForEach-Object {
        $source = Join-Path $BaseDir $_
        $destination = Join-Path $BackupDir $_
        Copy-Item -Path $source -Destination $destination -Recurse -Force
        Write-Host "  Copied: $_" -ForegroundColor Cyan
    }
    
    # Copy all *.Tests directories
    Write-Host "Backing up *.Tests directories..." -ForegroundColor Yellow
    Get-ChildItem -Path $BaseDir -Directory -Name "Sunamo*.Tests" | ForEach-Object {
        $source = Join-Path $BaseDir $_
        $destination = Join-Path $BackupDir $_
        Copy-Item -Path $source -Destination $destination -Recurse -Force
        Write-Host "  Copied: $_" -ForegroundColor Cyan
    }
    
    Write-Host "✓ Backup completed successfully!" -ForegroundColor Green
    Write-Host "Backup location: $BackupDir" -ForegroundColor White
    
} catch {
    Write-Host "✗ Backup failed: $($_.Exception.Message)" -ForegroundColor Red
    exit 1
}

Write-Host ""
Write-Host "You can now run the reorganization script safely." -ForegroundColor Yellow
Write-Host "If anything goes wrong, restore from: $BackupDir" -ForegroundColor Yellow

# PowerShell script to restore from backup
param(
    [Parameter(Mandatory=$true)]
    [string]$BackupDir,
    [string]$BaseDir = "E:\vs\Projects\_ut2\PlatformIndependentNuGetPackages.Tests"
)

if (-not (Test-Path $BackupDir)) {
    Write-Host "✗ Backup directory not found: $BackupDir" -ForegroundColor Red
    exit 1
}

Write-Host "Restoring from backup..." -ForegroundColor Green
Write-Host "Backup: $BackupDir" -ForegroundColor White
Write-Host "Target: $BaseDir" -ForegroundColor White

try {
    # Restore .sln files
    Write-Host "Restoring .sln files..." -ForegroundColor Yellow
    Get-ChildItem -Path $BackupDir -Name "Sunamo*.sln" | ForEach-Object {
        $source = Join-Path $BackupDir $_
        $destination = Join-Path $BaseDir $_
        Copy-Item -Path $source -Destination $destination -Force
        Write-Host "  Restored: $_" -ForegroundColor Cyan
    }
    
    # Restore Runner* directories
    Write-Host "Restoring Runner* directories..." -ForegroundColor Yellow
    Get-ChildItem -Path $BackupDir -Directory -Name "Runner*" | ForEach-Object {
        $source = Join-Path $BackupDir $_
        $destination = Join-Path $BaseDir $_
        
        # Remove existing directory if it exists
        if (Test-Path $destination) {
            Remove-Item -Path $destination -Recurse -Force
        }
        
        Copy-Item -Path $source -Destination $destination -Recurse -Force
        Write-Host "  Restored: $_" -ForegroundColor Cyan
    }
    
    # Restore *.Tests directories
    Write-Host "Restoring *.Tests directories..." -ForegroundColor Yellow
    Get-ChildItem -Path $BackupDir -Directory -Name "Sunamo*.Tests" | ForEach-Object {
        $source = Join-Path $BackupDir $_
        $destination = Join-Path $BaseDir $_
        
        # Remove existing directory if it exists
        if (Test-Path $destination) {
            Remove-Item -Path $destination -Recurse -Force
        }
        
        Copy-Item -Path $source -Destination $destination -Recurse -Force
        Write-Host "  Restored: $_" -ForegroundColor Cyan
    }
    
    Write-Host "✓ Restore completed successfully!" -ForegroundColor Green
    
} catch {
    Write-Host "✗ Restore failed: $($_.Exception.Message)" -ForegroundColor Red
    exit 1
}

Write-Host ""
Write-Host "All files have been restored from backup." -ForegroundColor Yellow

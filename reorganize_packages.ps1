# PowerShell script to reorganize NuGet packages into subdirectories
# Each package will have its own subdirectory containing Runner*, *.Tests, and *.sln files

param(
    [string]$BaseDir = "E:\vs\Projects\_ut2\PlatformIndependentNuGetPackages.Tests"
)

# Change to base directory
Set-Location $BaseDir

Write-Host "Starting reorganization of NuGet packages..." -ForegroundColor Green

# Get all .sln files that match the pattern Sunamo*.sln (excluding main solution)
$slnFiles = Get-ChildItem -Path $BaseDir -Name "Sunamo*.sln" | Where-Object { 
    $_ -ne "PlatformIndependentNuGetPackages.Tests.sln" 
}

foreach ($slnFile in $slnFiles) {
    # Extract package name from .sln file (remove .sln extension)
    $packageName = [System.IO.Path]::GetFileNameWithoutExtension($slnFile)
    
    Write-Host "Processing package: $packageName" -ForegroundColor Yellow
    
    # Define paths
    $packageDir = Join-Path $BaseDir $packageName
    $runnerDir = "Runner" + ($packageName -replace "^Sunamo", "")
    $testsDir = $packageName + ".Tests"
    
    # Check if all required items exist
    $slnExists = Test-Path (Join-Path $BaseDir $slnFile)
    $runnerExists = Test-Path (Join-Path $BaseDir $runnerDir)
    $testsExists = Test-Path (Join-Path $BaseDir $testsDir)
    
    if (-not $slnExists) {
        Write-Host "  Skipping: $slnFile not found" -ForegroundColor Red
        continue
    }
    
    if (-not $runnerExists) {
        Write-Host "  Skipping: $runnerDir not found" -ForegroundColor Red
        continue
    }
    
    if (-not $testsExists) {
        Write-Host "  Skipping: $testsDir not found" -ForegroundColor Red
        continue
    }
    
    # Create package directory if it doesn't exist
    if (-not (Test-Path $packageDir)) {
        New-Item -ItemType Directory -Path $packageDir -Force | Out-Null
        Write-Host "  Created directory: $packageName" -ForegroundColor Green
    }
    
    try {
        # Move files/directories to package directory
        Write-Host "  Moving $slnFile..." -ForegroundColor Cyan
        Move-Item -Path (Join-Path $BaseDir $slnFile) -Destination $packageDir -Force
        
        Write-Host "  Moving $runnerDir..." -ForegroundColor Cyan
        Move-Item -Path (Join-Path $BaseDir $runnerDir) -Destination $packageDir -Force
        
        Write-Host "  Moving $testsDir..." -ForegroundColor Cyan
        Move-Item -Path (Join-Path $BaseDir $testsDir) -Destination $packageDir -Force
        
        # Update .sln file paths
        $slnPath = Join-Path $packageDir $slnFile
        $slnContent = Get-Content $slnPath -Raw
        
        # Update path to main package (add one more level up)
        $oldMainPath = "`"..\..\PlatformIndependentNuGetPackages\$packageName\$packageName.csproj`""
        $newMainPath = "`"..\..\..\PlatformIndependentNuGetPackages\$packageName\$packageName.csproj`""
        $slnContent = $slnContent -replace [regex]::Escape($oldMainPath), $newMainPath
        
        # Update path to tests project (now in same directory)
        $oldTestsPath = "`"$testsDir\$testsDir.csproj`""
        $newTestsPath = "`"$testsDir\$testsDir.csproj`""
        # No change needed for tests path as it's in the same directory
        
        # Update path to runner project (now in same directory)
        $oldRunnerPath = "`"$runnerDir\$runnerDir.csproj`""
        $newRunnerPath = "`"$runnerDir\$runnerDir.csproj`""
        # No change needed for runner path as it's in the same directory
        
        Set-Content -Path $slnPath -Value $slnContent -NoNewline
        Write-Host "  Updated $slnFile paths" -ForegroundColor Green
        
        # Update Runner project references
        $runnerCsprojPath = Join-Path $packageDir "$runnerDir\$runnerDir.csproj"
        if (Test-Path $runnerCsprojPath) {
            $runnerContent = Get-Content $runnerCsprojPath -Raw
            
            # Update reference to main package (add one more level up)
            $oldMainRef = "`"..\..\..\PlatformIndependentNuGetPackages\$packageName\$packageName.csproj`""
            $newMainRef = "`"..\..\..\..\PlatformIndependentNuGetPackages\$packageName\$packageName.csproj`""
            $runnerContent = $runnerContent -replace [regex]::Escape($oldMainRef), $newMainRef
            
            # Update reference to tests project (now in parent directory)
            $oldTestsRef = "`"..\$testsDir\$testsDir.csproj`""
            $newTestsRef = "`"..\$testsDir\$testsDir.csproj`""
            # No change needed as it's still one level up
            
            Set-Content -Path $runnerCsprojPath -Value $runnerContent -NoNewline
            Write-Host "  Updated $runnerDir.csproj references" -ForegroundColor Green
        }
        
        Write-Host "  ✓ Successfully reorganized $packageName" -ForegroundColor Green
        
    } catch {
        Write-Host "  ✗ Error processing $packageName`: $($_.Exception.Message)" -ForegroundColor Red
    }
    
    Write-Host ""
}

Write-Host "Reorganization completed!" -ForegroundColor Green
Write-Host ""
Write-Host "Summary of changes:" -ForegroundColor Yellow
Write-Host "- Each package now has its own subdirectory" -ForegroundColor White
Write-Host "- .sln files have updated paths to reference main packages" -ForegroundColor White
Write-Host "- Runner*.csproj files have updated project references" -ForegroundColor White
Write-Host "- All paths to E:\vs\Projects\PlatformIndependentNuGetPackages\ are preserved" -ForegroundColor White

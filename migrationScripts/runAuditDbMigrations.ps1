Write-Host "Running migrations for EF.Examples.Audit" -foregroundcolor "yellow"
Update-Database -ProjectName TddBuddy.SpeedyLocalDb.EF.Examples.Audit -StartupProjectName TddBuddy.SpeedySqlLocalDb.Tests
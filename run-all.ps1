Get-ChildItem -Directory |
    Where-Object { $_.Name -match '^\d{2}-' } |
    Sort-Object Name |
    ForEach-Object {
        Write-Host "`n=== $($_.Name) ==="
        dotnet run --project $_.FullName
    }

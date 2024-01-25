# Prompt the user for the project name
$projectName = Read-Host "Enter the name of the new project"

# Determine the location of the script
$scriptPath = (Get-Item -Path $MyInvocation.MyCommand.Path).Directory.FullName

# Create a new console application
dotnet new console -n $projectName

# Create a new folder for the project at the desired location
$projectPath = Join-Path $scriptPath $projectName
New-Item -ItemType Directory -Path $projectPath -ErrorAction SilentlyContinue | Out-Null

# Output the current directory for debugging
Write-Host "Current Directory: $(Get-Location)"

# Change to the project directory
Set-Location $projectPath

# Output the current directory for debugging
Write-Host "Current Directory (After Set-Location): $(Get-Location)"

# Output the contents of the project directory for debugging
Write-Host "Contents of Project Directory: $(Get-ChildItem)"

# Replace the content of Program.cs
@"
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Program!");
    }
}
"@ | Set-Content -Path Program.cs -Force

# Output the contents of the project directory for debugging
Write-Host "Contents of Project Directory (After Set-Content): $(Get-ChildItem)"

# Run the project
dotnet run

# Output the contents of the project directory for debugging
Write-Host "Contents of Project Directory (After dotnet run): $(Get-ChildItem)"

# Return to the original location
Set-Location $scriptPath

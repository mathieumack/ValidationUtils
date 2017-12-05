write-host "**************************" -foreground "Cyan"
write-host "*   Packaging to nuget   *" -foreground "Cyan"
write-host "**************************" -foreground "Cyan"

$location  = $env:APPVEYOR_BUILD_FOLDER

$locationNuspec = $location + "\nuspec"
$locationNuspec
	
Set-Location -Path $locationNuspec

write-host "Update the nuget.exe file" -foreground "DarkGray"
.\NuGet update -self

$apiKey = $env:NuGetApiKey
	
write-host "Publish nuget packages" -foreground "Green"

$packagePath = "../ValidationUtils/ValidationUtils/bin/Release/ValidationUtils.$ProductVersion.nupkg"
write-host $packagePath -foreground "DarkGray"
.\NuGet push $packagePath -Source https://www.nuget.org/api/v2/package -ApiKey $apiKey
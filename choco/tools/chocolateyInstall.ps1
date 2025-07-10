$packageName = 'hosts.editor'
$installerType = 'msi'
$url = 'https://github.com/scottlerch/HostsFileEditor/releases/download/v1.3.0/HostsFileEditorSetup-1.3.0.msi'
$silentArgs = '/quiet'
$validExitCodes = @(0)

Install-ChocolateyPackage "$packageName" "$installerType" "$silentArgs" "$url" -validExitCodes $validExitCodes
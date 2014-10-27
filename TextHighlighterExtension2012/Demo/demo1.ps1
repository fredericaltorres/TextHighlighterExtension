<#
    Visual Studio TextHighlighter Extension
    PowerShell Support
#>

gci -

# Network information		
[System.NET.NetworkInformation.IPGlobalProperties]::GetIPGlobalProperties() | Format-Table -Property HostName
# Drive on the machine
Get-PSDrive -PSProvider 'FileSystem' | Select-Object -Property Root
Cls
$Drives = Get-PSDrive -PSProvider 'FileSystem' | Select-Object -Property Root
$Drives | ForEach-Object { $_.Root }

$ok = "ok"
foreach($i in (1,2,3,4)) {
	
}

function Toto() {
	return 1
}

#
# How to search in the registry
#

Get-ChildItem -LiteralPath "Microsoft.PowerShell.Core\Registry::\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft"
| 
	Where-Object { $_.Name -match "Microsoft SQL Server.*" } |
		Format-Table -Property Name

# How to search in the event viewer        
Get-EventLog -LogName 'Application' -Newest 100 | 
	Where-Object  { $_.Source -match "Visual Studio" } |
		Select-Object -Property Message |
			ForEach-Object { "[$($_.Message)]" }

# Read Registry
Get-ChildItem -LiteralPath 'Microsoft.PowerShell.Core\Registry::\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft' | 
	Where-Object { $_.Name -match "Microsoft SQL Server.*" } |
		Format-Table -Property Name



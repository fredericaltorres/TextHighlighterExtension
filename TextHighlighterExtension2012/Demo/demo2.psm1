############################################################################
## TextHighlighterExtension - PowerShell color coding for Visual Studio 2010 
############################################################################


function isToday ([datetime]$date) {
	return [datetime]::Now.Date  -eq  $date.Date
}

 # START
 # I WISH I HAVE HAIR
 # SO I COULD BE TO COOL FOR SCHOOL
 # THE THINGS THEY SAID ABOUT ME ARE VERY CRUEL
 # ONE DAY IT WILL COME BACK
 # END
 
Cls
"Loading file..."
$InputTextFile  = "Data.TXT"
$lines          = Get-Content $InputTextFile
"Processing..."
$i = 0;
while( $i -lt $lines.Count ) {

    if( $lines[$i] -match "ACCOUNT:" ) {
    
        $line          = $lines[$i]
                    
        $matches       = ([regex]"ACCOUNT: (?<AccountNumber>[a-zA-Z0-9]*)").matches($line)
        $AccountNumber = $matches | foreach { $_.Groups[1].Value }
        
        $matches       = ([regex]"NAME: (?<LASTNAME>[a-zA-Z]*),(?<FIRSTNAME>[a-zA-Z]*)").matches($line)                
        $LastName      = $matches | foreach { $_.Groups[1].Value }
        $FirtName      = $matches | foreach { $_.Groups[2].Value }
        
        $matches       = ([regex]"DOB: (?<DOB>\d{1,2}/\d{1,2}/\d{1,4})").matches($line)
        $DateOfBirth   = $matches | foreach { $_.Groups[1].Value }
        
        $matches       = ([regex]"SEX: (?<SEX>[MF].)").matches($line)
        $Sex           = $matches | foreach { $_.Groups[1].Value }
        
        "AccountNumber:$AccountNumber, DateOfBirth:$DateOfBirth, LastName:$LastName, FirstName:$FirtName, Sex:$Sex"        
    }
    $i++;
}
# How to search in the registry
Get-ChildItem -LiteralPath 'Microsoft.PowerShell.Core\Registry::\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft' | 
	Where-Object { $_.Name -match "Microsoft SQL Server.*" } |
		Format-Table -Property Name

# How to search in the event viewer        
Get-EventLog -LogName 'Application' -Newest 100 | 
	Where-Object { $_.Source -match "Visual Studio" } |
		Select-Object -Property Message |
			ForEach-Object { "[$($_.Message)]" }

# Read Registry
Get-ChildItem -LiteralPath 'Microsoft.PowerShell.Core\Registry::\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft' | 
	Where-Object { $_.Name -match "Microsoft SQL Server.*" } |
		Format-Table -Property Name

# Network information		
[System.NET.NetworkInformation.IPGlobalProperties]::GetIPGlobalProperties() | Format-Table -Property HostName

# Drive on the machine
Get-PSDrive -PSProvider 'FileSystem' | Select-Object -Property Root
Cls
$Drives = Get-PSDrive -PSProvider 'FileSystem' | Select-Object -Property Root
$Drives | ForEach-Object { $_.Root }


 # START
# I WISH I HAVE HAIR
# SO I COULD BE TO COOL FOR SCHOOL
# THE THINGS THEY SAID ABOUT ME ARE VERY CRUEL
# ONE DAY IT WILL COME BACK
# END

############################################################################
## TextHighlighterExtension - PowerShell color coding for Visual Studio 2010 
############################################################################

$A = "START END"

function isToday ([datetime]$date) {
	return [datetime]::Now.Date  -eq  $date.Date
}

Cls
"Loading file..."
$InputTextFile  = "Data.TXT"
$lines          = Get-Content $InputTextFile
"Processing..."
$i = 0;
while( $i -lt $lines.Count ) {

    if( $lines[$i] -match "ACCOUNT:" ) {
    
        $line          = $lines[$i]
                    
        $matches       = ([regex]"ACCOUNT: (?<AccountNumber>[a-zA-Z0-9]*)").matches($line)
        $AccountNumber = $matches | foreach { $_.Groups[1].Value }
        
        $matches       = ([regex]"NAME: (?<LASTNAME>[a-zA-Z]*),(?<FIRSTNAME>[a-zA-Z]*)").matches($line)                
        $LastName      = $matches | foreach { $_.Groups[1].Value }
        $FirtName      = $matches | foreach { $_.Groups[2].Value }
        
        $matches       = ([regex]"DOB: (?<DOB>\d{1,2}/\d{1,2}/\d{1,4})").matches($line)
        $DateOfBirth   = $matches | foreach { $_.Groups[1].Value }
        
        $matches       = ([regex]"SEX: (?<SEX>[MF].)").matches($line)
        $Sex           = $matches | foreach { $_.Groups[1].Value }
        
        "AccountNumber:$AccountNumber, DateOfBirth:$DateOfBirth, LastName:$LastName, FirstName:$FirtName, Sex:$Sex"        
    }
    $i++;
}
# How to search in the registry
Get-ChildItem -LiteralPath 'Microsoft.PowerShell.Core\Registry::\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft' | 
	Where-Object { $_.Name -match "Microsoft SQL Server.*" } |
		Format-Table -Property Name

# How to search in the event viewer        
Get-EventLog -LogName 'Application' -Newest 100 | 
	Where-Object { $_.Source -match "Visual Studio" } |
		Select-Object -Property Message |
			ForEach-Object { "[$($_.Message)]" }

# Read Registry
Get-ChildItem -LiteralPath 'Microsoft.PowerShell.Core\Registry::\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft' | 
	Where-Object { $_.Name -match "Microsoft SQL Server.*" } |
		Format-Table -Property Name

# Network information		
[System.NET.NetworkInformation.IPGlobalProperties]::GetIPGlobalProperties() | Format-Table -Property HostName

# Drive on the machine
Get-PSDrive -PSProvider 'FileSystem' | Select-Object -Property Root
Cls
$Drives = Get-PSDrive -PSProvider 'FileSystem' | Select-Object -Property Root
$Drives | ForEach-Object { $_.Root }
 

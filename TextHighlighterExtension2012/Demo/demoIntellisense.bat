rem ******************************************************************************
rem * TextSyntaxHighlightingExtension                                            *  
rem * Bat and txt syntax highlighting for Visual Studio 2010 (.txt, .log, .bat)  *
rem ******************************************************************************
:: path=c:\
set FOLDER_SOURCE=c:\foo
set FOLDER_DEST=c:\foo
set FILE=bar.txt

:COPY_FILE
	copy "%FOLDER_SOURCE%\%FILE%" "%FOLDER_DEST%\%FILE%" & goto END_OF_SCRIPT

:FILE_ALREADY_EXIST
	echo "File already exist"

:END_OF_SCRIPT

echo "ok les filles: %FOLDER_SOURCE%"


goto COPY_FILE

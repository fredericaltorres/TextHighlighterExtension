rem ******************************************************************************
rem * TextSyntaxHighlightingExtension                                            *  
rem * Bat and txt syntax highlighting for Visual Studio 2010 (.txt, .log, .bat)  *
rem ******************************************************************************
echo This is a demo
pushd .
set FILE=c:\temp\log.txt
set USERNAME=Fred

if "%1"==""			goto SHOW_COMMAND_LINE
if "%1"=="all"		goto GOTO_ALL
if "%1"=="Nothing"	goto GOTO_NOTHING
goto END
echo "%"
:GOTO_NOTHING
	dir /b /s *.* > %FILE%
goto END

:GOTO_ALL
	Dir /b /s *.* > %FILE%
goto END

:SHOW_COMMAND_LINE
	Echo demo.bat all
goto END

:END
popd

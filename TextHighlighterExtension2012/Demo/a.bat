@echo off
rem ==============================================
rem This is a demo of the Visual Studio Extension
rem TextHighlighterExtension
rem ==============================================
set OUTPUT_FILE=c:\foo\bar.txt

if "%1"=="" goto SHOW_COMMAND_LINE

dir /b/s "%1" > %OUTPUT_FILE%
goto END

SHOW_COMMAND_LINE
echo a.bat directory

:END

goto END


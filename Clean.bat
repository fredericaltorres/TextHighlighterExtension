@echo off
cls
echo.
echo -- Clean binary of extension --
pause
echo Cleaning...

set ROOT=D:\DVT\TextHighlighterExtension
rd /s/q "%ROOT%\TextHighlighterExtension2012\bin\Debug2013"
rd /s/q "%ROOT%\CTxt\bin"
rd /s/q "%ROOT%\CTxt\obj"
rd /s/q "%ROOT%\CTxt\CTxtUnitTests2012\bin"
rd /s/q "%ROOT%\CTxt\CTxtUnitTests2012\obj"
rd /s/q "%ROOT%\JSON.SyntaxValidator\bin"
rd /s/q "%ROOT%\JSON.SyntaxValidator\obj"
rd /s/q "%ROOT%\JSON.SyntaxValidator\JSON.SyntaxValidatorUnitTests\bin"
rd /s/q "%ROOT%\JSON.SyntaxValidator\JSON.SyntaxValidatorUnitTests\obj"
rd /s/q "%ROOT%\TextHighlighterColorDefinition\bin"
rd /s/q "%ROOT%\TextHighlighterColorDefinition\obj"
rd /s/q "%ROOT%\TextHighlighterColorDefinitionUnitTests\bin"
rd /s/q "%ROOT%\TextHighlighterColorDefinitionUnitTests\obj"
rd /s/q "%ROOT%\TextHighlighterExtension2012\bin"
rd /s/q "%ROOT%\TextHighlighterExtension2012\obj"
rd /s/q "%ROOT%\Utils\bin"
rd /s/q "%ROOT%\Utils\obj"

echo -- Done --
pause
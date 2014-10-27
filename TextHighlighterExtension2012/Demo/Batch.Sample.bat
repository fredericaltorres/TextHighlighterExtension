rem ------------------------------------------------
rem Install Script
rem ------------------------------------------------
set BUILD_FOLDER=C:\Build
set SOURCE_FOLDER=\\S468\Build\2013_1_1

@rem Copy the build locally
if not exist "%BUILD_FOLDER%" md "%BUILD_FOLDER%" 
cd "%BUILD_FOLDER%" 
echo Copying Build
xcopy /s/e "%SOURCE_FOLDER%\*.*" "%BUILD_FOLDER%" > null

::
:: Stop Service
::
sc.exe query SuperServiceV1
If ERRORLEVEL 1060 net stop SuperServiceV2 & goto ServiceStopped
net stop SuperServiceV1
goto ServiceStopped
:ServiceStopped

msiexec.exe /i product.msi /qb /restart 

:: Display installation info
for /f "tokens=1,3 delims=," %%G IN (install.txt) do @echo %%G %%H


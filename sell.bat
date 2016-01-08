@ECHO OFF

REM ######################################################
REM #             THIS FILE IS PART OF ROSY              #
REM #             An OSIRiS Project component            #
REM #                  COPYRIGHT NOTICE                  #
REM #         Copyright Adam Heathcote 2014 - 2016.      #
REM #OSIRiS and associated documentation are distributed #
REM #       under the GNU General Public License.        #
REM ######################################################

cls
REM #########################################################################
REM                            ROSY Sell Script
REM                             Adam Heathcote
REM This script CANNOT be run manually! It expects arguments, either fed from
REM                      the command line or from ROSY.
REM           Running it manually will likely result in a broken system.
REM 			    		          YOU HAVE BEEN WARNED.
REM #########################################################################

:: Check if this script is being run from ROSY master control program
:: or manually. If it's being run manually (incorrectly) then quit.
IF %1.==. (GOTO MANUALRUN) ELSE (GOTO BEGIN)
:BEGIN

echo Finding Architecure
reg Query "HKLM\Hardware\Description\System\CentralProcessor\0" | find /i "x86" > NUL && set OSARC=32BIT || set OSARC=64BIT
echo %OSARC%

REM #######################################################
REM #Delete Customer Account.
REM #Delete Officeworks Account.
REM #Delete any other accounts with any name.
REM #Create a new account for buyer based upon argument %1.
REM #Make it an Admin with no password.
REM #######################################################

echo Deleting Accounts

:: Switch guest off.
net user guest /active:no > NUL 2>&1

:: Dump all user account names to a text file.
wmic useraccount get name > userlist.txt

:: Remove various junk lines from the text file.
type userlist.txt | findstr /v Name | findstr /v Administrator | findstr /v Guest | findstr /v HomeGroup > userlisttrimmed.txt

:: Loop through the text file and delete each user account listed.
FOR /F "tokens=* delims=" %%G in (userlisttrimmed.txt) DO net user /delete %%G > NUL 2>&1

echo Creating New Account

:: Create a new account based on the user input variable %1.
net user "%~1" "" /add > NUL 2>&1

:: Add the user to the Administrators group.
net localgroup "Administrators" "%~1" /add > NUL 2>&1

:: Switch off 'User's password expiry.
wmic useraccount where "name='%~1'" set PasswordExpires=FALSE > NUL 2>&1

:: Reset the auto login reg entries and re-enable the login animation.
:: Re-enable Windows Update.
echo Call out to PowerShell to set registry values.
SET "ThisScriptsDirectory=%~dp0"
SET "PowerShellScriptPath=%ThisScriptsDirectory%powershellregclean.ps1"
:: This Powershell path may seem odd because it is calling the 64bit version of powershell.exe instead of the default 32bit version.
:: If this is not done and powershell.exe is called by simply invoking 'powershell', then it will load the 32bit registry and the
:: paths we need to edit won't exist.
if %OSARC%==64BIT C:\windows\sysnative\windowspowershell\v1.0\powershell.exe -NonInteractive -executionpolicy Bypass -file "%PowerShellScriptPath%"  > NUL 2>&1
if %OSARC%==32BIT powershell.exe -NonInteractive -executionpolicy Bypass -file "%PowerShellScriptPath%"  > NUL 2>&1

DEL userlist.txt > NUL 2>&1
DEL userlisttrimmed.txt > NUL 2>&1

REM ####################################################
REM #Copy the post-reboot cleanup script to C:\profiles
REM #and create a scheduled task to run it on
REM #first boot of the new user.
REM #Delete the "Airplane Mode" boot check and
REM #the Auto-Shutdown routine.
REM #Remove the AutoWake and AutoSleep tasks if the
REM #machine is using them.
REM ####################################################

echo Copying Cleanup Files

:: Copy over a script to facilitate cleanup operations, post reboot.
:: Schedule a task to run on first boot that launches the cleanup script.
copy "%~dp0\cleanup.bat" C:\profiles\cleanup.bat > NUL 2>&1
copy "%~dp0\Remove-UserProfile.ps1" C:\profiles\Remove-UserProfile.ps1 > NUL 2>&1
schtasks /create /F /tn "Cleanup" /tr C:\profiles\cleanup.bat /sc onlogon /RL HIGHEST /RU "%~1" > NUL 2>&1

echo Deleting Scheduled Tasks
:: Delete all of the existing scheduled tasks.
schtasks /delete /F /tn "Computer Shutdown" > NUL 2>&1
schtasks /delete /F /tn "AutoSleep" > NUL 2>&1
schtasks /delete /F /tn "AutoWake" > NUL 2>&1
schtasks /delete /F /tn "Wi-Fi Check" > NUL 2>&1
schtasks /delete /F /tn "Set Wallpaper" > NUL 2>&1
schtasks /delete /F /tn "Start ODIN" > NUL 2>&1

REM ###############################################
REM #Set the balanced power plan as the active plan
REM #and delete the Officeworks plan.
REM ###############################################

echo Restoring Sane Power Settings

POWERCFG -restoredefaultschemes > NUL 2>&1
powercfg -hibernate on 2>&1


REM ###################################################
REM #Disconnect the Wireless Radio and disassociate
REM #the Officeworks profile with it.
REM #Delete the Extensible Markup Language file
REM #containing configuration data for the Officeworks
REM #WLAN.
REM ###################################################

echo Kill The Wireless Radio

Netsh wlan disconnect > NUL 2>&1

Netsh wlan delete profile name="OFW-Display" > NUL 2>&1


REM ###########################################
REM #Reset the Wireless Radio to force a
REM #disconnect of the network if required.
REM ###########################################

:: Force reset of the Wi-Fi card to make sure that it disconnects after removing
:: the OFW-Display profile.
powershell "get-netadapter wi-fi | restart-netadapter" > NUL 2>&1

echo Deleting the Shutdown Suppressor
DEL C:\Users\Public\Desktop\"Suspend Auto-Shutdown.lnk" > NUL 2>&1
DEL C:\profiles\"Suspend Auto-Shutdown.bat" > NUL 2>&1

exit

:MANUALRUN
echo This script CANNOT be run manually. Please start ROSY.exe instead.
pause>nul
explorer %~dp0
exit

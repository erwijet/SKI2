'MADE WITH SKI SCRIPTING 2.0 github.com/erwijet/ski2
Set WshShell = WScript.CreateObject("WScript.Shell")
WshShell.Run "notepad.exe"
WScript.Sleep 1000
WshShell.SendKeys "Hello World!"
WshShell.SendKeys "{ENTER}"
WshShell.SendKeys "This is a second line"
WshShell.SendKeys "{ENTER}"
WshShell.SendKeys "launching cmd in t-"
WScript.Sleep 1000
WshShell.SendKeys "10"
WshShell.SendKeys "{BACKSPACE}"
WshShell.SendKeys "{BACKSPACE}"
WshShell.SendKeys "9"
WScript.Sleep 1000
WshShell.SendKeys "{BACKSPACE}"
WshShell.SendKeys "8"
WScript.Sleep 1000
WshShell.SendKeys "{BACKSPACE}"
WshShell.SendKeys "7"
WScript.Sleep 1000
WshShell.SendKeys "{BACKSPACE}"
WshShell.SendKeys "6"
WScript.Sleep 1000
WshShell.SendKeys "{BACKSPACE}"
WshShell.SendKeys "5"
WScript.Sleep 1000
WshShell.SendKeys "{BACKSPACE}"
WshShell.SendKeys "4"
WScript.Sleep 1000
WshShell.SendKeys "{BACKSPACE}"
WshShell.SendKeys "3"
WScript.Sleep 1000
WshShell.SendKeys "{BACKSPACE}"
WshShell.SendKeys "2"
WScript.Sleep 1000
WshShell.SendKeys "{BACKSPACE}"
WshShell.SendKeys "1"
WScript.Sleep 1000
WshShell.SendKeys "{BACKSPACE}"
WshShell.SendKeys "le'go"
WshShell.Run "cmd.exe"

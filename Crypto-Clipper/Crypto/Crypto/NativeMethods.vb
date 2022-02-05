Imports System
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Crypto.Crypto
	' Token: 0x0200000D RID: 13
	Friend Module NativeMethods
		' Token: 0x0600002E RID: 46
		Public Declare Function AddClipboardFormatListener Lib "user32.dll" (hwnd As IntPtr) As Boolean

		' Token: 0x0600002F RID: 47
		Public Declare Function SetParent Lib "user32.dll" (hWndChild As IntPtr, hWndNewParent As IntPtr) As IntPtr

		' Token: 0x04000018 RID: 24
		Public Const WM_CLIPBOARDUPDATE As Integer = 797

		' Token: 0x04000019 RID: 25
		Public HWND_MESSAGE As IntPtr = New IntPtr(-3)
	End Module
End Namespace

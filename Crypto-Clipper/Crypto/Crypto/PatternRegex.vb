Imports System
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.CompilerServices

Namespace Crypto.Crypto
	' Token: 0x0200000C RID: 12
	Public Module PatternRegex
		' Token: 0x04000015 RID: 21
		Public btc As Regex = New Regex("\b(bc1|[13])[a-zA-HJ-NP-Z0-9]{26,35}\b")

		' Token: 0x04000016 RID: 22
		Public ethereum As Regex = New Regex("\b0x[a-fA-F0-9]{40}\b")

		' Token: 0x04000017 RID: 23
		Public xmr As Regex = New Regex("\b4([0-9]|[A-B])(.){93}\b")
	End Module
End Namespace

Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Crypto.My.Resources
	' Token: 0x02000013 RID: 19
	<DebuggerNonUserCode()>
	<HideModuleName()>
	<CompilerGenerated()>
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")>
	Friend NotInheritable Module Resources
		' Token: 0x1700000A RID: 10
		' (get) Token: 0x0600003E RID: 62 RVA: 0x00002F78 File Offset: 0x00001178
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager As ResourceManager
			Get
				Dim flag As Boolean = Object.ReferenceEquals(Resources.resourceMan, Nothing)
				If flag Then
					Dim resourceManager As ResourceManager = New ResourceManager("Crypto.Resources", GetType(Resources).Assembly)
					Resources.resourceMan = resourceManager
				End If
				Return Resources.resourceMan
			End Get
		End Property

		' Token: 0x1700000B RID: 11
		' (get) Token: 0x0600003F RID: 63 RVA: 0x00002FC0 File Offset: 0x000011C0
		' (set) Token: 0x06000040 RID: 64 RVA: 0x00002FD8 File Offset: 0x000011D8
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Property Culture As CultureInfo
			Get
				Return Resources.resourceCulture
			End Get
			Set(value As CultureInfo)
				Resources.resourceCulture = value
			End Set
		End Property

		' Token: 0x0400001E RID: 30
		Private resourceMan As ResourceManager

		' Token: 0x0400001F RID: 31
		Private resourceCulture As CultureInfo
	End Module
End Namespace

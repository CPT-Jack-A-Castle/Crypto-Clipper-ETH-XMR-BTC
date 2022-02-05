Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Configuration
Imports System.Diagnostics
Imports System.Runtime.CompilerServices

Namespace Crypto.My
	' Token: 0x02000014 RID: 20
	<CompilerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Advanced)>
	<GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")>
	Friend NotInheritable Partial Class MySettings
		Inherits ApplicationSettingsBase

		' Token: 0x1700000C RID: 12
		' (get) Token: 0x06000043 RID: 67 RVA: 0x00003008 File Offset: 0x00001208
		Public Shared ReadOnly Property [Default] As MySettings
			Get
				Return MySettings.defaultInstance
			End Get
		End Property

		' Token: 0x04000020 RID: 32
		Private Shared defaultInstance As MySettings = CType(SettingsBase.Synchronized(New MySettings()), MySettings)
	End Class
End Namespace

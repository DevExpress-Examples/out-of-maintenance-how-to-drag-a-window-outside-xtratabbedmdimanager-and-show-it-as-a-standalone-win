Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace Q205699
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New MainForm())
		End Sub
	End Module
End Namespace
Imports Microsoft.VisualBasic
Imports System
Namespace CustomReportClass.Win
	Partial Public Class CustomReportClassWindowsFormsApplication
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
			Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
			Me.module4 = New CustomReportClass.Module.Win.CustomReportClassWindowsFormsModule()
			Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
			Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule()
			Me.reportsWindowsFormsModule1 = New DevExpress.ExpressApp.Reports.Win.ReportsWindowsFormsModule()
			Me.reportsModule1 = New DevExpress.ExpressApp.Reports.ReportsModule()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' reportsModule1
			' 
			Me.reportsModule1.EnableInplaceReports = True
			Me.reportsModule1.ReportDataType = GetType(CustomReportClass.Module.CustomReportData)
			' 
			' CustomReportClassWindowsFormsApplication
			' 
			Me.ApplicationName = "CustomReportClass"
			Me.Modules.Add(Me.module1)
			Me.Modules.Add(Me.module2)
			Me.Modules.Add(Me.module6)
			Me.Modules.Add(Me.module4)
			Me.Modules.Add(Me.securityModule1)
			Me.Modules.Add(Me.reportsModule1)
			Me.Modules.Add(Me.reportsWindowsFormsModule1)
'			Me.DatabaseVersionMismatch += New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(Me.CustomReportClassWindowsFormsApplication_DatabaseVersionMismatch);
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
		Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
		Private module4 As CustomReportClass.Module.Win.CustomReportClassWindowsFormsModule
		Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
		Private securityModule1 As DevExpress.ExpressApp.Security.SecurityModule
		Private reportsWindowsFormsModule1 As DevExpress.ExpressApp.Reports.Win.ReportsWindowsFormsModule
		Private reportsModule1 As DevExpress.ExpressApp.Reports.ReportsModule
	End Class
End Namespace
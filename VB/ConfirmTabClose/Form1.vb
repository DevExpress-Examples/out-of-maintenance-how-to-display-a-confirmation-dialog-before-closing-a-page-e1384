Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo

Namespace ConfirmTabClose
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xtraTabControl1_CloseButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles xtraTabControl1.CloseButtonClick
			Dim tabControl As XtraTabControl = CType(sender, XtraTabControl)
			Dim arg As ClosePageButtonEventArgs = CType(e, ClosePageButtonEventArgs)
			If MessageBox.Show(String.Format("Close {0}?", arg.Page.Text), "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
				CType(arg.Page, XtraTabPage).PageVisible = False
			End If
		End Sub
	End Class
End Namespace

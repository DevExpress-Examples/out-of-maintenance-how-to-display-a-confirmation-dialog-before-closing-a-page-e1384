Imports Microsoft.VisualBasic
Imports System
Namespace ConfirmTabClose
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InTabControlHeader
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.HeaderButtons = (CType((DevExpress.XtraTab.TabButtons.Close Or DevExpress.XtraTab.TabButtons.Default), DevExpress.XtraTab.TabButtons))
			Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(540, 362)
			Me.xtraTabControl1.TabIndex = 0
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
'			Me.xtraTabControl1.CloseButtonClick += New System.EventHandler(Me.xtraTabControl1_CloseButtonClick);
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(291, 269)
			Me.xtraTabPage1.Text = "xtraTabPage1"
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(531, 331)
			Me.xtraTabPage2.Text = "xtraTabPage2"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(540, 362)
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
	End Class
End Namespace


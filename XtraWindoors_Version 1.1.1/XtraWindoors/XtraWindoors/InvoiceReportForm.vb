﻿
'Program Name:  XtraWindoors Rental System
'Programmer:    Group 7 
'Date:          12/10/2015 
'Class:         Invoice Report Form

Public Class InvoiceReportForm

    Private Sub InvoiceReportForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'XtraWindoorsDataSet.InvoiceReport' table. You can move, or remove it, as needed.
        '  Me.InvoiceReportTableAdapter.Fill(Me.XtraWindoorsDataSet.InvoiceReport)

        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub HomeButton_Click(sender As System.Object, e As System.EventArgs) Handles HomeButton.Click
        Me.Hide()
        HomePageScreen.Show()
    End Sub

    Private Sub BookingForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        HomePageScreen.Show()
    End Sub
End Class
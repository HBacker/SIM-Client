Imports FirebirdSql.Data.FirebirdClient
Imports System.Text
Imports System.Net

Public Class Form1
 Dim version As String = "0.0.1"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
  vText.text = "sürüm=" & version
    End Sub

    Private Sub mainSection_Click(sender As Object, e As EventArgs) Handles mainSection.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnSET.Click
        modX("db")
    End Sub
    Function modX(current As string)
        If current = "db" Then
            ListData1.Visible = False
                        DbSettings1.Visible = True
            ElseIf current = "json" then
            ListData1.Visible = True
            DbSettings1.Visible = False
            ElseIf current = "send" then
            MsgBox("Henüz Eklenmedi!")
        End If
        End Function

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles btnJSON.Click
        modX("json")
    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles btnSEND.Click
        modX("send")
    End Sub
End Class

Imports System.IO
Imports FirebirdSql.Data.FirebirdClient

Public Class dbSettings
    Private Sub GunaLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel1.LinkClicked
Try
Dim ofd As OpenFileDialog = New OpenFileDialog
        ofd.DefaultExt = "fdb"
            ofd.FileName = "Firebird Veritabanı Dosyası"
ofd.InitialDirectory = "c:\"
ofd.Filter ="DB Files|*.FDB"
ofd.Title = "Select file"
If ofd.ShowDialog() <> DialogResult.Cancel Then
dbPath.Text = ofd.FileName
End If
        Catch ex As Exception
            dbPath.Text = "Hata! Lütfen yolu manuel girin."
        End Try   
     

    End Sub
    Function TryConnect
        Dim strFB As FbConnectionStringBuilder
         Dim conFB As FbConnection
        strFB = New FbConnectionStringBuilder
        strFB.Database = dbPath.Text
        strFB.ServerType = FbServerType.Default
        strFB.UserID = dbUID.Text
        strFB.Password = dbPwd.Text
       
        Try
             conFB = New FbConnection(strFB.ToString)
            conFB.Open
            output.Text = "Bağlantı Başarılı!" & vbNewLine & "Ayarlar Kaydedildi."
            My.Settings.dbUser = dbUID.Text
             My.Settings.dbPass = dbPwd.Text
             My.Settings.dbPath = dbPath.Text
            My.Settings.Save
            Form1.btnJSON.Enabled = True
            Form1.btnSEND.Enabled = True
        Catch ex As Exception
            output.Text = "Bağlantı Başarısız! " & vbNewLine & ex.Message
            My.Settings.dbUser =""
             My.Settings.dbPass = ""
             My.Settings.dbPath = ""
            Form1.btnJSON.Enabled = False
            Form1.btnSEND.Enabled = False
        End Try
        End Function

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles dbTest.Click
        TryConnect
    End Sub
End Class

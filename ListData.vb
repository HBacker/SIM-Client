Imports FirebirdSql.Data.FirebirdClient
Imports System.Xml
Imports System.Web.Script.Serialization
Imports MS.Internal.Xml

Public Class ListData

    Private Sub ListData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboTable.SelectedItem = "Seçiniz..."
       
    End Sub

    Private Sub comboTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboTable.SelectedIndexChanged
        GetData
        newFile.Text = comboTable.SelectedItem.ToString & " (" & DateAndTime.Now.ToString("yyyyMMddHHmm") & ")"
    End Sub
     Function GetData
        Dim strFB As FbConnectionStringBuilder
         Dim conFB As FbConnection
        strFB = New FbConnectionStringBuilder
        strFB.Database = My.Settings.dbPath
        strFB.ServerType = FbServerType.Default
        strFB.UserID =  My.Settings.dbUser
        strFB.Password =  My.Settings.dbPass
        conFB = New FbConnection(strFB.ToString)
        Dim veriTablo As New DataTable
        If comboTable.SelectedItem.ToString = "Seçiniz..." Then
            status("TABLO_SEC")
           TabloGrid.DataSource = Nothing
            Else
              Try
            Dim veriAdapter As New FbDataAdapter("SELECT * FROM " & comboTable.SelectedItem.ToString, conFB)
        veriAdapter.Fill(veriTablo)
    TabloGrid.DataSource = veriTablo
        DonusturJSON(veriTablo)
         
        conFB.Dispose
        veriAdapter.Dispose
                DonusturJSON(veriTablo)
          
        Catch ex As Exception
            MsgBox("FuncGETDATA_ERROR " & ex.Message)
        End Try
        End If
          
    End Function
    Function status(data As String)
        If data = "TABLO_SEC" Then
            statusText.Text = "Lütfen Tablo Seçiniz!"
            statustext.ForeColor = Color.Crimson
        End If
    End Function
    Private Async Function connectConvert() As Task

                
    End Function
Private Function DonusturJSON(ByVal dt As DataTable) As String
Dim Jserializer As New System.Web.Script.Serialization.JavaScriptSerializer()
        Dim rowsList As New List(Of Dictionary(Of String, Object))()
        Dim row As Dictionary(Of String, Object)
        For Each veriOkuyucu As DataRow In dt.Rows
            row = New Dictionary(Of String, Object)()
            For Each col As DataColumn In dt.Columns
                row.Add(col.ColumnName, veriOkuyucu(col))
            Next
            rowsList.Add(row)
        Next

        Return kaydetJSON(Jserializer.Serialize(rowsList))
    End Function

    Private Function kaydetJSON(ByVal x As String)
 If x.Contains("Seçiniz") Then
            Else
            Try
               Dim path As String = Application.StartupPath
Dim DOSYA_ISMI As String = path & "\JSON\" & newFile.Text & ".json"
If System.IO.File.Exists(DOSYA_ISMI) = False Then
System.IO.File.Create(DOSYA_ISMI).Dispose()
End If
Dim objYaz As New System.IO.StreamWriter(DOSYA_ISMI, True)
objYaz.WriteLine(x)
objYaz.Close()
 Catch ex As Exception

 End Try
 End If
        GunaAdvenceButton1.Enabled = True
        comboTable.Enabled = True
        newFile.Enabled = True
       
End Function
Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) 

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        GunaAdvenceButton1.Enabled = False
        comboTable.Enabled = False
        newFile.Enabled = False
        GetData
    End Sub

    Private Sub veriGridTablo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) 

    End Sub

    Private Sub newFile_TextChanged(sender As Object, e As EventArgs) Handles newFile.TextChanged

    End Sub

    Private Sub TabloGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TabloGrid.CellContentClick

    End Sub
End Class

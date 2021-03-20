Imports System.Data
Imports System.Data.OleDb
Public Class Bill2
    Dim con As New OleDb.OleDbConnection
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim q As String
    Dim cr As Integer

    Private Sub Bill2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Employee.mdb"
        con.Open()
        q = "select * from Bill2"
        da = New OleDb.OleDbDataAdapter(q, con)
        da.Fill(ds, "Bill2")
        DataGridView1.DataSource = ds.Tables("q")
        MsgBox("Connected")


    End Sub

    Private Sub GunaAdvenceButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton1.Click
        q = "insert into Bill2 values(" & CInt(GunaTextBox1.Text) & ",'" & GunaTextBox2.Text & "'," & CInt(GunaTextBox3.Text) & "," & CInt(GunaTextBox5.Text) & ")"
        Dim x As Integer
        cmd = New OleDb.OleDbCommand(q, con)
        x = cmd.ExecuteNonQuery()
        If (x) Then
            MsgBox("data inserted")
        Else
            MsgBox("not inserted")
        End If
        ds.Tables.Clear()
        q = "select * from Bill2"
        da = New OleDb.OleDbDataAdapter(q, con)
        da.Fill(ds, "Bill2")
        'GunaDataGridVie.DataSource = ds.Tables("Details1")
    End Sub

    Private Sub GunaAdvenceButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
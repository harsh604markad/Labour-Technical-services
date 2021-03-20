Imports System.Data
Imports System.Data.OleDb
Public Class Indian_Railways
    Dim con As New OleDb.OleDbConnection
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim q As String
    Dim cr As Integer
    Dim currentrow As Integer


    Private Sub Indian_Railways_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Employee.mdb"
        con.Open()
        q = "select * from Railway"
        da = New OleDb.OleDbDataAdapter(q, con)
        da.Fill(ds, "Railway")
        DataGridView1.DataSource = ds.Tables("q")
        MsgBox("Connected")
        Text1EmpID.Text = ds.Tables("Railway").Rows(0)("EmpID")
        Text2Empname.Text = ds.Tables("Railway").Rows(0)("Emp name")
        Text3Address.Text = ds.Tables("Railway").Rows(0)("Address")
        Text4DOB.Text = ds.Tables("Railway").Rows(0)("DOB")
        Text5Qualification.Text = ds.Tables("Railway").Rows(0)("Qualification")
        Text6Gender.Text = ds.Tables("Railway").Rows(0)("Gender")
        DataGridView1.DataSource = ds.Tables("Railway")


    End Sub

    Private Sub GunaAdvenceButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton2.Click
        Text1EmpID.Text = " "
        Text2Empname.Text = " "
        Text3Address.Text = " "
        Text4DOB.Text = " "
        Text5Qualification.Text = " "
        Text6Gender.Text = " "
    End Sub
    Private Sub ShowData(ByVal currentrow)
        Try
            Text1EmpID.Text = ds.Tables("Railway").Rows(0)("EmpId")
            Text2Empname.Text = ds.Tables("Railway").Rows(0)("Emp name")
            Text3Address.Text = ds.Tables("Railway").Rows(0)("Address")
            Text4DOB.Text = ds.Tables("Railway").Rows(0)("DOB")
            Text5Qualification.Text = ds.Tables("Railway").Rows(0)("Qualification")
            Text6Gender.Text = ds.Tables("Railway").Rows(0)("Gender")

        Catch ex As Exception
            MsgBox(ex.Message, "error")
        End Try
    End Sub

    Private Sub GunaAdvenceButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton3.Click
        If currentrow = ds.Tables("Railway").Rows.Count - 1 Then
            MsgBox("last record", MsgBoxStyle.Exclamation)

        Else
            currentrow += 1
            ShowData(currentrow)
        End If

    End Sub

    Private Sub GunaAdvenceButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton1.Click
        q = "insert into Railway values(" & CInt(Text1EmpID.Text) & ",'" & Text2Empname.Text & "','" & Text3Address.Text & "'," & CInt(Text4DOB.Text) & ",'" & Text5Qualification.Text & "','" & Text6Gender.Text & "')"
        Dim x As Integer
        cmd = New OleDb.OleDbCommand(q, con)
        x = cmd.ExecuteNonQuery()
        If (x) Then
            MsgBox("data inserted")
        Else
            MsgBox("not inserted")
        End If
        ds.Tables.Clear()
        q = "select * from Railway"
        da = New OleDb.OleDbDataAdapter(q, con)
        da.Fill(ds, "Railway")
        'GunaDataGridVie.DataSource = ds.Tables("Details1")
    End Sub
End Class
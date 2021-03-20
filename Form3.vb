Imports System.Data
Imports System.Data.OleDb

Public Class Form3
    Dim con As New OleDb.OleDbConnection
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim q As String
    Dim cr As Integer
    Dim bs As New BindingSource



   

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeDataSet1.Details1' table. You can move, or remove it, as needed.
        'Me.Details1TableAdapter.Fill(Me.EmployeeDataSet1.Details1)
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Employee.mdb"
        con.Open()
        q = "select * from Details1"
        da = New OleDb.OleDbDataAdapter(q, con)
        da.Fill(ds, "Details1")
        'GunaDataGridView1.DataSource = ds.Tables("q")
        Text1EmpID.Text = ds.Tables("Details1").Rows(0)("Emp ID")
        Text2Empname.Text = ds.Tables("Details1").Rows(0)("Emp name")
        Text3Address.Text = ds.Tables("Details1").Rows(0)("Address")
        Text4DOB.Text = ds.Tables("Details1").Rows(0)("DOB")
        Text5Qualification.Text = ds.Tables("Details1").Rows(0)("Qualification")
        Text6Gender.Text = ds.Tables("Details1").Rows(0)("Gender")



    End Sub

    Private Sub GunaAdvenceButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton2.Click
        q = "insert into Details1 values(" & CInt(Text1EmpID.Text) & ",'" & Text2Empname.Text & "','" & Text3Address.Text & "'," & CInt(Text4DOB.Text) & ",'" & Text5Qualification.Text & "','" & Text6Gender.Text & "')"
        Dim x As Integer
        cmd = New OleDb.OleDbCommand(q, con)
        x = cmd.ExecuteNonQuery()
        If (x) Then
            MsgBox("data inserted")
        Else
            MsgBox("not inserted")
        End If
        ds.Tables.Clear()
        q = "select * from Details1"
        da = New OleDb.OleDbDataAdapter(q, con)
        da.Fill(ds, "Details1")
        Dim a As Integer

        'GunaDataGridVie.DataSource = ds.Tables("Details1")

    End Sub

    Private Sub GunaAdvenceButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton1.Click
        Text1EmpID.Text = " "
        Text2Empname.Text = " "
        Text3Address.Text = " "
        Text4DOB.Text = " "
        Text5Qualification.Text = " "
        Text6Gender.Text = " "

    End Sub

    Private Sub GunaAdvenceButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton3.Click
        'BindingSource1.MoveNext()
    End Sub

    Private Sub Details1BindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GunaAdvenceButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton5.Click
        Dim nm As Integer
        nm = InputBox("enter the stock")

    End Sub

    Private Sub GunaAdvenceButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton6.Click
        bill_print.GunaTextBox1.Text = Text2Empname.Text
        bill_print.GunaTextBox2.Text = Text1EmpID.Text
        bill_print.GunaTextBox3.Text = GunaTextBox1.Text
        Me.Hide()
        bill_print.Show()

    End Sub
End Class
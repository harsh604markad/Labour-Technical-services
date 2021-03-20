Public Class bill_print

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("arial", 20, FontStyle.Regular)
        Dim font2 As New Font("arial", 30, FontStyle.Regular)
        e.Graphics.DrawString("Thanks", font2, Brushes.Black, 300, 100)

        e.Graphics.DrawString(GunaLabel1.Text, font1, Brushes.Black, 100, 200)
        e.Graphics.DrawString(GunaTextBox1.Text, font1, Brushes.Black, 300, 200)
        e.Graphics.DrawString(GunaLabel3.Text, font1, Brushes.Black, 100, 300)
        e.Graphics.DrawString(GunaTextBox2.Text, font1, Brushes.Black, 300, 300)
        e.Graphics.DrawString(GunaLabel4.Text, font1, Brushes.Black, 100, 400)
        e.Graphics.DrawString(GunaTextBox3.Text, font1, Brushes.Black, 300, 400)


    End Sub

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load

    End Sub
End Class
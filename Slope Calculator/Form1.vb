Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x1, x2, y1, y2 As Double
        Dim point1, point2 As Array
        point1 = TextBox7.Text.Split(",")
        point2 = TextBox8.Text.Split(",")

        TextBox1.Text = point2(1)
        TextBox2.Text = point1(1)
        TextBox3.Text = point2(0)
        TextBox4.Text = point1(0)

        y2 = point2(1)
        y1 = point1(1)
        x2 = point2(0)
        x1 = point1(0)
        TextBox5.Text = y2 - y1
        TextBox6.Text = x2 - x1
    End Sub

End Class

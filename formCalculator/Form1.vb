Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, sum As Double
        a = TextBox1.Text
        b = TextBox2.Text
        sum = a + b
        Label5.Text = sum
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim c, d, subt As Double
        c = TextBox3.Text
        d = TextBox4.Text
        subt = c - d
        Label6.Text = subt
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f, g, mul As Double
        f = TextBox5.Text
        g = TextBox6.Text
        mul = f * g
        Label11.Text = mul
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim h, i, div As Double
        h = TextBox7.Text
        i = TextBox8.Text
        div = h / i
        Label20.Text = div
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim a, b, sum As Double
        a = TextBox1.Text
        b = TextBox2.Text
        sum = a + b
        Label5.Text = sum

        Dim c, d, subt As Double
        c = TextBox3.Text
        d = TextBox4.Text
        subt = c - d
        Label6.Text = subt

        Dim f, g, mul As Double
        f = TextBox5.Text
        g = TextBox6.Text
        mul = f * g
        Label11.Text = mul

        Dim h, i, div As Double
        h = TextBox7.Text
        i = TextBox8.Text
        div = h / i
        Label20.Text = div
    End Sub


End Class

Public Class Form1
    Private Sub ButtonClick(sender As Object, e As EventArgs) Handles btnzero.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btnadd.Click, btnmin.Click, btnmul.Click, btndiv.Click, btnequal.Click, btnclr.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "btn1" Then
            TextBox1.Text = TextBox1.Text + "1"
        End If
        If button.Name = "btn2" Then
            TextBox1.Text = TextBox1.Text + "2"
        End If
        If button.Name = "btn3" Then
            TextBox1.Text = TextBox1.Text + "3"
        End If
        If button.Name = "btn4" Then
            TextBox1.Text = TextBox1.Text + "4"
        End If
        If button.Name = "btn5" Then
            TextBox1.Text = TextBox1.Text + "5"
        End If
        If button.Name = "btn6" Then
            TextBox1.Text = TextBox1.Text + "6"
        End If
        If button.Name = "btn7" Then
            TextBox1.Text = TextBox1.Text + "7"
        End If
        If button.Name = "btn8" Then
            TextBox1.Text = TextBox1.Text + "8"
        End If
        If button.Name = "btn9" Then
            TextBox1.Text = TextBox1.Text + "9"
        End If
        If button.Name = "btn9" Then
            TextBox1.Text = TextBox1.Text + "9"
        End If
        If button.Name = "btn9" Then
            TextBox1.Text = TextBox1.Text + "9"
        End If
        If button.Name = "btn9" Then
            TextBox1.Text = TextBox1.Text + "9"
        End If
        If button.Name = "btnzero" Then
            TextBox1.Text = TextBox1.Text + "0"
        End If
        If button.Name = "btndiv" Then
            TextBox1.Text = TextBox1.Text + "/"
        End If
        If button.Name = "btnadd" Then
            TextBox1.Text = TextBox1.Text + "+"
        End If
        If button.Name = "btndiv" Then
            TextBox1.Text = TextBox1.Text + "/"
        End If
        If button.Name = "btnmul" Then
            TextBox1.Text = TextBox1.Text + "*"
        End If

        If button.Name = "btnclr" Then
            TextBox1.Text = ""
        End If
        If button.Name = "btnequal" Then
            Dim str As String = TextBox1.Text
            Dim result = New DataTable().Compute(str, Nothing)
            TextBox1.Text = result
        End If
    End Sub
End Class

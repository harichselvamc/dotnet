Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim basicSalary As Double
        Dim allowances As Double
        Dim deductions As Double
        Dim grossSalary As Double
        Dim netSalary As Double

        ' Check if input fields are not empty and contain valid numbers
        If Double.TryParse(TextBox2.Text, basicSalary) AndAlso
           Double.TryParse(TextBox3.Text, allowances) AndAlso
           Double.TryParse(TextBox4.Text, deductions) Then

            ' Calculate gross salary
            grossSalary = basicSalary + allowances

            ' Calculate net salary
            netSalary = grossSalary - deductions

            ' Display net salary
            TextBox7.Text = netSalary.ToString("F2")
            'MsgBox("Hi! " & TextBox1.Text & " your Net Salary is Rs " & TextBox7.Text)
        Else
            MsgBox("Please enter valid numeric values.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close() ' Close the form and exit the application
    End Sub

End Class

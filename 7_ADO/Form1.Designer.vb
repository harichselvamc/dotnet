<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(226, 27)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(157, 27)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(226, 69)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(157, 27)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(226, 111)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(157, 27)
        TextBox3.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(36, 200)
        Button1.Name = "Button1"
        Button1.Size = New Size(107, 28)
        Button1.TabIndex = 3
        Button1.Text = "select"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(149, 200)
        Button2.Name = "Button2"
        Button2.Size = New Size(107, 28)
        Button2.TabIndex = 4
        Button2.Text = "insert"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(262, 200)
        Button3.Name = "Button3"
        Button3.Size = New Size(107, 28)
        Button3.TabIndex = 5
        Button3.Text = "delete"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(375, 200)
        Button4.Name = "Button4"
        Button4.Size = New Size(107, 28)
        Button4.TabIndex = 6
        Button4.Text = "update"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(488, 200)
        Button5.Name = "Button5"
        Button5.Size = New Size(107, 28)
        Button5.TabIndex = 7
        Button5.Text = "exit"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 176F))
        TableLayoutPanel1.Location = New Point(65, 266)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(537, 135)
        TableLayoutPanel1.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(45, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 20)
        Label1.TabIndex = 9
        Label1.Text = "name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(45, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 20)
        Label2.TabIndex = 10
        Label2.Text = "regno"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(45, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 20)
        Label3.TabIndex = 11
        Label3.Text = "dept"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class

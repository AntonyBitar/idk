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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_A = New System.Windows.Forms.TextBox()
        Me.txt_B = New System.Windows.Forms.TextBox()
        Me.Tex3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_C = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_x1 = New System.Windows.Forms.TextBox()
        Me.txt_x2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(229, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_A
        '
        Me.txt_A.Location = New System.Drawing.Point(415, 67)
        Me.txt_A.Name = "txt_A"
        Me.txt_A.Size = New System.Drawing.Size(125, 27)
        Me.txt_A.TabIndex = 1
        '
        'txt_B
        '
        Me.txt_B.Location = New System.Drawing.Point(415, 138)
        Me.txt_B.Name = "txt_B"
        Me.txt_B.Size = New System.Drawing.Size(125, 27)
        Me.txt_B.TabIndex = 2
        '
        'Tex3
        '
        Me.Tex3.Location = New System.Drawing.Point(405, 317)
        Me.Tex3.Name = "Tex3"
        Me.Tex3.Size = New System.Drawing.Size(125, 27)
        Me.Tex3.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(257, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(270, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'txt_C
        '
        Me.txt_C.Location = New System.Drawing.Point(415, 232)
        Me.txt_C.Name = "txt_C"
        Me.txt_C.Size = New System.Drawing.Size(125, 27)
        Me.txt_C.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(270, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(257, 380)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "X1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(257, 421)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "X2"
        '
        'txt_x1
        '
        Me.txt_x1.Location = New System.Drawing.Point(365, 373)
        Me.txt_x1.Name = "txt_x1"
        Me.txt_x1.Size = New System.Drawing.Size(125, 27)
        Me.txt_x1.TabIndex = 10
        '
        'txt_x2
        '
        Me.txt_x2.Location = New System.Drawing.Point(365, 418)
        Me.txt_x2.Name = "txt_x2"
        Me.txt_x2.Size = New System.Drawing.Size(125, 27)
        Me.txt_x2.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_x2)
        Me.Controls.Add(Me.txt_x1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_C)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tex3)
        Me.Controls.Add(Me.txt_B)
        Me.Controls.Add(Me.txt_A)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txt_A As TextBox
    Friend WithEvents txt_B As TextBox
    Friend WithEvents Tex3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_C As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_x1 As TextBox
    Friend WithEvents txt_x2 As TextBox
End Class

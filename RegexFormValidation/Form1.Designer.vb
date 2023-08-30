<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_Email = New System.Windows.Forms.Label()
        Me.lbl_Phone = New System.Windows.Forms.Label()
        Me.lbl_Website = New System.Windows.Forms.Label()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.txt_Phone = New System.Windows.Forms.TextBox()
        Me.txt_Website = New System.Windows.Forms.TextBox()
        Me.btn_Verify = New System.Windows.Forms.Button()
        Me.lbl_state1 = New System.Windows.Forms.Label()
        Me.lbl_state2 = New System.Windows.Forms.Label()
        Me.lbl_state3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_Email
        '
        Me.lbl_Email.AutoSize = True
        Me.lbl_Email.Location = New System.Drawing.Point(50, 93)
        Me.lbl_Email.Name = "lbl_Email"
        Me.lbl_Email.Size = New System.Drawing.Size(41, 16)
        Me.lbl_Email.TabIndex = 0
        Me.lbl_Email.Text = "Email"
        '
        'lbl_Phone
        '
        Me.lbl_Phone.AutoSize = True
        Me.lbl_Phone.Location = New System.Drawing.Point(50, 192)
        Me.lbl_Phone.Name = "lbl_Phone"
        Me.lbl_Phone.Size = New System.Drawing.Size(46, 16)
        Me.lbl_Phone.TabIndex = 1
        Me.lbl_Phone.Text = "Phone"
        '
        'lbl_Website
        '
        Me.lbl_Website.AutoSize = True
        Me.lbl_Website.Location = New System.Drawing.Point(50, 291)
        Me.lbl_Website.Name = "lbl_Website"
        Me.lbl_Website.Size = New System.Drawing.Size(57, 16)
        Me.lbl_Website.TabIndex = 2
        Me.lbl_Website.Text = "Website"
        '
        'txt_Email
        '
        Me.txt_Email.Location = New System.Drawing.Point(181, 77)
        Me.txt_Email.Multiline = True
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(352, 44)
        Me.txt_Email.TabIndex = 3
        '
        'txt_Phone
        '
        Me.txt_Phone.Location = New System.Drawing.Point(181, 175)
        Me.txt_Phone.Multiline = True
        Me.txt_Phone.Name = "txt_Phone"
        Me.txt_Phone.Size = New System.Drawing.Size(352, 44)
        Me.txt_Phone.TabIndex = 4
        '
        'txt_Website
        '
        Me.txt_Website.Location = New System.Drawing.Point(181, 276)
        Me.txt_Website.Multiline = True
        Me.txt_Website.Name = "txt_Website"
        Me.txt_Website.Size = New System.Drawing.Size(352, 44)
        Me.txt_Website.TabIndex = 5
        '
        'btn_Verify
        '
        Me.btn_Verify.Location = New System.Drawing.Point(564, 382)
        Me.btn_Verify.Name = "btn_Verify"
        Me.btn_Verify.Size = New System.Drawing.Size(90, 41)
        Me.btn_Verify.TabIndex = 6
        Me.btn_Verify.Text = "Verify"
        Me.btn_Verify.UseVisualStyleBackColor = True
        '
        'lbl_state1
        '
        Me.lbl_state1.AutoSize = True
        Me.lbl_state1.Location = New System.Drawing.Point(196, 128)
        Me.lbl_state1.Name = "lbl_state1"
        Me.lbl_state1.Size = New System.Drawing.Size(36, 16)
        Me.lbl_state1.TabIndex = 7
        Me.lbl_state1.Text = "state"
        '
        'lbl_state2
        '
        Me.lbl_state2.AutoSize = True
        Me.lbl_state2.Location = New System.Drawing.Point(196, 233)
        Me.lbl_state2.Name = "lbl_state2"
        Me.lbl_state2.Size = New System.Drawing.Size(36, 16)
        Me.lbl_state2.TabIndex = 8
        Me.lbl_state2.Text = "state"
        '
        'lbl_state3
        '
        Me.lbl_state3.AutoSize = True
        Me.lbl_state3.Location = New System.Drawing.Point(196, 336)
        Me.lbl_state3.Name = "lbl_state3"
        Me.lbl_state3.Size = New System.Drawing.Size(36, 16)
        Me.lbl_state3.TabIndex = 9
        Me.lbl_state3.Text = "state"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_state3)
        Me.Controls.Add(Me.lbl_state2)
        Me.Controls.Add(Me.lbl_state1)
        Me.Controls.Add(Me.btn_Verify)
        Me.Controls.Add(Me.txt_Website)
        Me.Controls.Add(Me.txt_Phone)
        Me.Controls.Add(Me.txt_Email)
        Me.Controls.Add(Me.lbl_Website)
        Me.Controls.Add(Me.lbl_Phone)
        Me.Controls.Add(Me.lbl_Email)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Email As Label
    Friend WithEvents lbl_Phone As Label
    Friend WithEvents lbl_Website As Label
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents txt_Phone As TextBox
    Friend WithEvents txt_Website As TextBox
    Friend WithEvents btn_Verify As Button
    Friend WithEvents lbl_state1 As Label
    Friend WithEvents lbl_state2 As Label
    Friend WithEvents lbl_state3 As Label
End Class

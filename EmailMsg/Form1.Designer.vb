<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmailForm
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
        Me.lbl_From = New System.Windows.Forms.Label()
        Me.lbl_To = New System.Windows.Forms.Label()
        Me.lbl_Subject = New System.Windows.Forms.Label()
        Me.lbl_Message = New System.Windows.Forms.Label()
        Me.txt_From = New System.Windows.Forms.TextBox()
        Me.Txt_To = New System.Windows.Forms.TextBox()
        Me.txt_Subject = New System.Windows.Forms.TextBox()
        Me.txt_Message = New System.Windows.Forms.TextBox()
        Me.btn_Send = New System.Windows.Forms.Button()
        Me.lbl_heading = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_From
        '
        Me.lbl_From.AutoSize = True
        Me.lbl_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_From.Location = New System.Drawing.Point(76, 87)
        Me.lbl_From.Name = "lbl_From"
        Me.lbl_From.Size = New System.Drawing.Size(74, 29)
        Me.lbl_From.TabIndex = 0
        Me.lbl_From.Text = "From"
        '
        'lbl_To
        '
        Me.lbl_To.AutoSize = True
        Me.lbl_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_To.Location = New System.Drawing.Point(76, 159)
        Me.lbl_To.Name = "lbl_To"
        Me.lbl_To.Size = New System.Drawing.Size(45, 29)
        Me.lbl_To.TabIndex = 1
        Me.lbl_To.Text = "To"
        '
        'lbl_Subject
        '
        Me.lbl_Subject.AutoSize = True
        Me.lbl_Subject.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Subject.Location = New System.Drawing.Point(76, 240)
        Me.lbl_Subject.Name = "lbl_Subject"
        Me.lbl_Subject.Size = New System.Drawing.Size(101, 29)
        Me.lbl_Subject.TabIndex = 2
        Me.lbl_Subject.Text = "Subject"
        '
        'lbl_Message
        '
        Me.lbl_Message.AutoSize = True
        Me.lbl_Message.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Message.Location = New System.Drawing.Point(76, 318)
        Me.lbl_Message.Name = "lbl_Message"
        Me.lbl_Message.Size = New System.Drawing.Size(119, 29)
        Me.lbl_Message.TabIndex = 3
        Me.lbl_Message.Text = "Message"
        '
        'txt_From
        '
        Me.txt_From.Location = New System.Drawing.Point(235, 87)
        Me.txt_From.Multiline = True
        Me.txt_From.Name = "txt_From"
        Me.txt_From.Size = New System.Drawing.Size(338, 30)
        Me.txt_From.TabIndex = 4
        '
        'Txt_To
        '
        Me.Txt_To.Location = New System.Drawing.Point(235, 159)
        Me.Txt_To.Multiline = True
        Me.Txt_To.Name = "Txt_To"
        Me.Txt_To.Size = New System.Drawing.Size(338, 30)
        Me.Txt_To.TabIndex = 5
        '
        'txt_Subject
        '
        Me.txt_Subject.Location = New System.Drawing.Point(235, 240)
        Me.txt_Subject.Multiline = True
        Me.txt_Subject.Name = "txt_Subject"
        Me.txt_Subject.Size = New System.Drawing.Size(338, 30)
        Me.txt_Subject.TabIndex = 6
        '
        'txt_Message
        '
        Me.txt_Message.Location = New System.Drawing.Point(235, 318)
        Me.txt_Message.Multiline = True
        Me.txt_Message.Name = "txt_Message"
        Me.txt_Message.Size = New System.Drawing.Size(338, 140)
        Me.txt_Message.TabIndex = 7
        '
        'btn_Send
        '
        Me.btn_Send.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Send.Location = New System.Drawing.Point(595, 477)
        Me.btn_Send.Name = "btn_Send"
        Me.btn_Send.Size = New System.Drawing.Size(151, 44)
        Me.btn_Send.TabIndex = 8
        Me.btn_Send.Text = "Send"
        Me.btn_Send.UseVisualStyleBackColor = True
        '
        'lbl_heading
        '
        Me.lbl_heading.AutoSize = True
        Me.lbl_heading.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_heading.Location = New System.Drawing.Point(290, 23)
        Me.lbl_heading.Name = "lbl_heading"
        Me.lbl_heading.Size = New System.Drawing.Size(254, 32)
        Me.lbl_heading.TabIndex = 9
        Me.lbl_heading.Text = "Sending an Email"
        '
        'EmailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 556)
        Me.Controls.Add(Me.lbl_heading)
        Me.Controls.Add(Me.btn_Send)
        Me.Controls.Add(Me.txt_Message)
        Me.Controls.Add(Me.txt_Subject)
        Me.Controls.Add(Me.Txt_To)
        Me.Controls.Add(Me.txt_From)
        Me.Controls.Add(Me.lbl_Message)
        Me.Controls.Add(Me.lbl_Subject)
        Me.Controls.Add(Me.lbl_To)
        Me.Controls.Add(Me.lbl_From)
        Me.Name = "EmailForm"
        Me.Text = "Email"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_From As Label
    Friend WithEvents lbl_To As Label
    Friend WithEvents lbl_Subject As Label
    Friend WithEvents lbl_Message As Label
    Friend WithEvents txt_From As TextBox
    Friend WithEvents Txt_To As TextBox
    Friend WithEvents txt_Subject As TextBox
    Friend WithEvents txt_Message As TextBox
    Friend WithEvents btn_Send As Button
    Friend WithEvents lbl_heading As Label
End Class

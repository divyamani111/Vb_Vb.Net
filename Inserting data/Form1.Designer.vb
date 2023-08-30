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
        Me.lbl_id2 = New System.Windows.Forms.Label()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.lbl_tel = New System.Windows.Forms.Label()
        Me.lbl_Age = New System.Windows.Forms.Label()
        Me.txt_id2 = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_tel = New System.Windows.Forms.TextBox()
        Me.txt_Age = New System.Windows.Forms.TextBox()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.Label()
        Me.txtbox_id = New System.Windows.Forms.TextBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_id2
        '
        Me.lbl_id2.AutoSize = True
        Me.lbl_id2.Location = New System.Drawing.Point(66, 124)
        Me.lbl_id2.Name = "lbl_id2"
        Me.lbl_id2.Size = New System.Drawing.Size(25, 16)
        Me.lbl_id2.TabIndex = 0
        Me.lbl_id2.Text = "id2"
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Location = New System.Drawing.Point(66, 200)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(41, 16)
        Me.lbl_Name.TabIndex = 1
        Me.lbl_Name.Text = "name"
        '
        'lbl_tel
        '
        Me.lbl_tel.AutoSize = True
        Me.lbl_tel.Location = New System.Drawing.Point(66, 275)
        Me.lbl_tel.Name = "lbl_tel"
        Me.lbl_tel.Size = New System.Drawing.Size(21, 16)
        Me.lbl_tel.TabIndex = 2
        Me.lbl_tel.Text = "tel"
        '
        'lbl_Age
        '
        Me.lbl_Age.AutoSize = True
        Me.lbl_Age.Location = New System.Drawing.Point(66, 353)
        Me.lbl_Age.Name = "lbl_Age"
        Me.lbl_Age.Size = New System.Drawing.Size(32, 16)
        Me.lbl_Age.TabIndex = 3
        Me.lbl_Age.Text = "Age"
        '
        'txt_id2
        '
        Me.txt_id2.Location = New System.Drawing.Point(283, 124)
        Me.txt_id2.Multiline = True
        Me.txt_id2.Name = "txt_id2"
        Me.txt_id2.Size = New System.Drawing.Size(155, 29)
        Me.txt_id2.TabIndex = 4
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(283, 187)
        Me.txt_name.Multiline = True
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(155, 29)
        Me.txt_name.TabIndex = 5
        '
        'txt_tel
        '
        Me.txt_tel.Location = New System.Drawing.Point(283, 262)
        Me.txt_tel.Multiline = True
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(155, 29)
        Me.txt_tel.TabIndex = 6
        '
        'txt_Age
        '
        Me.txt_Age.Location = New System.Drawing.Point(283, 340)
        Me.txt_Age.Multiline = True
        Me.txt_Age.Name = "txt_Age"
        Me.txt_Age.Size = New System.Drawing.Size(155, 29)
        Me.txt_Age.TabIndex = 7
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(49, 429)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(129, 40)
        Me.btn_insert.TabIndex = 8
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(231, 429)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(155, 40)
        Me.btn_update.TabIndex = 9
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'txt_id
        '
        Me.txt_id.AutoSize = True
        Me.txt_id.Location = New System.Drawing.Point(66, 53)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(18, 16)
        Me.txt_id.TabIndex = 10
        Me.txt_id.Text = "id"
        '
        'txtbox_id
        '
        Me.txtbox_id.Location = New System.Drawing.Point(283, 63)
        Me.txtbox_id.Multiline = True
        Me.txtbox_id.Name = "txtbox_id"
        Me.txtbox_id.Size = New System.Drawing.Size(155, 29)
        Me.txtbox_id.TabIndex = 11
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(632, 429)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(123, 40)
        Me.btn_clear.TabIndex = 12
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(445, 429)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(141, 40)
        Me.btn_delete.TabIndex = 13
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(632, 24)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(138, 32)
        Me.btn_search.TabIndex = 14
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 481)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.txtbox_id)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.txt_Age)
        Me.Controls.Add(Me.txt_tel)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id2)
        Me.Controls.Add(Me.lbl_Age)
        Me.Controls.Add(Me.lbl_tel)
        Me.Controls.Add(Me.lbl_Name)
        Me.Controls.Add(Me.lbl_id2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_id2 As Label
    Friend WithEvents lbl_Name As Label
    Friend WithEvents lbl_tel As Label
    Friend WithEvents lbl_Age As Label
    Friend WithEvents txt_id2 As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_tel As TextBox
    Friend WithEvents txt_Age As TextBox
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents txt_id As Label
    Friend WithEvents txtbox_id As TextBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_search As Button
End Class

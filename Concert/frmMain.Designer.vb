<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNumLawn = New System.Windows.Forms.TextBox()
        Me.txtNumPavilion = New System.Windows.Forms.TextBox()
        Me.txtNumBox = New System.Windows.Forms.TextBox()
        Me.chkLawn = New System.Windows.Forms.CheckBox()
        Me.chkPavilion = New System.Windows.Forms.CheckBox()
        Me.chkBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTtlTickets = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTtlDue = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNumLawn)
        Me.GroupBox1.Controls.Add(Me.txtNumPavilion)
        Me.GroupBox1.Controls.Add(Me.txtNumBox)
        Me.GroupBox1.Controls.Add(Me.chkLawn)
        Me.GroupBox1.Controls.Add(Me.chkPavilion)
        Me.GroupBox1.Controls.Add(Me.chkBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 129)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tickets:"
        '
        'txtNumLawn
        '
        Me.txtNumLawn.Location = New System.Drawing.Point(91, 80)
        Me.txtNumLawn.Name = "txtNumLawn"
        Me.txtNumLawn.Size = New System.Drawing.Size(100, 20)
        Me.txtNumLawn.TabIndex = 5
        Me.txtNumLawn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumPavilion
        '
        Me.txtNumPavilion.Location = New System.Drawing.Point(91, 54)
        Me.txtNumPavilion.Name = "txtNumPavilion"
        Me.txtNumPavilion.Size = New System.Drawing.Size(100, 20)
        Me.txtNumPavilion.TabIndex = 4
        Me.txtNumPavilion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumBox
        '
        Me.txtNumBox.Location = New System.Drawing.Point(91, 28)
        Me.txtNumBox.Name = "txtNumBox"
        Me.txtNumBox.Size = New System.Drawing.Size(100, 20)
        Me.txtNumBox.TabIndex = 3
        Me.txtNumBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkLawn
        '
        Me.chkLawn.AutoSize = True
        Me.chkLawn.Location = New System.Drawing.Point(22, 82)
        Me.chkLawn.Name = "chkLawn"
        Me.chkLawn.Size = New System.Drawing.Size(52, 17)
        Me.chkLawn.TabIndex = 2
        Me.chkLawn.Text = "&Lawn"
        Me.chkLawn.UseVisualStyleBackColor = True
        '
        'chkPavilion
        '
        Me.chkPavilion.AutoSize = True
        Me.chkPavilion.Location = New System.Drawing.Point(22, 56)
        Me.chkPavilion.Name = "chkPavilion"
        Me.chkPavilion.Size = New System.Drawing.Size(63, 17)
        Me.chkPavilion.TabIndex = 1
        Me.chkPavilion.Text = "&Pavilion"
        Me.chkPavilion.UseVisualStyleBackColor = True
        '
        'chkBox
        '
        Me.chkBox.AutoSize = True
        Me.chkBox.Location = New System.Drawing.Point(22, 30)
        Me.chkBox.Name = "chkBox"
        Me.chkBox.Size = New System.Drawing.Size(44, 17)
        Me.chkBox.TabIndex = 0
        Me.chkBox.Text = "&Box"
        Me.chkBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total tickets:"
        '
        'lblTtlTickets
        '
        Me.lblTtlTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTtlTickets.Location = New System.Drawing.Point(12, 173)
        Me.lblTtlTickets.Name = "lblTtlTickets"
        Me.lblTtlTickets.Size = New System.Drawing.Size(100, 23)
        Me.lblTtlTickets.TabIndex = 2
        Me.lblTtlTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total due:"
        '
        'lblTtlDue
        '
        Me.lblTtlDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTtlDue.Location = New System.Drawing.Point(12, 216)
        Me.lblTtlDue.Name = "lblTtlDue"
        Me.lblTtlDue.Size = New System.Drawing.Size(100, 23)
        Me.lblTtlDue.TabIndex = 4
        Me.lblTtlDue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(149, 160)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(149, 190)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(149, 220)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 258)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTtlDue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTtlTickets)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Concert Tickets"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNumLawn As TextBox
    Friend WithEvents txtNumPavilion As TextBox
    Friend WithEvents txtNumBox As TextBox
    Friend WithEvents chkLawn As CheckBox
    Friend WithEvents chkPavilion As CheckBox
    Friend WithEvents chkBox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTtlTickets As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTtlDue As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class

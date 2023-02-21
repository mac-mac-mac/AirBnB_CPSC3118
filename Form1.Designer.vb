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
        Me.picAirbnb = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblNights = New System.Windows.Forms.Label()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picAirbnb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picAirbnb
        '
        Me.picAirbnb.Location = New System.Drawing.Point(1, 1)
        Me.picAirbnb.Name = "picAirbnb"
        Me.picAirbnb.Size = New System.Drawing.Size(400, 450)
        Me.picAirbnb.TabIndex = 0
        Me.picAirbnb.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(464, 41)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(276, 36)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Orlando AirBnB"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(523, 89)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(154, 15)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.Text = "Only $79.00 per night"
        '
        'lblNights
        '
        Me.lblNights.AutoSize = True
        Me.lblNights.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNights.Location = New System.Drawing.Point(466, 170)
        Me.lblNights.Name = "lblNights"
        Me.lblNights.Size = New System.Drawing.Size(114, 21)
        Me.lblNights.TabIndex = 3
        Me.lblNights.Text = "Number of Nights:"
        '
        'txtNights
        '
        Me.txtNights.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNights.Location = New System.Drawing.Point(630, 170)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(47, 26)
        Me.txtNights.TabIndex = 4
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(466, 226)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(81, 21)
        Me.lblCost.TabIndex = 5
        Me.lblCost.Text = "Cost of Stay:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(626, 226)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 21)
        Me.lblTotal.TabIndex = 6
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(447, 352)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(100, 25)
        Me.btnDisplay.TabIndex = 7
        Me.btnDisplay.Text = "Display Cost"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(553, 352)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 25)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(659, 352)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 25)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.txtNights)
        Me.Controls.Add(Me.lblNights)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picAirbnb)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picAirbnb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picAirbnb As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblNights As Label
    Friend WithEvents txtNights As TextBox
    Friend WithEvents lblCost As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class

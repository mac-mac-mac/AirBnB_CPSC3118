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
        Me.picAirBnB = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblNumberOfNights = New System.Windows.Forms.Label()
        Me.txtNumberOfNights = New System.Windows.Forms.TextBox()
        Me.lblCostOfStay = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnDisplayCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picAirBnB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picAirBnB
        '
        Me.picAirBnB.Location = New System.Drawing.Point(1, 1)
        Me.picAirBnB.Name = "picAirBnB"
        Me.picAirBnB.Size = New System.Drawing.Size(400, 450)
        Me.picAirBnB.TabIndex = 0
        Me.picAirBnB.TabStop = False
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
        'lblNumberOfNights
        '
        Me.lblNumberOfNights.AutoSize = True
        Me.lblNumberOfNights.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfNights.Location = New System.Drawing.Point(466, 170)
        Me.lblNumberOfNights.Name = "lblNumberOfNights"
        Me.lblNumberOfNights.Size = New System.Drawing.Size(114, 21)
        Me.lblNumberOfNights.TabIndex = 3
        Me.lblNumberOfNights.Text = "Number of Nights:"
        '
        'txtNumberOfNights
        '
        Me.txtNumberOfNights.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfNights.Location = New System.Drawing.Point(630, 170)
        Me.txtNumberOfNights.Name = "txtNumberOfNights"
        Me.txtNumberOfNights.Size = New System.Drawing.Size(47, 26)
        Me.txtNumberOfNights.TabIndex = 4
        '
        'lblCostOfStay
        '
        Me.lblCostOfStay.AutoSize = True
        Me.lblCostOfStay.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostOfStay.Location = New System.Drawing.Point(466, 226)
        Me.lblCostOfStay.Name = "lblCostOfStay"
        Me.lblCostOfStay.Size = New System.Drawing.Size(81, 21)
        Me.lblCostOfStay.TabIndex = 5
        Me.lblCostOfStay.Text = "Cost of Stay:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(626, 226)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(0, 21)
        Me.lblTotalCost.TabIndex = 6
        '
        'btnDisplayCost
        '
        Me.btnDisplayCost.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayCost.Location = New System.Drawing.Point(447, 352)
        Me.btnDisplayCost.Name = "btnDisplayCost"
        Me.btnDisplayCost.Size = New System.Drawing.Size(100, 25)
        Me.btnDisplayCost.TabIndex = 7
        Me.btnDisplayCost.Text = "Display Cost"
        Me.btnDisplayCost.UseVisualStyleBackColor = True
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
        Me.Controls.Add(Me.btnDisplayCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblCostOfStay)
        Me.Controls.Add(Me.txtNumberOfNights)
        Me.Controls.Add(Me.lblNumberOfNights)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picAirBnB)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picAirBnB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picAirBnB As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblNumberOfNights As Label
    Friend WithEvents txtNumberOfNights As TextBox
    Friend WithEvents lblCostOfStay As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnDisplayCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class

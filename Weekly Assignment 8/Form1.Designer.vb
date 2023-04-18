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
        Me.picSmarthome = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.lblMonthSavings = New System.Windows.Forms.Label()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.lblAverageSavings = New System.Windows.Forms.Label()
        Me.lblSignificantSavings = New System.Windows.Forms.Label()
        CType(Me.picSmarthome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSmarthome
        '
        Me.picSmarthome.Image = Global.Weekly_Assignment_8.My.Resources.Resources.smarthome
        Me.picSmarthome.Location = New System.Drawing.Point(0, -2)
        Me.picSmarthome.Name = "picSmarthome"
        Me.picSmarthome.Size = New System.Drawing.Size(285, 225)
        Me.picSmarthome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSmarthome.TabIndex = 0
        Me.picSmarthome.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(291, 27)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(230, 103)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Smart Home Electric Savings"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboMonth
        '
        Me.cboMonth.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Location = New System.Drawing.Point(341, 157)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(121, 27)
        Me.cboMonth.TabIndex = 2
        '
        'lblMonthSavings
        '
        Me.lblMonthSavings.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthSavings.Location = New System.Drawing.Point(52, 235)
        Me.lblMonthSavings.Name = "lblMonthSavings"
        Me.lblMonthSavings.Size = New System.Drawing.Size(410, 27)
        Me.lblMonthSavings.TabIndex = 3
        Me.lblMonthSavings.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblMonthSavings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStatistics
        '
        Me.btnStatistics.BackColor = System.Drawing.Color.SteelBlue
        Me.btnStatistics.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistics.ForeColor = System.Drawing.Color.White
        Me.btnStatistics.Location = New System.Drawing.Point(160, 265)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(191, 36)
        Me.btnStatistics.TabIndex = 4
        Me.btnStatistics.Text = "Display Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = False
        '
        'lblAverageSavings
        '
        Me.lblAverageSavings.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageSavings.Location = New System.Drawing.Point(12, 304)
        Me.lblAverageSavings.Name = "lblAverageSavings"
        Me.lblAverageSavings.Size = New System.Drawing.Size(487, 30)
        Me.lblAverageSavings.TabIndex = 5
        Me.lblAverageSavings.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblAverageSavings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSignificantSavings
        '
        Me.lblSignificantSavings.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignificantSavings.Location = New System.Drawing.Point(16, 334)
        Me.lblSignificantSavings.Name = "lblSignificantSavings"
        Me.lblSignificantSavings.Size = New System.Drawing.Size(467, 43)
        Me.lblSignificantSavings.TabIndex = 6
        Me.lblSignificantSavings.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblSignificantSavings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(522, 395)
        Me.Controls.Add(Me.lblSignificantSavings)
        Me.Controls.Add(Me.lblAverageSavings)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.lblMonthSavings)
        Me.Controls.Add(Me.cboMonth)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picSmarthome)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.picSmarthome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picSmarthome As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents lblMonthSavings As Label
    Friend WithEvents btnStatistics As Button
    Friend WithEvents lblAverageSavings As Label
    Friend WithEvents lblSignificantSavings As Label
End Class

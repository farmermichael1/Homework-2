<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homework2
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.lbPayCal = New System.Windows.Forms.Label()
        Me.lbGross = New System.Windows.Forms.Label()
        Me.txtPay = New System.Windows.Forms.TextBox()
        Me.btnTaxCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lbFICA = New System.Windows.Forms.Label()
        Me.lbFICAPay = New System.Windows.Forms.Label()
        Me.lbft = New System.Windows.Forms.Label()
        Me.lbftPay = New System.Windows.Forms.Label()
        Me.lbst = New System.Windows.Forms.Label()
        Me.lbstPay = New System.Windows.Forms.Label()
        Me.lbPaycheck = New System.Windows.Forms.Label()
        Me.lbIncome = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Homework2.My.Resources.Resources.payroll
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(336, 215)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitle.Location = New System.Drawing.Point(341, 31)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(381, 44)
        Me.lbTitle.TabIndex = 1
        Me.lbTitle.Text = "Payroll Calculator"
        '
        'lbPayCal
        '
        Me.lbPayCal.AutoSize = True
        Me.lbPayCal.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPayCal.Location = New System.Drawing.Point(420, 92)
        Me.lbPayCal.Name = "lbPayCal"
        Me.lbPayCal.Size = New System.Drawing.Size(205, 78)
        Me.lbPayCal.TabIndex = 2
        Me.lbPayCal.Text = " Paycheck" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calculation"
        '
        'lbGross
        '
        Me.lbGross.AutoSize = True
        Me.lbGross.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGross.Location = New System.Drawing.Point(224, 238)
        Me.lbGross.Name = "lbGross"
        Me.lbGross.Size = New System.Drawing.Size(194, 25)
        Me.lbGross.TabIndex = 3
        Me.lbGross.Text = "Enter Gross Pay:"
        '
        'txtPay
        '
        Me.txtPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPay.Location = New System.Drawing.Point(455, 238)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Size = New System.Drawing.Size(100, 29)
        Me.txtPay.TabIndex = 4
        '
        'btnTaxCalc
        '
        Me.btnTaxCalc.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnTaxCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTaxCalc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTaxCalc.Location = New System.Drawing.Point(121, 291)
        Me.btnTaxCalc.Name = "btnTaxCalc"
        Me.btnTaxCalc.Size = New System.Drawing.Size(125, 32)
        Me.btnTaxCalc.TabIndex = 5
        Me.btnTaxCalc.Text = "Compute Taxes"
        Me.btnTaxCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClear.Location = New System.Drawing.Point(293, 291)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(125, 32)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(473, 291)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 32)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lbFICA
        '
        Me.lbFICA.AutoSize = True
        Me.lbFICA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFICA.Location = New System.Drawing.Point(95, 357)
        Me.lbFICA.Name = "lbFICA"
        Me.lbFICA.Size = New System.Drawing.Size(52, 18)
        Me.lbFICA.TabIndex = 8
        Me.lbFICA.Text = "FICA:"
        '
        'lbFICAPay
        '
        Me.lbFICAPay.AutoSize = True
        Me.lbFICAPay.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.lbFICAPay.Location = New System.Drawing.Point(153, 357)
        Me.lbFICAPay.Name = "lbFICAPay"
        Me.lbFICAPay.Size = New System.Drawing.Size(62, 18)
        Me.lbFICAPay.TabIndex = 9
        Me.lbFICAPay.Text = "Label5"
        '
        'lbft
        '
        Me.lbft.AutoSize = True
        Me.lbft.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.lbft.Location = New System.Drawing.Point(283, 357)
        Me.lbft.Name = "lbft"
        Me.lbft.Size = New System.Drawing.Size(106, 18)
        Me.lbft.TabIndex = 10
        Me.lbft.Text = "Federal Tax:"
        '
        'lbftPay
        '
        Me.lbftPay.AutoSize = True
        Me.lbftPay.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.lbftPay.Location = New System.Drawing.Point(395, 357)
        Me.lbftPay.Name = "lbftPay"
        Me.lbftPay.Size = New System.Drawing.Size(62, 18)
        Me.lbftPay.TabIndex = 11
        Me.lbftPay.Text = "Label7"
        '
        'lbst
        '
        Me.lbst.AutoSize = True
        Me.lbst.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.lbst.Location = New System.Drawing.Point(505, 357)
        Me.lbst.Name = "lbst"
        Me.lbst.Size = New System.Drawing.Size(88, 18)
        Me.lbst.TabIndex = 12
        Me.lbst.Text = "State Tax:"
        '
        'lbstPay
        '
        Me.lbstPay.AutoSize = True
        Me.lbstPay.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.lbstPay.Location = New System.Drawing.Point(609, 357)
        Me.lbstPay.Name = "lbstPay"
        Me.lbstPay.Size = New System.Drawing.Size(62, 18)
        Me.lbstPay.TabIndex = 13
        Me.lbstPay.Text = "Label9"
        '
        'lbPaycheck
        '
        Me.lbPaycheck.AutoSize = True
        Me.lbPaycheck.Font = New System.Drawing.Font("Yu Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPaycheck.Location = New System.Drawing.Point(119, 416)
        Me.lbPaycheck.Name = "lbPaycheck"
        Me.lbPaycheck.Size = New System.Drawing.Size(216, 25)
        Me.lbPaycheck.TabIndex = 14
        Me.lbPaycheck.Text = "Net Paycheck Income:"
        '
        'lbIncome
        '
        Me.lbIncome.AutoSize = True
        Me.lbIncome.Font = New System.Drawing.Font("Yu Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbIncome.Location = New System.Drawing.Point(381, 416)
        Me.lbIncome.Name = "lbIncome"
        Me.lbIncome.Size = New System.Drawing.Size(85, 25)
        Me.lbIncome.TabIndex = 15
        Me.lbIncome.Text = "Label11"
        '
        'Homework2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 495)
        Me.Controls.Add(Me.lbIncome)
        Me.Controls.Add(Me.lbPaycheck)
        Me.Controls.Add(Me.lbstPay)
        Me.Controls.Add(Me.lbst)
        Me.Controls.Add(Me.lbftPay)
        Me.Controls.Add(Me.lbft)
        Me.Controls.Add(Me.lbFICAPay)
        Me.Controls.Add(Me.lbFICA)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTaxCalc)
        Me.Controls.Add(Me.txtPay)
        Me.Controls.Add(Me.lbGross)
        Me.Controls.Add(Me.lbPayCal)
        Me.Controls.Add(Me.lbTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Homework2"
        Me.Text = "Payroll Every Two Weeks"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbTitle As Label
    Friend WithEvents lbPayCal As Label
    Friend WithEvents lbGross As Label
    Friend WithEvents txtPay As TextBox
    Friend WithEvents btnTaxCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lbFICA As Label
    Friend WithEvents lbFICAPay As Label
    Friend WithEvents lbft As Label
    Friend WithEvents lbftPay As Label
    Friend WithEvents lbst As Label
    Friend WithEvents lbstPay As Label
    Friend WithEvents lbPaycheck As Label
    Friend WithEvents lbIncome As Label
End Class

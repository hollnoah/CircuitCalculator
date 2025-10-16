<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CircuitCalculator
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
        Me.TrackBarVgen = New System.Windows.Forms.TrackBar()
        Me.LabelVgen = New System.Windows.Forms.Label()
        Me.LabelVgenValue = New System.Windows.Forms.Label()
        Me.LabelFrequency = New System.Windows.Forms.Label()
        Me.TextBoxFrequency = New System.Windows.Forms.TextBox()
        Me.LabelRgen = New System.Windows.Forms.Label()
        Me.ComboBoxRgen = New System.Windows.Forms.ComboBox()
        Me.LabelR1 = New System.Windows.Forms.Label()
        Me.ComboBoxR1Value = New System.Windows.Forms.ComboBox()
        Me.ComboBoxR1Prefix = New System.Windows.Forms.ComboBox()
        Me.ComboBoxC1Prefix = New System.Windows.Forms.ComboBox()
        Me.ComboBoxC1Value = New System.Windows.Forms.ComboBox()
        Me.LabelC1 = New System.Windows.Forms.Label()
        Me.ComboBoxC2Prefix = New System.Windows.Forms.ComboBox()
        Me.ComboBoxC2Value = New System.Windows.Forms.ComboBox()
        Me.LabelC2 = New System.Windows.Forms.Label()
        Me.ComboBoxL1Prefix = New System.Windows.Forms.ComboBox()
        Me.ComboBoxL1Value = New System.Windows.Forms.ComboBox()
        Me.LabelL1 = New System.Windows.Forms.Label()
        Me.LabelRwinding = New System.Windows.Forms.Label()
        Me.TextBoxRwinding = New System.Windows.Forms.TextBox()
        Me.GroupBoxOutputFormat = New System.Windows.Forms.GroupBox()
        Me.RadioRectangular = New System.Windows.Forms.RadioButton()
        Me.RadioPolar = New System.Windows.Forms.RadioButton()
        Me.LabelResults = New System.Windows.Forms.Label()
        Me.ListBoxResults = New System.Windows.Forms.ListBox()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        CType(Me.TrackBarVgen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxOutputFormat.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrackBarVgen
        '
        Me.TrackBarVgen.Location = New System.Drawing.Point(270, 420)
        Me.TrackBarVgen.Maximum = 100
        Me.TrackBarVgen.Name = "TrackBarVgen"
        Me.TrackBarVgen.Size = New System.Drawing.Size(104, 56)
        Me.TrackBarVgen.TabIndex = 1
        '
        'LabelVgen
        '
        Me.LabelVgen.AutoSize = True
        Me.LabelVgen.Location = New System.Drawing.Point(304, 401)
        Me.LabelVgen.Name = "LabelVgen"
        Me.LabelVgen.Size = New System.Drawing.Size(39, 16)
        Me.LabelVgen.TabIndex = 2
        Me.LabelVgen.Text = "Vgen"
        '
        'LabelVgenValue
        '
        Me.LabelVgenValue.AutoSize = True
        Me.LabelVgenValue.Location = New System.Drawing.Point(296, 460)
        Me.LabelVgenValue.Name = "LabelVgenValue"
        Me.LabelVgenValue.Size = New System.Drawing.Size(47, 16)
        Me.LabelVgenValue.TabIndex = 3
        Me.LabelVgenValue.Text = "5.0 Vp "
        '
        'LabelFrequency
        '
        Me.LabelFrequency.AutoSize = True
        Me.LabelFrequency.Location = New System.Drawing.Point(271, 493)
        Me.LabelFrequency.Name = "LabelFrequency"
        Me.LabelFrequency.Size = New System.Drawing.Size(136, 16)
        Me.LabelFrequency.TabIndex = 4
        Me.LabelFrequency.Text = "Source Frequency Hz"
        '
        'TextBoxFrequency
        '
        Me.TextBoxFrequency.Location = New System.Drawing.Point(274, 512)
        Me.TextBoxFrequency.Name = "TextBoxFrequency"
        Me.TextBoxFrequency.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxFrequency.TabIndex = 5
        Me.TextBoxFrequency.Text = "1000"
        '
        'LabelRgen
        '
        Me.LabelRgen.AutoSize = True
        Me.LabelRgen.Location = New System.Drawing.Point(273, 358)
        Me.LabelRgen.Name = "LabelRgen"
        Me.LabelRgen.Size = New System.Drawing.Size(40, 16)
        Me.LabelRgen.TabIndex = 6
        Me.LabelRgen.Text = "Rgen"
        '
        'ComboBoxRgen
        '
        Me.ComboBoxRgen.FormattingEnabled = True
        Me.ComboBoxRgen.Items.AddRange(New Object() {"50ohm", "400ohm"})
        Me.ComboBoxRgen.Location = New System.Drawing.Point(315, 355)
        Me.ComboBoxRgen.Name = "ComboBoxRgen"
        Me.ComboBoxRgen.Size = New System.Drawing.Size(79, 24)
        Me.ComboBoxRgen.TabIndex = 7
        '
        'LabelR1
        '
        Me.LabelR1.AutoSize = True
        Me.LabelR1.Location = New System.Drawing.Point(412, 316)
        Me.LabelR1.Name = "LabelR1"
        Me.LabelR1.Size = New System.Drawing.Size(24, 16)
        Me.LabelR1.TabIndex = 8
        Me.LabelR1.Text = "R1"
        '
        'ComboBoxR1Value
        '
        Me.ComboBoxR1Value.FormattingEnabled = True
        Me.ComboBoxR1Value.Items.AddRange(New Object() {"1", "2.2", "4.7", "10", "22", "47", "100"})
        Me.ComboBoxR1Value.Location = New System.Drawing.Point(443, 314)
        Me.ComboBoxR1Value.Name = "ComboBoxR1Value"
        Me.ComboBoxR1Value.Size = New System.Drawing.Size(80, 24)
        Me.ComboBoxR1Value.TabIndex = 9
        '
        'ComboBoxR1Prefix
        '
        Me.ComboBoxR1Prefix.FormattingEnabled = True
        Me.ComboBoxR1Prefix.Items.AddRange(New Object() {"", "k", "M"})
        Me.ComboBoxR1Prefix.Location = New System.Drawing.Point(534, 314)
        Me.ComboBoxR1Prefix.Name = "ComboBoxR1Prefix"
        Me.ComboBoxR1Prefix.Size = New System.Drawing.Size(81, 24)
        Me.ComboBoxR1Prefix.TabIndex = 10
        '
        'ComboBoxC1Prefix
        '
        Me.ComboBoxC1Prefix.FormattingEnabled = True
        Me.ComboBoxC1Prefix.Items.AddRange(New Object() {"p", "u"})
        Me.ComboBoxC1Prefix.Location = New System.Drawing.Point(727, 389)
        Me.ComboBoxC1Prefix.Name = "ComboBoxC1Prefix"
        Me.ComboBoxC1Prefix.Size = New System.Drawing.Size(81, 24)
        Me.ComboBoxC1Prefix.TabIndex = 13
        '
        'ComboBoxC1Value
        '
        Me.ComboBoxC1Value.FormattingEnabled = True
        Me.ComboBoxC1Value.Items.AddRange(New Object() {"1", "2.2", "4.7", "10", "22", "47", "100"})
        Me.ComboBoxC1Value.Location = New System.Drawing.Point(637, 389)
        Me.ComboBoxC1Value.Name = "ComboBoxC1Value"
        Me.ComboBoxC1Value.Size = New System.Drawing.Size(79, 24)
        Me.ComboBoxC1Value.TabIndex = 12
        '
        'LabelC1
        '
        Me.LabelC1.AutoSize = True
        Me.LabelC1.Location = New System.Drawing.Point(608, 389)
        Me.LabelC1.Name = "LabelC1"
        Me.LabelC1.Size = New System.Drawing.Size(23, 16)
        Me.LabelC1.TabIndex = 11
        Me.LabelC1.Text = "C1"
        '
        'ComboBoxC2Prefix
        '
        Me.ComboBoxC2Prefix.FormattingEnabled = True
        Me.ComboBoxC2Prefix.Items.AddRange(New Object() {"p", "u"})
        Me.ComboBoxC2Prefix.Location = New System.Drawing.Point(712, 473)
        Me.ComboBoxC2Prefix.Name = "ComboBoxC2Prefix"
        Me.ComboBoxC2Prefix.Size = New System.Drawing.Size(81, 24)
        Me.ComboBoxC2Prefix.TabIndex = 16
        '
        'ComboBoxC2Value
        '
        Me.ComboBoxC2Value.FormattingEnabled = True
        Me.ComboBoxC2Value.Items.AddRange(New Object() {"1", "2.2", "4.7", "10", "22", "47", "100"})
        Me.ComboBoxC2Value.Location = New System.Drawing.Point(622, 475)
        Me.ComboBoxC2Value.Name = "ComboBoxC2Value"
        Me.ComboBoxC2Value.Size = New System.Drawing.Size(79, 24)
        Me.ComboBoxC2Value.TabIndex = 15
        '
        'LabelC2
        '
        Me.LabelC2.AutoSize = True
        Me.LabelC2.Location = New System.Drawing.Point(593, 481)
        Me.LabelC2.Name = "LabelC2"
        Me.LabelC2.Size = New System.Drawing.Size(23, 16)
        Me.LabelC2.TabIndex = 14
        Me.LabelC2.Text = "C2"
        '
        'ComboBoxL1Prefix
        '
        Me.ComboBoxL1Prefix.FormattingEnabled = True
        Me.ComboBoxL1Prefix.Items.AddRange(New Object() {"u", "m"})
        Me.ComboBoxL1Prefix.Location = New System.Drawing.Point(1021, 490)
        Me.ComboBoxL1Prefix.Name = "ComboBoxL1Prefix"
        Me.ComboBoxL1Prefix.Size = New System.Drawing.Size(81, 24)
        Me.ComboBoxL1Prefix.TabIndex = 19
        '
        'ComboBoxL1Value
        '
        Me.ComboBoxL1Value.FormattingEnabled = True
        Me.ComboBoxL1Value.Items.AddRange(New Object() {"1", "2.2", "4.7", "10", "22", "47", "100"})
        Me.ComboBoxL1Value.Location = New System.Drawing.Point(930, 490)
        Me.ComboBoxL1Value.Name = "ComboBoxL1Value"
        Me.ComboBoxL1Value.Size = New System.Drawing.Size(80, 24)
        Me.ComboBoxL1Value.TabIndex = 18
        '
        'LabelL1
        '
        Me.LabelL1.AutoSize = True
        Me.LabelL1.Location = New System.Drawing.Point(902, 490)
        Me.LabelL1.Name = "LabelL1"
        Me.LabelL1.Size = New System.Drawing.Size(21, 16)
        Me.LabelL1.TabIndex = 17
        Me.LabelL1.Text = "L1"
        '
        'LabelRwinding
        '
        Me.LabelRwinding.AutoSize = True
        Me.LabelRwinding.Location = New System.Drawing.Point(902, 545)
        Me.LabelRwinding.Name = "LabelRwinding"
        Me.LabelRwinding.Size = New System.Drawing.Size(144, 16)
        Me.LabelRwinding.TabIndex = 20
        Me.LabelRwinding.Text = "L1 Winding Resistance"
        '
        'TextBoxRwinding
        '
        Me.TextBoxRwinding.Location = New System.Drawing.Point(1052, 545)
        Me.TextBoxRwinding.Name = "TextBoxRwinding"
        Me.TextBoxRwinding.Size = New System.Drawing.Size(50, 22)
        Me.TextBoxRwinding.TabIndex = 21
        Me.TextBoxRwinding.Text = "20"
        '
        'GroupBoxOutputFormat
        '
        Me.GroupBoxOutputFormat.Controls.Add(Me.RadioRectangular)
        Me.GroupBoxOutputFormat.Controls.Add(Me.RadioPolar)
        Me.GroupBoxOutputFormat.Location = New System.Drawing.Point(458, 512)
        Me.GroupBoxOutputFormat.Name = "GroupBoxOutputFormat"
        Me.GroupBoxOutputFormat.Size = New System.Drawing.Size(200, 81)
        Me.GroupBoxOutputFormat.TabIndex = 22
        Me.GroupBoxOutputFormat.TabStop = False
        Me.GroupBoxOutputFormat.Text = "Output Format"
        '
        'RadioRectangular
        '
        Me.RadioRectangular.AutoSize = True
        Me.RadioRectangular.Location = New System.Drawing.Point(6, 21)
        Me.RadioRectangular.Name = "RadioRectangular"
        Me.RadioRectangular.Size = New System.Drawing.Size(144, 20)
        Me.RadioRectangular.TabIndex = 23
        Me.RadioRectangular.TabStop = True
        Me.RadioRectangular.Text = "Rectangular (a + jb)"
        Me.RadioRectangular.UseVisualStyleBackColor = True
        '
        'RadioPolar
        '
        Me.RadioPolar.AutoSize = True
        Me.RadioPolar.Location = New System.Drawing.Point(6, 47)
        Me.RadioPolar.Name = "RadioPolar"
        Me.RadioPolar.Size = New System.Drawing.Size(174, 20)
        Me.RadioPolar.TabIndex = 24
        Me.RadioPolar.TabStop = True
        Me.RadioPolar.Text = "Polar (magnitude, angle)"
        Me.RadioPolar.UseVisualStyleBackColor = True
        '
        'LabelResults
        '
        Me.LabelResults.AutoSize = True
        Me.LabelResults.Location = New System.Drawing.Point(267, 117)
        Me.LabelResults.Name = "LabelResults"
        Me.LabelResults.Size = New System.Drawing.Size(52, 16)
        Me.LabelResults.TabIndex = 25
        Me.LabelResults.Text = "Results"
        '
        'ListBoxResults
        '
        Me.ListBoxResults.FormattingEnabled = True
        Me.ListBoxResults.ItemHeight = 16
        Me.ListBoxResults.Location = New System.Drawing.Point(270, 138)
        Me.ListBoxResults.Name = "ListBoxResults"
        Me.ListBoxResults.Size = New System.Drawing.Size(540, 100)
        Me.ListBoxResults.TabIndex = 26
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Location = New System.Drawing.Point(864, 605)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(111, 56)
        Me.ButtonCalculate.TabIndex = 27
        Me.ButtonCalculate.Text = "Calculate"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(991, 605)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(111, 56)
        Me.ButtonClear.TabIndex = 28
        Me.ButtonClear.Text = "Close"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'CircuitCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CircuitCalculator.My.Resources.Resources.RLC_circuit
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1345, 857)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonCalculate)
        Me.Controls.Add(Me.ListBoxResults)
        Me.Controls.Add(Me.LabelResults)
        Me.Controls.Add(Me.GroupBoxOutputFormat)
        Me.Controls.Add(Me.TextBoxRwinding)
        Me.Controls.Add(Me.LabelRwinding)
        Me.Controls.Add(Me.ComboBoxL1Prefix)
        Me.Controls.Add(Me.ComboBoxL1Value)
        Me.Controls.Add(Me.LabelL1)
        Me.Controls.Add(Me.ComboBoxC2Prefix)
        Me.Controls.Add(Me.ComboBoxC2Value)
        Me.Controls.Add(Me.LabelC2)
        Me.Controls.Add(Me.ComboBoxC1Prefix)
        Me.Controls.Add(Me.ComboBoxC1Value)
        Me.Controls.Add(Me.LabelC1)
        Me.Controls.Add(Me.ComboBoxR1Prefix)
        Me.Controls.Add(Me.ComboBoxR1Value)
        Me.Controls.Add(Me.LabelR1)
        Me.Controls.Add(Me.ComboBoxRgen)
        Me.Controls.Add(Me.LabelRgen)
        Me.Controls.Add(Me.TextBoxFrequency)
        Me.Controls.Add(Me.LabelFrequency)
        Me.Controls.Add(Me.LabelVgenValue)
        Me.Controls.Add(Me.LabelVgen)
        Me.Controls.Add(Me.TrackBarVgen)
        Me.DoubleBuffered = True
        Me.Name = "CircuitCalculator"
        Me.Text = "Calculator"
        CType(Me.TrackBarVgen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxOutputFormat.ResumeLayout(False)
        Me.GroupBoxOutputFormat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TrackBarVgen As TrackBar
    Friend WithEvents LabelVgen As Label
    Friend WithEvents LabelVgenValue As Label
    Friend WithEvents LabelFrequency As Label
    Friend WithEvents TextBoxFrequency As TextBox
    Friend WithEvents LabelRgen As Label
    Friend WithEvents ComboBoxRgen As ComboBox
    Friend WithEvents LabelR1 As Label
    Friend WithEvents ComboBoxR1Value As ComboBox
    Friend WithEvents ComboBoxR1Prefix As ComboBox
    Friend WithEvents ComboBoxC1Prefix As ComboBox
    Friend WithEvents ComboBoxC1Value As ComboBox
    Friend WithEvents LabelC1 As Label
    Friend WithEvents ComboBoxC2Prefix As ComboBox
    Friend WithEvents ComboBoxC2Value As ComboBox
    Friend WithEvents LabelC2 As Label
    Friend WithEvents ComboBoxL1Prefix As ComboBox
    Friend WithEvents ComboBoxL1Value As ComboBox
    Friend WithEvents LabelL1 As Label
    Friend WithEvents LabelRwinding As Label
    Friend WithEvents TextBoxRwinding As TextBox
    Friend WithEvents GroupBoxOutputFormat As GroupBox
    Friend WithEvents RadioRectangular As RadioButton
    Friend WithEvents RadioPolar As RadioButton
    Friend WithEvents LabelResults As Label
    Friend WithEvents ListBoxResults As ListBox
    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents ButtonClear As Button
End Class

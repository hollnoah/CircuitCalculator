'NOAH HOLLOWAY
'RCET 3371
'CIRCUIT CALCULATOR
Imports System.Numerics

Public Class CircuitCalculator
    ' Unicode symbols
    Private Const OhmSymbol As String = ChrW(&H3A9) ' Ω
    Private Const MicroSymbol As String = ChrW(&HB5) ' µ
    Private Const AngleSymbol As String = ChrW(&H2220) ' ∠
    Private Const DegreeSymbol As String = ChrW(&HB0) ' °
    Private Const PiSymbol As String = ChrW(&H3C0) ' π
    Private Const InfinitySymbol As String = ChrW(&H221E) ' ∞

    Private Sub CircuitCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default values
        TrackBarVgen.Value = 50 ' 5.0 Vp
        LabelVgenValue.Text = "5.0 Vp"
        TextBoxFrequency.Text = "1000"
        ComboBoxRgen.SelectedIndex = 0 ' 50 Ω
        ComboBoxR1Value.SelectedItem = "100"
        ComboBoxR1Prefix.SelectedItem = ""
        ComboBoxC1Value.SelectedItem = "1"
        ComboBoxC1Prefix.SelectedItem = MicroSymbol
        ComboBoxC2Value.SelectedItem = "1"
        ComboBoxC2Prefix.SelectedItem = MicroSymbol
        ComboBoxL1Value.SelectedItem = "10"
        ComboBoxL1Prefix.SelectedItem = "m"
        TextBoxRwinding.Text = "20"
        RadioRectangular.Checked = True
        ListBoxResults.Items.Clear()
    End Sub

    Private Sub TrackBarVgen_Scroll(sender As Object, e As EventArgs) Handles TrackBarVgen.Scroll
        LabelVgenValue.Text = (TrackBarVgen.Value / 10.0).ToString("0.0") & " Vp"
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        CircuitCalculator_Load(sender, e)
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Me.Close()
    End Sub

    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        ListBoxResults.Items.Clear()

        ' 1. Parse Inputs
        Dim Vgen As Double = TrackBarVgen.Value / 10.0
        Dim freq As Integer
        If Not Integer.TryParse(TextBoxFrequency.Text, freq) OrElse freq < 1 OrElse freq > 1000000 Then
            MessageBox.Show("Frequency must be an integer between 1 and 1,000,000 Hz.")
            Exit Sub
        End If

        Dim Rgen As Double = If(ComboBoxRgen.SelectedItem.ToString().Contains("50"), 50, 400)
        Dim R1 As Double = GetComponentValue(ComboBoxR1Value, ComboBoxR1Prefix, New String() {"", "k", "M"}, New Double() {1, 1000.0, 1000000.0})
        Dim C1 As Double = GetComponentValue(ComboBoxC1Value, ComboBoxC1Prefix, New String() {"p", MicroSymbol}, New Double() {0.000000000001, 0.000001})
        Dim C2 As Double = GetComponentValue(ComboBoxC2Value, ComboBoxC2Prefix, New String() {"p", MicroSymbol}, New Double() {0.000000000001, 0.000001})
        Dim L1 As Double = GetComponentValue(ComboBoxL1Value, ComboBoxL1Prefix, New String() {MicroSymbol, "m"}, New Double() {0.000001, 0.001})

        Dim Rwinding As Integer
        If Not Integer.TryParse(TextBoxRwinding.Text, Rwinding) OrElse Rwinding < 0 OrElse Rwinding > 1000 Then
            MessageBox.Show("L1 winding resistance must be an integer between 0 and 1000 Ω.")
            Exit Sub
        End If

        ' 2. Calculate Reactances
        Dim omega As Double = 2 * Math.PI * freq
        Dim XC1 As Double = If(C1 > 0, 1 / (omega * C1), Double.PositiveInfinity)
        Dim XC2 As Double = If(C2 > 0, 1 / (omega * C2), Double.PositiveInfinity)
        Dim XL1 As Double = omega * L1

        ' 3. Impedances (Complex)
        Dim ZRgen As New Complex(Rgen, 0)
        Dim ZR1 As New Complex(R1, 0)
        Dim ZC1 As New Complex(0, -XC1)
        Dim ZC2 As New Complex(0, -XC2)
        Dim ZL1 As New Complex(Rwinding, XL1)

        ' Parallel combination of C2 and L1
        Dim ZEQ As Complex = ParallelImpedance(ZC2, ZL1)

        ' Total impedance: Rgen + R1 + ZC1 + ZEQ
        Dim Ztotal As Complex = ZRgen + ZR1 + ZC1 + ZEQ

        ' 4. Source Current
        Dim Igen As Complex = New Complex(Vgen, 0) / Ztotal

        ' 5. Voltages across each component
        Dim VRgen As Complex = Igen * ZRgen
        Dim VR1 As Complex = Igen * ZR1
        Dim VC1 As Complex = Igen * ZC1
        Dim Vpar As Complex = Igen * ZEQ
        ' In parallel branch, current splits:
        Dim IC2 As Complex = Vpar / ZC2
        Dim IL1 As Complex = Vpar / ZL1
        Dim VC2 As Complex = IC2 * ZC2
        Dim VL1 As Complex = IL1 * ZL1

        ' 6. Currents through each component
        Dim IRgen As Complex = Igen
        Dim IR1 As Complex = Igen
        Dim IC1 As Complex = Igen
        ' IC2 and IL1 already calculated

        ' 7. Power calculations
        Dim P As Double = Vgen * Igen.Real ' Real power (W)
        Dim Q As Double = Vgen * Igen.Imaginary ' Reactive power (VAR)
        Dim S As Double = Vgen * Igen.Magnitude ' Apparent power (VA)

        ' 8. Output formatting
        Dim formatRectangular As Boolean = RadioRectangular.Checked

        AddResult("Total Impedance (Ztotal)", Ztotal, OhmSymbol, formatRectangular)
        AddResult("Source Current (Igen)", Igen, "A", formatRectangular)
        AddResult("Resistance of R1", R1, OhmSymbol)
        AddResult("Capacitance of C1", C1, "F")
        AddResult("Capacitance of C2", C2, "F")
        AddResult("Inductance of L1", L1, "H")
        AddResult("Reactance of C1 (XC1)", XC1, OhmSymbol)
        AddResult("Reactance of C2 (XC2)", XC2, OhmSymbol)
        AddResult("Reactance of L1 (XL1)", XL1, OhmSymbol)
        AddResult("Impedance of L1 (ZL1)", ZL1, OhmSymbol, formatRectangular)
        AddResult("Impedance of parallel C2 & L1 (ZEQ)", ZEQ, OhmSymbol, formatRectangular)
        AddResult("Voltage across Rgen (VRgen)", VRgen, "V", formatRectangular)
        AddResult("Voltage across R1 (VR1)", VR1, "V", formatRectangular)
        AddResult("Voltage across C1 (VC1)", VC1, "V", formatRectangular)
        AddResult("Voltage across C2 (VC2)", VC2, "V", formatRectangular)
        AddResult("Voltage across L1 (VL1)", VL1, "V", formatRectangular)
        AddResult("Current through Rgen (IRgen)", IRgen, "A", formatRectangular)
        AddResult("Current through R1 (IR1)", IR1, "A", formatRectangular)
        AddResult("Current through C1 (IC1)", IC1, "A", formatRectangular)
        AddResult("Current through C2 (IC2)", IC2, "A", formatRectangular)
        AddResult("Current through L1 (IL1)", IL1, "A", formatRectangular)
        AddResult("Real Power (P)", P, "W")
        AddResult("Reactive Power (Q)", Q, "VAR")
        AddResult("Apparent Power (S)", S, "VA")
    End Sub

    ' Helper: Get component value from value/prefix combo boxes
    Private Function GetComponentValue(valueBox As ComboBox, prefixBox As ComboBox, prefixes() As String, factors() As Double) As Double
        Dim val As Double = 0
        If valueBox.SelectedItem IsNot Nothing Then
            Double.TryParse(valueBox.SelectedItem.ToString(), val)
        End If
        Dim factor As Double = 1
        If prefixBox.SelectedItem IsNot Nothing Then
            Dim prefix As String = prefixBox.SelectedItem.ToString()
            ' Accept both "u" and micro symbol for micro
            If prefix = "u" Then prefix = MicroSymbol
            Dim idx As Integer = Array.IndexOf(prefixes, prefix)
            If idx >= 0 Then factor = factors(idx)
        End If
        Return val * factor
    End Function

    ' Helper: Parallel impedance
    Private Function ParallelImpedance(z1 As Complex, z2 As Complex) As Complex
        If z1.Real = 0 AndAlso z1.Imaginary = 0 Then Return z2
        If z2.Real = 0 AndAlso z2.Imaginary = 0 Then Return z1
        Return (z1 * z2) / (z1 + z2)
    End Function

    ' Engineering notation (from your reference, modified for 6 significant figures)
    Private Function ToEngineeringNotation(value As Decimal, Optional unit As String = "") As String
        Dim prefixes() As String = {"p", "n", MicroSymbol, "m", "", "k", "M", "G", "T"}
        Dim exponent As Integer = 0

        If value = 0 Then
            Return "0 " & unit
        End If

        exponent = CInt(Math.Floor(Math.Log10(Math.Abs(CDbl(value))) / 3) * 3)
        Dim scaledValue As Decimal = value / (10D ^ exponent)
        Dim prefixIndex As Integer = exponent \ 3 + 4
        If prefixIndex < 0 Or prefixIndex >= prefixes.Length Then
            Return value.ToString("E6") & " " & unit
        End If

        Return scaledValue.ToString("0.#####") & " " & prefixes(prefixIndex) & unit
    End Function

    ' Output formatting for ListBox
    Private Sub AddResult(label As String, value As Object, unit As String, Optional showComplex As Boolean = False)
        Dim output As String = ""
        If value.GetType() = GetType(Complex) Then
            Dim c As Complex = CType(value, Complex)
            If unit = "A" OrElse unit = "V" Then
                ' Show magnitude in engineering notation, and phase if polar
                If showComplex Then
                    output = $"{label,-35} {ToEngineeringNotation(Convert.ToDecimal(c.Real), unit),20} + j{ToEngineeringNotation(Convert.ToDecimal(c.Imaginary), unit),20}"
                Else
                    output = $"{label,-35} {ToEngineeringNotation(Convert.ToDecimal(c.Magnitude), unit),20} {AngleSymbol} {c.Phase * 180 / Math.PI,8:0.#####}{DegreeSymbol}"
                End If
            Else
                If showComplex Then
                    output = $"{label,-35} {c.Real,12:0.#####} + j{c.Imaginary,12:0.#####} {unit}"
                Else
                    output = $"{label,-35} {c.Magnitude,12:0.#####} {unit} {AngleSymbol} {c.Phase * 180 / Math.PI,8:0.#####}{DegreeSymbol}"
                End If
            End If
        ElseIf value.GetType() = GetType(Double) OrElse value.GetType() = GetType(Decimal) Then
            output = $"{label,-35} {ToEngineeringNotation(Convert.ToDecimal(value), unit),20}"
        Else
            output = $"{label,-35} {value.ToString(),20}"
        End If
        ListBoxResults.Items.Add(output)
    End Sub
End Class

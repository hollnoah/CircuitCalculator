Public Structure Complex
    Public Real As Double
    Public Imaginary As Double

    Public Sub New(real As Double, imaginary As Double)
        Me.Real = real
        Me.Imaginary = imaginary
    End Sub

    Public ReadOnly Property Magnitude As Double
        Get
            Return Math.Sqrt(Real * Real + Imaginary * Imaginary)
        End Get
    End Property

    Public ReadOnly Property Phase As Double
        Get
            Return Math.Atan2(Imaginary, Real)
        End Get
    End Property

    Public Shared Operator +(a As Complex, b As Complex) As Complex
        Return New Complex(a.Real + b.Real, a.Imaginary + b.Imaginary)
    End Operator

    Public Shared Operator -(a As Complex, b As Complex) As Complex
        Return New Complex(a.Real - b.Real, a.Imaginary - b.Imaginary)
    End Operator

    Public Shared Operator *(a As Complex, b As Complex) As Complex
        Return New Complex(a.Real * b.Real - a.Imaginary * b.Imaginary,
                           a.Real * b.Imaginary + a.Imaginary * b.Real)
    End Operator

    Public Shared Operator /(a As Complex, b As Complex) As Complex
        Dim denom = b.Real * b.Real + b.Imaginary * b.Imaginary
        Return New Complex((a.Real * b.Real + a.Imaginary * b.Imaginary) / denom,
                           (a.Imaginary * b.Real - a.Real * b.Imaginary) / denom)
    End Operator

    Public Shared ReadOnly Property Zero As Complex
        Get
            Return New Complex(0, 0)
        End Get
    End Property
End Structure
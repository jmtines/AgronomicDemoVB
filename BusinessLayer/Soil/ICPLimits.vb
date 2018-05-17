Public Class SoilIcpLimits
  Private Property _Element As String
  Public Property ErrorLowerLimit As Double
  Public Property ErrorUpperLimit As Double
  Public Property WarningLowerLimit As Double
  Public Property WarningUpperLimit As Double
  Public Property Mean As Double
  Public Property Units As String

  Public ReadOnly Property Element As String
    Get
      Return _Element
    End Get
  End Property
  Public Sub New(ByVal element As String)
    If String.IsNullOrEmpty(element).Equals(False) Then
      _Element = element
    Else
      Throw New ArgumentNullException("element")
    End If
  End Sub
End Class
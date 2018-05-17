Public Class ICPSampleResult
  Implements IICPSampleResult
  Private _BatchID As Integer
  Private _SampleID As Integer
  Private _Elements As List(Of ICPElement)

  Public Property Check As String Implements IICPSampleResult.Check
  Public Property Position As String = "" Implements IICPSampleResult.Position
  Public Property LabNumber As String Implements IICPSampleResult.LabNumber
  Public Property Confirmed As Boolean = False Implements IICPSampleResult.Confirmed
  Public Property HasDuplicateSampleInDatabase As Boolean Implements IICPSampleResult.HasDuplicateSampleInDatabase
  Public Property IsRecheck As Boolean Implements IICPSampleResult.IsRecheck
  Public Property SampleType As SoilIcpSampleTypeEnum Implements IICPSampleResult.SampleType

  Public ReadOnly Property Elements As IEnumerable(Of ICPElement) Implements IICPSampleResult.Elements
    Get
      Return _Elements
    End Get
  End Property

  Public Property SampleID As Integer Implements IICPSampleResult.SampleID
    Get
      Return _SampleID
    End Get
    Set(value As Integer)
      If value.Equals(0) Then
        _SampleID = -1
      Else
        _SampleID = value
      End If
    End Set
  End Property

  Public Property BatchID As Integer Implements IICPSampleResult.BatchID
    Get
      Return _BatchID
    End Get
    Set(value As Integer)
      If value = Nothing OrElse value.Equals(0) Then
        _BatchID = -1
      Else
        _BatchID = value
      End If
    End Set
  End Property

  Public Sub New()
    _Elements = New List(Of ICPElement)
  End Sub

  Public Sub AddElement(ByVal element As ICPElement) Implements IICPSampleResult.AddElement
    If element IsNot Nothing Then
      _Elements.Add(element)
    Else
      Throw New ArgumentNullException("element")
    End If
  End Sub
End Class
Imports SharedLayer

Public Class SoilIcpSampleTypeFromLabNumber

  Private ReadOnly LabNumber As String
  Private ReadOnly ControlSampleNames As New List(Of String)(New String() {
    "Standard 1", "Standard 2", "Standard 3", "Low S", "Blank", "Std_1", "Std_2", "High HM", "Low HM"})

  Public Sub New(ByVal labNumber As String)
    If String.IsNullOrEmpty(labNumber) Then
      Throw New ArgumentNullException("labNumber")
    End If
    Me.LabNumber = labNumber
  End Sub

  Public Function GetSampleType() As SoilIcpSampleTypeEnum
    Dim sampleType As SoilIcpSampleTypeEnum
    Select Case True
      Case IsSampleTypeCcv()
        sampleType = SoilIcpSampleTypeEnum.CcvSample
      Case IsSampleTypeLabTest()
        sampleType = SoilIcpSampleTypeEnum.LabTestSample
      Case IsSampleTypeControlSample()
        sampleType = SoilIcpSampleTypeEnum.ControlSample
      Case IsSampleTypeCheckSample()
        sampleType = SoilIcpSampleTypeEnum.CheckSample
    End Select
    Return sampleType
  End Function

  Private Function IsSampleTypeCcv() As Boolean
    Return LabNumber.Contains("CCV")
  End Function

  Private Function IsSampleTypeLabTest() As Boolean
    Return If(Helper.LabNumberIsValidFormat(LabNumber) _
      AndAlso LabNumber.Equals(Helper.LabNumberValidFormater(LabNumber), StringComparison.CurrentCultureIgnoreCase),
      True,
      False)
  End Function

  Private Function IsSampleTypeCheckSample() As Boolean
    Return Not String.IsNullOrEmpty(LabNumber)
  End Function

  Private Function IsSampleTypeControlSample() As Boolean
    Return ControlSampleNames.Where(Function(x) x.Equals(LabNumber, StringComparison.CurrentCultureIgnoreCase)).Any
  End Function
End Class

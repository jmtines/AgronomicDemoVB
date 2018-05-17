Option Strict Off
Option Explicit On
Option Infer On
Public MustInherit Class CreateSampleResult(Of t)
  Protected ReadOnly Property _ArcosSample As t
  Public ReadOnly Property SampleResult As IICPSampleResult

  Protected Sub New(ByVal sample As t)
    If sample IsNot Nothing Then
      SampleResult = New ICPSampleResult
      _ArcosSample = sample
      GetLabNumberFromResults()
      SampleResult.SampleType = New SoilIcpSampleTypeFromLabNumber(SampleResult.LabNumber).GetSampleType()
      GetCheckName()
      AddICPElements()
    Else
      Throw New ArgumentNullException("sample")
    End If
  End Sub

  Protected MustOverride Sub GetLabNumberFromResults()

  Protected Sub ConvertPPT_To_PPM(ByRef element As ICPElement)
    If element.Units = "ppt" AndAlso IsNumeric(element.Measurement) Then
      element.Measurement = element.Measurement / 1000000
      element.Units = "ppm"
    End If
  End Sub

  Protected Sub GetCheckName()
    SampleResult.Check = If(IsControl(SampleResult.SampleType).Equals(True), SampleResult.LabNumber, String.Empty)
  End Sub

  Protected Function IsControl(ByVal sampleType As SoilIcpSampleTypeEnum) As Boolean
    Return sampleType.Equals(SoilIcpSampleTypeEnum.ControlSample)
  End Function

  Protected MustOverride Sub AddICPElements()
End Class

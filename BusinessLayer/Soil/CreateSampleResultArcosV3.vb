Public Class CreateSampleResultArcosV3 : Inherits CreateSampleResult(Of ArcosV3.SampleResults)
  Public Sub New(ByVal sample As ArcosV3.SampleResults)
    MyBase.New(sample)
  End Sub

  Protected Overrides Sub GetLabNumberFromResults()
    Dim labNumber As String = _ArcosSample?.SampleResult?.SampleIDs?.Where(Function(x) x.IDName.Equals("Sample ID#")).Select(Function(y) y.IDValue).FirstOrDefault
    If String.IsNullOrEmpty(labNumber).Equals(False) Then
      SampleResult.LabNumber = labNumber
    Else
      Throw New ArgumentNullException("_ArcosSample.SampleResult.SampleIDs.Where(Function(x) x.IDName.Equals('Sample ID#')).Select(Function(y) y.IDValue).FirstOrDefault")
    End If
  End Sub

  Protected Overrides Sub AddICPElements()
    Dim MeasurementResultValues = _ArcosSample.SampleResult.MeasurementReplicates.MeasurementReplicate.Measurement.Elements
    If MeasurementResultValues IsNot Nothing Then
      For Each element As ArcosV3.SampleResultsSampleResultMeasurementReplicatesMeasurementReplicateMeasurementElement In MeasurementResultValues
        Dim SampleElement As ICPElement = New ICPElement
        Dim resultResultValue = element.ElementResult.ResultValue
        SampleElement.Label = element.ElementName
        SampleElement.Measurement = resultResultValue
        SampleElement.Units = element.ElementResult.Unit
        ConvertPPT_To_PPM(SampleElement)
        SampleResult.AddElement(SampleElement)
      Next
    Else
      Throw New NullReferenceException("_ArcosSample.SampleResult.FirstOrDefault.Measurements.FirstOrDefault.Measurement.FirstOrDefault.ResultValues")
    End If
  End Sub
End Class
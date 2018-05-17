Public Class CreateSampleResultArcosV2 : Inherits CreateSampleResult(Of Arcos.SampleResults)
  Public Sub New(ByVal sample As Arcos.SampleResults)
    MyBase.New(sample)
  End Sub

  Protected Overrides Sub GetLabNumberFromResults()
    Dim sampleIDs = _ArcosSample?.SampleResult?.SelectMany(Function(x) x.SampleIDs).SelectMany(Function(y) y.SampleID)
    Dim labNumber As String = sampleIDs.Where(Function(z) z.Type = "Text").Select(Function(num) num.IDValue).FirstOrDefault

    If String.IsNullOrEmpty(labNumber).Equals(False) Then
      SampleResult.LabNumber = labNumber
    Else
      Throw New ArgumentNullException("_ArcosSample.SampleResult.FirstOrDefault.SampleIDs.FirstOrDefault.SampleID.FirstOrDefault.IDValue")
    End If
  End Sub

  Protected Overrides Sub AddICPElements()
    Dim controlSampleFlags = New With {Key .resultsType = "Line", Key .valueType = "BgCorrInt"}
    Dim sampleFlags = New With {Key .resultsType = "Element", Key .valueType = "Conc"}

    If SampleResult.SampleType.Equals(SoilIcpSampleTypeEnum.ControlSample) Then
      AddTestsResultsBySampleType(controlSampleFlags.resultsType, controlSampleFlags.valueType)
    Else
      AddTestsResultsBySampleType(sampleFlags.resultsType, sampleFlags.valueType)
    End If
  End Sub

  Private Sub AddTestsResultsBySampleType(ByVal resultType As String, ByVal resultResultType As String)
    Dim MeasurementResultValues As IEnumerable(Of Arcos.MeasurementResultValues) = _ArcosSample?.SampleResult?.FirstOrDefault?.Measurements?.FirstOrDefault.Measurement.FirstOrDefault.ResultValues
    If MeasurementResultValues IsNot Nothing Then
      For Each resultValues As Arcos.MeasurementResultValues In MeasurementResultValues.Where(Function(x) x.Type = resultType).Select(Function(y) y)

        Dim resultValue As Arcos.MeasurementResultValuesResultValue = resultValues?.ResultValue.Where(Function(x) x.Type = resultResultType).FirstOrDefault
        If resultValue IsNot Nothing Then
          Dim SampleElement As ICPElement = New ICPElement With {
          .Label = resultValues.IDName
          }

          If Double.TryParse(resultValue.Value, SampleElement.Measurement) Then
            SampleElement.Units = resultValue.Unit
          Else
            SampleElement.Units = String.Empty
          End If

          ConvertPPT_To_PPM(SampleElement)
          RemoveInvalidCharactersFromElementName(SampleElement.Label)
          SampleResult.AddElement(SampleElement)
        End If
      Next
    Else
      Throw New NullReferenceException("_ArcosSample.SampleResult.FirstOrDefault.Measurements.FirstOrDefault.Measurement.FirstOrDefault.ResultValues")
    End If
  End Sub

  Private Sub RemoveInvalidCharactersFromElementName(ByRef element As String)
    If element.Length > 2 Then
      element = element.Substring(0, 2).Trim
    End If
  End Sub
End Class
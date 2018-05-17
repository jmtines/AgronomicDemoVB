Public Class ICPArcosSampleResultFactory
  Public ReadOnly Property SampleResult As ICPSampleResult

  Public Sub New(ByVal file As String)
    Dim arcosSerializer As Xml.Serialization.XmlSerializer
    Dim arcosV2Samples As Arcos.SampleResults
    Try
      Using myStreamReader As New IO.StreamReader(file)
        arcosSerializer = New Xml.Serialization.XmlSerializer(GetType(Arcos.SampleResults))
        arcosV2Samples = DirectCast(arcosSerializer.Deserialize(myStreamReader), Arcos.SampleResults)
        If (arcosV2Samples.XMLVersion.Equals("6")) Then
          SampleResult = New CreateSampleResultArcosV2(arcosV2Samples).SampleResult
        ElseIf (arcosV2Samples.XMLVersion.Equals("7.2")) Then
          Dim arcosV3Samples As New ArcosV3.SampleResults
          arcosSerializer = New Xml.Serialization.XmlSerializer(GetType(ArcosV3.SampleResults))
          arcosV3Samples = DirectCast(arcosSerializer.Deserialize(myStreamReader), ArcosV3.SampleResults)
          SampleResult = New CreateSampleResultArcosV3(arcosV3Samples).SampleResult
        Else
          Throw New NotImplementedException("Not Supported XML Version")
        End If
        myStreamReader.Close()
      End Using
    Catch ex As Exception
      Console.WriteLine($"Error Handling Not Implemented Currently. {ex.Message}")
    End Try
  End Sub
End Class

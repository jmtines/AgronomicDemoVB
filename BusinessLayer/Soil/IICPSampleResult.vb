Imports AgronomicDemo

Public Interface IICPSampleResult
  Property BatchID As Integer
  Property Check As String
  Property Confirmed As Boolean
  ReadOnly Property Elements As IEnumerable(Of ICPElement)
  Property HasDuplicateSampleInDatabase As Boolean
  Property IsRecheck As Boolean
  Property LabNumber As String
  Property Position As String
  Property SampleID As Integer
  Property SampleType As SoilIcpSampleTypeEnum
  Sub AddElement(element As ICPElement)
End Interface

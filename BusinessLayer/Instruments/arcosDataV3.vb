
'// NOTE: Generated code may require at least .NET Framework 4.5 Or .NET Core/Standard 2.0.
Namespace ArcosV3

  '''<remarks/>
  '''
  <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
 System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
  Partial Public Class SampleResults

    Private sampleResultField As SampleResultsSampleResult

    Private xMLVersionField As Decimal

    Private xMLCreationDateTimeField As Date

    '''<remarks/>
    Public Property SampleResult() As SampleResultsSampleResult
      Get
        Return Me.sampleResultField
      End Get
      Set
        Me.sampleResultField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property XMLVersion() As Decimal
      Get
        Return Me.xMLVersionField
      End Get
      Set
        Me.xMLVersionField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property XMLCreationDateTime() As Date
      Get
        Return Me.xMLCreationDateTimeField
      End Get
      Set
        Me.xMLCreationDateTimeField = Value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
  Partial Public Class SampleResultsSampleResult

    Private sampleIDsField() As SampleResultsSampleResultSampleID

    Private measurementReplicatesField As SampleResultsSampleResultMeasurementReplicates

    Private measurementStatisticsField As SampleResultsSampleResultMeasurementStatistics

    Private nameField As String

    Private operatorNameField As String

    Private typeField As String

    Private corrTypeField As String

    Private originField As String

    Private backupStatusField As String

    Private methodNameField As String

    Private methodVersionField As String

    Private instrumentField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlArrayItemAttribute("SampleID", IsNullable:=False)>
    Public Property SampleIDs() As SampleResultsSampleResultSampleID()
      Get
        Return Me.sampleIDsField
      End Get
      Set
        Me.sampleIDsField = Value
      End Set
    End Property

    '''<remarks/>
    Public Property MeasurementReplicates() As SampleResultsSampleResultMeasurementReplicates
      Get
        Return Me.measurementReplicatesField
      End Get
      Set
        Me.measurementReplicatesField = Value
      End Set
    End Property

    '''<remarks/>
    Public Property MeasurementStatistics() As SampleResultsSampleResultMeasurementStatistics
      Get
        Return Me.measurementStatisticsField
      End Get
      Set
        Me.measurementStatisticsField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Name() As String
      Get
        Return Me.nameField
      End Get
      Set
        Me.nameField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property OperatorName() As String
      Get
        Return Me.operatorNameField
      End Get
      Set
        Me.operatorNameField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Type() As String
      Get
        Return Me.typeField
      End Get
      Set
        Me.typeField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property CorrType() As String
      Get
        Return Me.corrTypeField
      End Get
      Set
        Me.corrTypeField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Origin() As String
      Get
        Return Me.originField
      End Get
      Set
        Me.originField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property BackupStatus() As String
      Get
        Return Me.backupStatusField
      End Get
      Set
        Me.backupStatusField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property MethodName() As String
      Get
        Return Me.methodNameField
      End Get
      Set
        Me.methodNameField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property MethodVersion() As String
      Get
        Return Me.methodVersionField
      End Get
      Set
        Me.methodVersionField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Instrument() As String
      Get
        Return Me.instrumentField
      End Get
      Set
        Me.instrumentField = Value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
  Partial Public Class SampleResultsSampleResultSampleID

    Private iDNameField As String

    Private iDValueField As String

    Private typeField As String

    Private isSampleNameField As String

    '''<remarks/>
    Public Property IDName() As String
      Get
        Return Me.iDNameField
      End Get
      Set
        Me.iDNameField = Value
      End Set
    End Property

    '''<remarks/>
    Public Property IDValue() As String
      Get
        Return Me.iDValueField
      End Get
      Set
        Me.iDValueField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Type() As String
      Get
        Return Me.typeField
      End Get
      Set
        Me.typeField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property IsSampleName() As String
      Get
        Return Me.isSampleNameField
      End Get
      Set
        Me.isSampleNameField = Value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
  Partial Public Class SampleResultsSampleResultMeasurementReplicates

    Private measurementReplicateField As SampleResultsSampleResultMeasurementReplicatesMeasurementReplicate

    Private countField As Byte

    '''<remarks/>
    Public Property MeasurementReplicate() As SampleResultsSampleResultMeasurementReplicatesMeasurementReplicate
      Get
        Return Me.measurementReplicateField
      End Get
      Set
        Me.measurementReplicateField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Count() As Byte
      Get
        Return Me.countField
      End Get
      Set
        Me.countField = Value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
  Partial Public Class SampleResultsSampleResultMeasurementReplicatesMeasurementReplicate

    Private measurementField As SampleResultsSampleResultMeasurementReplicatesMeasurementReplicateMeasurement

    Private noField As Byte

    Private isDeletedField As String

    Private measureDateTimeField As Date

    '''<remarks/>
    Public Property Measurement() As SampleResultsSampleResultMeasurementReplicatesMeasurementReplicateMeasurement
      Get
        Return Me.measurementField
      End Get
      Set
        Me.measurementField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property No() As Byte
      Get
        Return Me.noField
      End Get
      Set
        Me.noField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property IsDeleted() As String
      Get
        Return Me.isDeletedField
      End Get
      Set
        Me.isDeletedField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property MeasureDateTime() As Date
      Get
        Return Me.measureDateTimeField
      End Get
      Set
        Me.measureDateTimeField = Value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
  Partial Public Class SampleResultsSampleResultMeasurementReplicatesMeasurementReplicateMeasurement

    Private linesField() As SampleResultsSampleResultMeasurementReplicatesMeasurementReplicateMeasurementLine

    Private elementsField() As SampleResultsSampleResultMeasurementReplicatesMeasurementReplicateMeasurementElement

    Private checkTypeField As String

    Private rsdCheckField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlArrayItemAttribute("Line", IsNullable:=False)>
    Public Property Lines() As SampleResultsSampleResultMeasurementReplicatesMeasurementReplicateMeasurementLine()
      Get
        Return Me.linesField
      End Get
      Set
        Me.linesField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlArrayItemAttribute("Element", IsNullable:=False)>
    Public Property Elements() As SampleResultsSampleResultMeasurementReplicatesMeasurementReplicateMeasurementElement()
      Get
        Return Me.elementsField
      End Get
      Set
        Me.elementsField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property CheckType() As String
      Get
        Return Me.checkTypeField
      End Get
      Set
        Me.checkTypeField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property RsdCheck() As String
      Get
        Return Me.rsdCheckField
      End Get
      Set
        Me.rsdCheckField = Value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
  Partial Public Class SampleResultsSampleResultMeasurementReplicatesMeasurementReplicateMeasurementLine

    Private lineResultField() As SampleResultsSampleResultMeasurementReplicatesMeasurementReplicateMeasurementLineLineResult

    Private lineNameField As String

    Private typeField As String

    Private calibrationValueTypeField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute("LineResult")>
    Public Property LineResult() As SampleResultsSampleResultMeasurementReplicatesMeasurementReplicateMeasurementLineLineResult()
      Get
        Return Me.lineResultField
      End Get
      Set
        Me.lineResultField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property LineName() As String
      Get
        Return Me.lineNameField
      End Get
      Set
        Me.lineNameField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Type() As String
      Get
        Return Me.typeField
      End Get
      Set
        Me.typeField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property CalibrationValueType() As String
      Get
        Return Me.calibrationValueTypeField
      End Get
      Set
        Me.calibrationValueTypeField = Value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
  Partial Public Class SampleResultsSampleResultMeasurementReplicatesMeasurementReplicateMeasurementLineLineResult

    Private resultValueField As Double

    Private resultValueLimitsField As Object

    Private typeField As String

    Private kindField As String

    Private unitField As String

    Private displayUnitField As String

    Private isDeletedField As String

    Private statTypeField As String

    Private statusField As String

    Private extStatusField As String

    Private calibrationStatusField As String

    Private acceptanceStatusField As String

    Private warningStatusField As String

    '''<remarks/>
    Public Property ResultValue() As Double
      Get
        Return Me.resultValueField
      End Get
      Set
        Me.resultValueField = Value
      End Set
    End Property

    '''<remarks/>
    Public Property ResultValueLimits() As Object
      Get
        Return Me.resultValueLimitsField
      End Get
      Set
        Me.resultValueLimitsField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Type() As String
      Get
        Return Me.typeField
      End Get
      Set
        Me.typeField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Kind() As String
      Get
        Return Me.kindField
      End Get
      Set
        Me.kindField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Unit() As String
      Get
        Return Me.unitField
      End Get
      Set
        Me.unitField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property DisplayUnit() As String
      Get
        Return Me.displayUnitField
      End Get
      Set
        Me.displayUnitField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property IsDeleted() As String
      Get
        Return Me.isDeletedField
      End Get
      Set
        Me.isDeletedField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property StatType() As String
      Get
        Return Me.statTypeField
      End Get
      Set
        Me.statTypeField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Status() As String
      Get
        Return Me.statusField
      End Get
      Set
        Me.statusField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property ExtStatus() As String
      Get
        Return Me.extStatusField
      End Get
      Set
        Me.extStatusField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property CalibrationStatus() As String
      Get
        Return Me.calibrationStatusField
      End Get
      Set
        Me.calibrationStatusField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property AcceptanceStatus() As String
      Get
        Return Me.acceptanceStatusField
      End Get
      Set
        Me.acceptanceStatusField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property WarningStatus() As String
      Get
        Return Me.warningStatusField
      End Get
      Set
        Me.warningStatusField = Value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
  Partial Public Class SampleResultsSampleResultMeasurementReplicatesMeasurementReplicateMeasurementElement

    Private lineNamesField() As String

    Private elementResultField As SampleResultsSampleResultMeasurementReplicatesMeasurementReplicateMeasurementElementElementResult

    Private elementNameField As String

    Private typeField As String

    Private selectedLineNameField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlArrayItemAttribute("LineName", IsNullable:=False)>
    Public Property LineNames() As String()
      Get
        Return Me.lineNamesField
      End Get
      Set
        Me.lineNamesField = Value
      End Set
    End Property

    '''<remarks/>
    Public Property ElementResult() As SampleResultsSampleResultMeasurementReplicatesMeasurementReplicateMeasurementElementElementResult
      Get
        Return Me.elementResultField
      End Get
      Set
        Me.elementResultField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property ElementName() As String
      Get
        Return Me.elementNameField
      End Get
      Set
        Me.elementNameField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Type() As String
      Get
        Return Me.typeField
      End Get
      Set
        Me.typeField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property SelectedLineName() As String
      Get
        Return Me.selectedLineNameField
      End Get
      Set
        Me.selectedLineNameField = Value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
  Partial Public Class SampleResultsSampleResultMeasurementReplicatesMeasurementReplicateMeasurementElementElementResult

    Private resultValueField As Double

    Private resultValueLimitsField As Object

    Private typeField As String

    Private kindField As String

    Private unitField As String

    Private displayUnitField As String

    Private isDeletedField As String

    Private statTypeField As String

    Private statusField As String

    Private extStatusField As String

    Private calibrationStatusField As String

    Private acceptanceStatusField As String

    Private warningStatusField As String

    '''<remarks/>
    Public Property ResultValue() As Double
      Get
        Return Me.resultValueField
      End Get
      Set
        Me.resultValueField = Value
      End Set
    End Property

    '''<remarks/>
    Public Property ResultValueLimits() As Object
      Get
        Return Me.resultValueLimitsField
      End Get
      Set
        Me.resultValueLimitsField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Type() As String
      Get
        Return Me.typeField
      End Get
      Set
        Me.typeField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Kind() As String
      Get
        Return Me.kindField
      End Get
      Set
        Me.kindField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Unit() As String
      Get
        Return Me.unitField
      End Get
      Set
        Me.unitField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property DisplayUnit() As String
      Get
        Return Me.displayUnitField
      End Get
      Set
        Me.displayUnitField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property IsDeleted() As String
      Get
        Return Me.isDeletedField
      End Get
      Set
        Me.isDeletedField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property StatType() As String
      Get
        Return Me.statTypeField
      End Get
      Set
        Me.statTypeField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Status() As String
      Get
        Return Me.statusField
      End Get
      Set
        Me.statusField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property ExtStatus() As String
      Get
        Return Me.extStatusField
      End Get
      Set
        Me.extStatusField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property CalibrationStatus() As String
      Get
        Return Me.calibrationStatusField
      End Get
      Set
        Me.calibrationStatusField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property AcceptanceStatus() As String
      Get
        Return Me.acceptanceStatusField
      End Get
      Set
        Me.acceptanceStatusField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property WarningStatus() As String
      Get
        Return Me.warningStatusField
      End Get
      Set
        Me.warningStatusField = Value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
  Partial Public Class SampleResultsSampleResultMeasurementStatistics

    Private measurementField As SampleResultsSampleResultMeasurementStatisticsMeasurement

    '''<remarks/>
    Public Property Measurement() As SampleResultsSampleResultMeasurementStatisticsMeasurement
      Get
        Return Me.measurementField
      End Get
      Set
        Me.measurementField = Value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
  Partial Public Class SampleResultsSampleResultMeasurementStatisticsMeasurement

    Private linesField() As SampleResultsSampleResultMeasurementStatisticsMeasurementLine

    Private elementsField() As SampleResultsSampleResultMeasurementStatisticsMeasurementElement

    Private checkTypeField As String

    Private checkStatusField As String

    Private rsdCheckField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlArrayItemAttribute("Line", IsNullable:=False)>
    Public Property Lines() As SampleResultsSampleResultMeasurementStatisticsMeasurementLine()
      Get
        Return Me.linesField
      End Get
      Set
        Me.linesField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlArrayItemAttribute("Element", IsNullable:=False)>
    Public Property Elements() As SampleResultsSampleResultMeasurementStatisticsMeasurementElement()
      Get
        Return Me.elementsField
      End Get
      Set
        Me.elementsField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property CheckType() As String
      Get
        Return Me.checkTypeField
      End Get
      Set
        Me.checkTypeField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property CheckStatus() As String
      Get
        Return Me.checkStatusField
      End Get
      Set
        Me.checkStatusField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property RsdCheck() As String
      Get
        Return Me.rsdCheckField
      End Get
      Set
        Me.rsdCheckField = Value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
  Partial Public Class SampleResultsSampleResultMeasurementStatisticsMeasurementLine

    Private lineResultField() As SampleResultsSampleResultMeasurementStatisticsMeasurementLineLineResult

    Private lineNameField As String

    Private typeField As String

    Private calibrationValueTypeField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute("LineResult")>
    Public Property LineResult() As SampleResultsSampleResultMeasurementStatisticsMeasurementLineLineResult()
      Get
        Return Me.lineResultField
      End Get
      Set
        Me.lineResultField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property LineName() As String
      Get
        Return Me.lineNameField
      End Get
      Set
        Me.lineNameField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Type() As String
      Get
        Return Me.typeField
      End Get
      Set
        Me.typeField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property CalibrationValueType() As String
      Get
        Return Me.calibrationValueTypeField
      End Get
      Set
        Me.calibrationValueTypeField = Value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
  Partial Public Class SampleResultsSampleResultMeasurementStatisticsMeasurementLineLineResult

    Private resultValueField As Double

    Private resultValueLimitsField As Object

    Private typeField As String

    Private kindField As String

    Private unitField As String

    Private displayUnitField As String

    Private isDeletedField As String

    Private statTypeField As String

    Private statusField As String

    Private extStatusField As String

    Private calibrationStatusField As String

    Private acceptanceStatusField As String

    Private warningStatusField As String

    '''<remarks/>
    Public Property ResultValue() As Double
      Get
        Return Me.resultValueField
      End Get
      Set
        Me.resultValueField = Value
      End Set
    End Property

    '''<remarks/>
    Public Property ResultValueLimits() As Object
      Get
        Return Me.resultValueLimitsField
      End Get
      Set
        Me.resultValueLimitsField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Type() As String
      Get
        Return Me.typeField
      End Get
      Set
        Me.typeField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Kind() As String
      Get
        Return Me.kindField
      End Get
      Set
        Me.kindField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Unit() As String
      Get
        Return Me.unitField
      End Get
      Set
        Me.unitField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property DisplayUnit() As String
      Get
        Return Me.displayUnitField
      End Get
      Set
        Me.displayUnitField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property IsDeleted() As String
      Get
        Return Me.isDeletedField
      End Get
      Set
        Me.isDeletedField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property StatType() As String
      Get
        Return Me.statTypeField
      End Get
      Set
        Me.statTypeField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Status() As String
      Get
        Return Me.statusField
      End Get
      Set
        Me.statusField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property ExtStatus() As String
      Get
        Return Me.extStatusField
      End Get
      Set
        Me.extStatusField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property CalibrationStatus() As String
      Get
        Return Me.calibrationStatusField
      End Get
      Set
        Me.calibrationStatusField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property AcceptanceStatus() As String
      Get
        Return Me.acceptanceStatusField
      End Get
      Set
        Me.acceptanceStatusField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property WarningStatus() As String
      Get
        Return Me.warningStatusField
      End Get
      Set
        Me.warningStatusField = Value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
  Partial Public Class SampleResultsSampleResultMeasurementStatisticsMeasurementElement

    Private lineNamesField() As String

    Private elementResultField() As SampleResultsSampleResultMeasurementStatisticsMeasurementElementElementResult

    Private elementNameField As String

    Private typeField As String

    Private selectedLineNameField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlArrayItemAttribute("LineName", IsNullable:=False)>
    Public Property LineNames() As String()
      Get
        Return Me.lineNamesField
      End Get
      Set
        Me.lineNamesField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute("ElementResult")>
    Public Property ElementResult() As SampleResultsSampleResultMeasurementStatisticsMeasurementElementElementResult()
      Get
        Return Me.elementResultField
      End Get
      Set
        Me.elementResultField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property ElementName() As String
      Get
        Return Me.elementNameField
      End Get
      Set
        Me.elementNameField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Type() As String
      Get
        Return Me.typeField
      End Get
      Set
        Me.typeField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property SelectedLineName() As String
      Get
        Return Me.selectedLineNameField
      End Get
      Set
        Me.selectedLineNameField = Value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
  Partial Public Class SampleResultsSampleResultMeasurementStatisticsMeasurementElementElementResult

    Private resultValueField As Double

    Private resultValueLimitsField() As SampleResultsSampleResultMeasurementStatisticsMeasurementElementElementResultResultValueLimit

    Private typeField As String

    Private kindField As String

    Private unitField As String

    Private displayUnitField As String

    Private isDeletedField As String

    Private statTypeField As String

    Private statusField As String

    Private extStatusField As String

    Private calibrationStatusField As String

    Private acceptanceStatusField As String

    Private warningStatusField As String

    '''<remarks/>
    Public Property ResultValue() As Double
      Get
        Return Me.resultValueField
      End Get
      Set
        Me.resultValueField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlArrayItemAttribute("ResultValueLimit", IsNullable:=False)>
    Public Property ResultValueLimits() As SampleResultsSampleResultMeasurementStatisticsMeasurementElementElementResultResultValueLimit()
      Get
        Return Me.resultValueLimitsField
      End Get
      Set
        Me.resultValueLimitsField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Type() As String
      Get
        Return Me.typeField
      End Get
      Set
        Me.typeField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Kind() As String
      Get
        Return Me.kindField
      End Get
      Set
        Me.kindField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Unit() As String
      Get
        Return Me.unitField
      End Get
      Set
        Me.unitField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property DisplayUnit() As String
      Get
        Return Me.displayUnitField
      End Get
      Set
        Me.displayUnitField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property IsDeleted() As String
      Get
        Return Me.isDeletedField
      End Get
      Set
        Me.isDeletedField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property StatType() As String
      Get
        Return Me.statTypeField
      End Get
      Set
        Me.statTypeField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Status() As String
      Get
        Return Me.statusField
      End Get
      Set
        Me.statusField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property ExtStatus() As String
      Get
        Return Me.extStatusField
      End Get
      Set
        Me.extStatusField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property CalibrationStatus() As String
      Get
        Return Me.calibrationStatusField
      End Get
      Set
        Me.calibrationStatusField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property AcceptanceStatus() As String
      Get
        Return Me.acceptanceStatusField
      End Get
      Set
        Me.acceptanceStatusField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property WarningStatus() As String
      Get
        Return Me.warningStatusField
      End Get
      Set
        Me.warningStatusField = Value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
  Partial Public Class SampleResultsSampleResultMeasurementStatisticsMeasurementElementElementResultResultValueLimit

    Private typeField As String

    Private valueField As Double

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Type() As String
      Get
        Return Me.typeField
      End Get
      Set
        Me.typeField = Value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As Double
      Get
        Return Me.valueField
      End Get
      Set
        Me.valueField = Value
      End Set
    End Property
  End Class

End Namespace
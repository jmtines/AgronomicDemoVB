﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3620
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System.Xml.Serialization

'
'This source code was auto-generated by xsd, Version=2.0.50727.3038.
'
Namespace Arcos

  '''<remarks/>
  <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038"),
   System.SerializableAttribute(),
   System.Diagnostics.DebuggerStepThroughAttribute(),
   System.ComponentModel.DesignerCategoryAttribute("code"),
   System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
   System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
  Partial Public Class Measurement

    Private resultValuesField() As MeasurementResultValues

    Private noField As String

    Private typeField As String

    Private statusField As String

    Private measureDateTimeField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute("ResultValues", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>
    Public Property ResultValues() As MeasurementResultValues()
      Get
        Return Me.resultValuesField
      End Get
      Set(ByVal value As MeasurementResultValues())
        Me.resultValuesField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property No() As String
      Get
        Return Me.noField
      End Get
      Set(ByVal value As String)
        Me.noField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Type() As String
      Get
        Return Me.typeField
      End Get
      Set(ByVal value As String)
        Me.typeField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Status() As String
      Get
        Return Me.statusField
      End Get
      Set(ByVal value As String)
        Me.statusField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property MeasureDateTime() As String
      Get
        Return Me.measureDateTimeField
      End Get
      Set(ByVal value As String)
        Me.measureDateTimeField = value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038"),
   System.SerializableAttribute(),
   System.Diagnostics.DebuggerStepThroughAttribute(),
   System.ComponentModel.DesignerCategoryAttribute("code"),
   System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
  Partial Public Class MeasurementResultValues

    Private resultValueField() As MeasurementResultValuesResultValue

    Private typeField As String

    Private iDNameField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute("ResultValue", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=True)>
    Public Property ResultValue() As MeasurementResultValuesResultValue()
      Get
        Return Me.resultValueField
      End Get
      Set(ByVal value As MeasurementResultValuesResultValue())
        Me.resultValueField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Type() As String
      Get
        Return Me.typeField
      End Get
      Set(ByVal value As String)
        Me.typeField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property IDName() As String
      Get
        Return Me.iDNameField
      End Get
      Set(ByVal value As String)
        Me.iDNameField = value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038"),
   System.SerializableAttribute(),
   System.Diagnostics.DebuggerStepThroughAttribute(),
   System.ComponentModel.DesignerCategoryAttribute("code"),
   System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
  Partial Public Class MeasurementResultValuesResultValue

    Private kindField As String

    Private unitField As String

    Private typeField As String

    Private statTypeField As String

    Private statusField As String

    Private extStatusField As String

    Private calibrationStatusField As String

    Private checkStatusField As String

    Private valueField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Kind() As String
      Get
        Return Me.kindField
      End Get
      Set(ByVal value As String)
        Me.kindField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Unit() As String
      Get
        Return Me.unitField
      End Get
      Set(ByVal value As String)
        Me.unitField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Type() As String
      Get
        Return Me.typeField
      End Get
      Set(ByVal value As String)
        Me.typeField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property StatType() As String
      Get
        Return Me.statTypeField
      End Get
      Set(ByVal value As String)
        Me.statTypeField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Status() As String
      Get
        Return Me.statusField
      End Get
      Set(ByVal value As String)
        Me.statusField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property ExtStatus() As String
      Get
        Return Me.extStatusField
      End Get
      Set(ByVal value As String)
        Me.extStatusField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property CalibrationStatus() As String
      Get
        Return Me.calibrationStatusField
      End Get
      Set(ByVal value As String)
        Me.calibrationStatusField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property CheckStatus() As String
      Get
        Return Me.checkStatusField
      End Get
      Set(ByVal value As String)
        Me.checkStatusField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlTextAttribute()>
    Public Property Value() As String
      Get
        Return Me.valueField
      End Get
      Set(ByVal value As String)
        Me.valueField = value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038"),
   System.SerializableAttribute(),
   System.Diagnostics.DebuggerStepThroughAttribute(),
   System.ComponentModel.DesignerCategoryAttribute("code"),
   System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
   System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
  Partial Public Class SampleResults
    Private mySampleID As String

    Private sampleResultField() As SampleResultsSampleResult

    Private xMLVersionField As String

    Private xMLCreationDataTimeField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute("SampleResult", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>
    Public Property SampleResult() As SampleResultsSampleResult()
      Get
        Return Me.sampleResultField
      End Get
      Set(ByVal value As SampleResultsSampleResult())
        Me.sampleResultField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property XMLVersion() As String
      Get
        Return Me.xMLVersionField
      End Get
      Set(ByVal value As String)
        Me.xMLVersionField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property XMLCreationDataTime() As String
      Get
        Return Me.xMLCreationDataTimeField
      End Get
      Set(ByVal value As String)
        Me.xMLCreationDataTimeField = value
      End Set
    End Property

    'Public Sub AddToDataTable(ByRef aDT As DataTable)
    '  Try

    '    Dim Collst As New List(Of String)
    '    Dim RowLst As New List(Of String)
    '    'Add default columns
    '    Collst.Add("Confirm")
    '    RowLst.Add("True")
    '    Collst.Add("Recheck")
    '    RowLst.Add("False")
    '    Collst.Add("Check")
    '    RowLst.Add("")
    '    Collst.Add("Pos")
    '    If Not Me.SampleResult.First.Name.Contains("QC") Then
    '      Dim intNextPos As Integer = GetMaxPos(aDT) + 1
    '      RowLst.Add(CStr(intNextPos).PadLeft(2, CChar("0")))
    '    Else
    '      RowLst.Add("")
    '    End If
    '    Collst.Add("SampleID")
    '    RowLst.Add("")
    '    Collst.Add("BatchID")
    '    If aDT.Rows.Count > 0 Then
    '      RowLst.Add(aDT.Rows(0).Item("BatchID"))
    '    Else
    '      RowLst.Add(GetNextBatchID)
    '    End If
    '    Collst.Add("Unit")
    '    RowLst.Add("ppm")

    '    DoAddSampleInfo(Collst, RowLst)
    '    GetTestResults(Collst, RowLst)
    '    AddRowToDataTable(aDT, Collst, RowLst)

    '  Catch ex As Exception
    '    ErrorHandling.LogError(ex, , "ArcosData.AddToDataTable")
    '  End Try

    'End Sub

    Private Function GetMaxPos(ByVal aDT As DataTable) As Integer
      Dim intMax As Integer = 0
      If aDT.Columns.Contains("Pos") Then
        For I = 0 To aDT.Rows.Count - 1
          If aDT.Rows(I).Item("Pos") <> "" AndAlso
              CInt(aDT.Rows(I).Item("Pos")) > intMax Then
            intMax = aDT.Rows(I).Item("Pos")
          End If
        Next
      End If
      Return intMax
    End Function

    'Public Sub AddCalToDataTable(ByRef aDT As DataTable)
    '  Try

    '    Dim Collst As New List(Of String)
    '    Dim RowLst As New List(Of String)
    '    'Add default columns
    '    Collst.Add("Confirm")
    '    RowLst.Add("True")
    '    Collst.Add("Recheck")
    '    RowLst.Add("False")
    '    Collst.Add("Check")
    '    RowLst.Add("")
    '    Collst.Add("Pos")
    '    RowLst.Add("")
    '    Collst.Add("SampleID")
    '    RowLst.Add("")
    '    Collst.Add("BatchID")
    '    If aDT.Rows.Count > 0 Then
    '      RowLst.Add(aDT.Rows(0).Item("BatchID"))
    '    Else
    '      RowLst.Add(GetNextBatchID)
    '    End If
    '    Collst.Add("Unit")
    '    RowLst.Add("cps")

    '    DoAddSampleInfo(Collst, RowLst)
    '    If Me.SampleResult.First.Name.Contains("QC") Then
    '      GetTestResults(Collst, RowLst)
    '    Else
    '      GetCalResults(Collst, RowLst)
    '    End If
    '    AddRowToDataTable(aDT, Collst, RowLst)

    '  Catch ex As Exception
    '    ErrorHandling.LogError(ex, , "ArcosData.AddCalToDataTable")
    '  End Try

    'End Sub

    'Private Function GetNextBatchID() As Integer
    '  Dim AppSetting As DataLayer.ApplicationSettings
    '  Dim intResult As Integer = 0
    '  Using db As New AppDataContext
    '    AppSetting = (From AppSett In db.ApplicationSettings
    '                  Where AppSett.Name = "ICPBatch"
    '                  Select AppSett).FirstOrDefault
    '    If Not AppSetting Is Nothing Then
    '      AppSetting.Value = AppSetting.Value + 1
    '      intResult = AppSetting.Value
    '      db.SubmitChanges()
    '    End If
    '    Return intResult
    '  End Using
    'End Function

    Private Sub AddRowToDataTable(ByRef aDT As DataTable, ByVal ColLst As List(Of String), ByVal RowLst As List(Of String))
      If aDT.Columns.Contains("LabNumber") AndAlso aDT.Select("LabNumber= '" & mySampleID & "'").Count > 0 _
              AndAlso Not mySampleID.Contains("CCV") Then
        Exit Sub
      End If

      For I = 0 To ColLst.Count - 1
        If Not aDT.Columns.Contains(ColLst(I)) Then
          If ColLst(I) = "Confirm" Or ColLst(I) = "Recheck" Then
            aDT.Columns.Add(ColLst(I), GetType(Boolean))
          Else
            aDT.Columns.Add(ColLst(I))
          End If
        End If
      Next

      Dim rows As DataRowCollection = aDT.Rows
      Dim newRow As DataRow = rows.Add()
      For I = 0 To RowLst.Count - 1
        newRow.Item(ColLst.Item(I).Trim) = RowLst.Item(I).Trim
      Next


    End Sub

    Private Sub DoAddSampleInfo(ByRef Collst As List(Of String), ByRef RowLst As List(Of String))
      For Each ID As SampleResultsSampleResultSampleIDsSampleID In Me.SampleResult.First.SampleIDs.First.SampleID
        If ID.IDName = "Sample ID#" Then
          mySampleID = ID.IDValue
          Collst.Add("LabNumber")
          RowLst.Add(ID.IDValue)
        Else
          Collst.Add(ID.IDName)
          RowLst.Add(ID.IDValue)
        End If
      Next
    End Sub

    Private Sub GetTestResults(ByRef Collst As List(Of String), ByRef RowLst As List(Of String))
      Try
        For Each rv As MeasurementResultValues In Me.SampleResult.First.Measurements.First.Measurement.First.ResultValues
          If rv.Type = "Element" Then
            Collst.Add(rv.IDName)
            If rv.ResultValue.FirstOrDefault.Unit = "ppt" Then
              Dim aValue As Double = rv.ResultValue.FirstOrDefault.Value / 1000000
              RowLst.Add(aValue)
            Else
              RowLst.Add(rv.ResultValue.FirstOrDefault.ToString)
            End If
          End If
        Next

      Catch ex As Exception
        MsgBox(ex.Message)
      End Try

    End Sub

    Private Sub GetCalResults(ByRef Collst As List(Of String), ByRef RowLst As List(Of String))
      Try
        For Each rvs As MeasurementResultValues In Me.SampleResult.First.Measurements.First.Measurement.First.ResultValues
          If rvs.Type = "Line" Then
            For Each rv As MeasurementResultValuesResultValue In rvs.ResultValue
              If rv.Type = "BgCorrInt" Then
                Dim strName As String = rvs.IDName
                strName = strName.Substring(0, 2).Trim()
                Collst.Add(strName)
                RowLst.Add(rv.Value)
              End If
            Next
          End If
        Next
      Catch ex As Exception
        MsgBox(ex.Message)
      End Try

    End Sub

  End Class

  '''<remarks/>
  <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038"),
   System.SerializableAttribute(),
   System.Diagnostics.DebuggerStepThroughAttribute(),
   System.ComponentModel.DesignerCategoryAttribute("code"),
   System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
  Partial Public Class SampleResultsSampleResult

    Private sampleIDsField() As SampleResultsSampleResultSampleIDs

    Private measurementsField() As SampleResultsSampleResultMeasurements

    Private statisticsField()() As Measurement

    Private ePADataField() As SampleResultsSampleResultEPAData

    Private nameField As String

    Private methodField As String

    Private methodVersionField As String

    Private instrumentField As String

    Private infoField As String

    Private originField As String

    Private typeField As String

    Private backupStatusField As String

    Private rsdCheckField As String

    Private measureDateTimeField As String

    Private recalcuationDateTimeField As String

    Private corrTypeField As String

    Private checkTypeField As String

    Private checkStatusField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute("SampleIDs", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>
    Public Property SampleIDs() As SampleResultsSampleResultSampleIDs()
      Get
        Return Me.sampleIDsField
      End Get
      Set(ByVal value As SampleResultsSampleResultSampleIDs())
        Me.sampleIDsField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute("Measurements", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>
    Public Property Measurements() As SampleResultsSampleResultMeasurements()
      Get
        Return Me.measurementsField
      End Get
      Set(ByVal value As SampleResultsSampleResultMeasurements())
        Me.measurementsField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute("EPAData", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>
    Public Property EPAData() As SampleResultsSampleResultEPAData()
      Get
        Return Me.ePADataField
      End Get
      Set(ByVal value As SampleResultsSampleResultEPAData())
        Me.ePADataField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Name() As String
      Get
        Return Me.nameField
      End Get
      Set(ByVal value As String)
        Me.nameField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Method() As String
      Get
        Return Me.methodField
      End Get
      Set(ByVal value As String)
        Me.methodField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property MethodVersion() As String
      Get
        Return Me.methodVersionField
      End Get
      Set(ByVal value As String)
        Me.methodVersionField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Instrument() As String
      Get
        Return Me.instrumentField
      End Get
      Set(ByVal value As String)
        Me.instrumentField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Info() As String
      Get
        Return Me.infoField
      End Get
      Set(ByVal value As String)
        Me.infoField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Origin() As String
      Get
        Return Me.originField
      End Get
      Set(ByVal value As String)
        Me.originField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Type() As String
      Get
        Return Me.typeField
      End Get
      Set(ByVal value As String)
        Me.typeField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property BackupStatus() As String
      Get
        Return Me.backupStatusField
      End Get
      Set(ByVal value As String)
        Me.backupStatusField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property RsdCheck() As String
      Get
        Return Me.rsdCheckField
      End Get
      Set(ByVal value As String)
        Me.rsdCheckField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property MeasureDateTime() As String
      Get
        Return Me.measureDateTimeField
      End Get
      Set(ByVal value As String)
        Me.measureDateTimeField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property RecalcuationDateTime() As String
      Get
        Return Me.recalcuationDateTimeField
      End Get
      Set(ByVal value As String)
        Me.recalcuationDateTimeField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property CorrType() As String
      Get
        Return Me.corrTypeField
      End Get
      Set(ByVal value As String)
        Me.corrTypeField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property CheckType() As String
      Get
        Return Me.checkTypeField
      End Get
      Set(ByVal value As String)
        Me.checkTypeField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property CheckStatus() As String
      Get
        Return Me.checkStatusField
      End Get
      Set(ByVal value As String)
        Me.checkStatusField = value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038"),
   System.SerializableAttribute(),
   System.Diagnostics.DebuggerStepThroughAttribute(),
   System.ComponentModel.DesignerCategoryAttribute("code"),
   System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
  Partial Public Class SampleResultsSampleResultSampleIDs

    Private sampleIDField() As SampleResultsSampleResultSampleIDsSampleID

    Private totalDilutionField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute("SampleID", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>
    Public Property SampleID() As SampleResultsSampleResultSampleIDsSampleID()
      Get
        Return Me.sampleIDField
      End Get
      Set(ByVal value As SampleResultsSampleResultSampleIDsSampleID())
        Me.sampleIDField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property TotalDilution() As String
      Get
        Return Me.totalDilutionField
      End Get
      Set(ByVal value As String)
        Me.totalDilutionField = value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038"),
   System.SerializableAttribute(),
   System.Diagnostics.DebuggerStepThroughAttribute(),
   System.ComponentModel.DesignerCategoryAttribute("code"),
   System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
  Partial Public Class SampleResultsSampleResultSampleIDsSampleID

    Private iDNameField As String

    Private iDValueField As String

    Private typeField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>
    Public Property IDName() As String
      Get
        Return Me.iDNameField
      End Get
      Set(ByVal value As String)
        Me.iDNameField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>
    Public Property IDValue() As String
      Get
        Return Me.iDValueField
      End Get
      Set(ByVal value As String)
        Me.iDValueField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Type() As String
      Get
        Return Me.typeField
      End Get
      Set(ByVal value As String)
        Me.typeField = value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038"),
   System.SerializableAttribute(),
   System.Diagnostics.DebuggerStepThroughAttribute(),
   System.ComponentModel.DesignerCategoryAttribute("code"),
   System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
  Partial Public Class SampleResultsSampleResultMeasurements

    Private measurementField() As Measurement

    Private countField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute("Measurement")>
    Public Property Measurement() As Measurement()
      Get
        Return Me.measurementField
      End Get
      Set(ByVal value As Measurement())
        Me.measurementField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property Count() As String
      Get
        Return Me.countField
      End Get
      Set(ByVal value As String)
        Me.countField = value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038"),
   System.SerializableAttribute(),
   System.Diagnostics.DebuggerStepThroughAttribute(),
   System.ComponentModel.DesignerCategoryAttribute("code"),
   System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
  Partial Public Class SampleResultsSampleResultEPAData

    Private epaStdNameField As String

    Private epaOrgIdentField As String

    Private epaDilFactorField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>
    Public Property EpaStdName() As String
      Get
        Return Me.epaStdNameField
      End Get
      Set(ByVal value As String)
        Me.epaStdNameField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>
    Public Property EpaOrgIdent() As String
      Get
        Return Me.epaOrgIdentField
      End Get
      Set(ByVal value As String)
        Me.epaOrgIdentField = value
      End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>
    Public Property EpaDilFactor() As String
      Get
        Return Me.epaDilFactorField
      End Get
      Set(ByVal value As String)
        Me.epaDilFactorField = value
      End Set
    End Property
  End Class

  '''<remarks/>
  <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038"),
   System.SerializableAttribute(),
   System.Diagnostics.DebuggerStepThroughAttribute(),
   System.ComponentModel.DesignerCategoryAttribute("code"),
   System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
   System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
  Partial Public Class NewDataSet

    Private itemsField() As Object

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute("Measurement", GetType(Measurement)),
     System.Xml.Serialization.XmlElementAttribute("SampleResults", GetType(SampleResults))>
    Public Property Items() As Object()
      Get
        Return Me.itemsField
      End Get
      Set(ByVal value As Object())
        Me.itemsField = value
      End Set
    End Property
  End Class
End Namespace
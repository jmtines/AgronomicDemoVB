Option Explicit On
Option Strict On

Imports System.IO
Imports AgronomicDemo
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class SoilICP_InegrationTests
#Region "Unit Testing Setup Objects"
  Private Property Sample_Check As ICPSampleResult = New ICPSampleResult With {
    .BatchID = 999999, .SampleID = 999999, .Check = "Me", .LabNumber = "ZZ999999", .HasDuplicateSampleInDatabase = False, .IsRecheck = False, .SampleType = SoilIcpSampleTypeEnum.CheckSample}
  Private Property Sample_Control As ICPSampleResult = New ICPSampleResult With {
    .BatchID = 999999, .SampleID = 888888, .LabNumber = "ZZ888888", .HasDuplicateSampleInDatabase = False, .IsRecheck = False, .SampleType = SoilIcpSampleTypeEnum.ControlSample}
  Private Property Sample_CCV As ICPSampleResult = New ICPSampleResult With {
    .BatchID = 999999, .SampleID = 777777, .LabNumber = "ZZ777777", .HasDuplicateSampleInDatabase = False, .IsRecheck = False, .SampleType = SoilIcpSampleTypeEnum.CcvSample}
  Private Property Sample_Original As ICPSampleResult = New ICPSampleResult With {
    .BatchID = 999999, .SampleID = 666666, .LabNumber = "ZZ666666", .HasDuplicateSampleInDatabase = False, .IsRecheck = False, .SampleType = SoilIcpSampleTypeEnum.LabTestSample}
  Private Property Sample_Duplicate As ICPSampleResult = New ICPSampleResult With {
    .BatchID = 999999, .SampleID = 666666, .LabNumber = "ZZ666666", .HasDuplicateSampleInDatabase = True, .IsRecheck = False, .SampleType = SoilIcpSampleTypeEnum.LabTestSample}
  Private Property Sample_Recheck As ICPSampleResult = New ICPSampleResult With {
    .BatchID = 999999, .SampleID = 555555, .LabNumber = "ZZ555555", .HasDuplicateSampleInDatabase = False, .IsRecheck = True, .SampleType = SoilIcpSampleTypeEnum.LabTestSample}
  Private Property Sample_Recheck_Duplicate As ICPSampleResult = New ICPSampleResult With {
    .BatchID = 999999, .SampleID = 555555, .LabNumber = "ZZ555555", .HasDuplicateSampleInDatabase = True, .IsRecheck = True, .SampleType = SoilIcpSampleTypeEnum.LabTestSample}

  Private Property Al_CheckSample_Tolerances As SoilIcpLimits = New SoilIcpLimits("Al") With {
    .Mean = 75.5, .ErrorLowerLimit = 44.75, .ErrorUpperLimit = 55, .WarningLowerLimit = 106.25, .WarningUpperLimit = 96}
  Private Property Al_ControlSample_Tolerances As SoilIcpLimits = New SoilIcpLimits("Al") With {
    .ErrorLowerLimit = 0.025, .ErrorUpperLimit = 500, .WarningLowerLimit = 5, .WarningUpperLimit = 300}

  Private Property Al_Normal As ICPElement = New ICPElement With {.Label = "Al", .Measurement = 75.5, .Units = "ppm"}
  Private Property Al_Control_Error_High As ICPElement = New ICPElement With {.Label = "Al", .Measurement = 550, .Units = "ppm"}
  Private Property Al_Control_Warning_High As ICPElement = New ICPElement With {.Label = "Al", .Measurement = 350, .Units = "ppm"}
  Private Property Al_Control_Error_Low As ICPElement = New ICPElement With {.Label = "Al", .Measurement = 0.01, .Units = "ppm"}
  Private Property Al_Control_Warning_Low As ICPElement = New ICPElement With {.Label = "Al", .Measurement = 4, .Units = "ppm"}
  Private Property Al_Check_Error_High As ICPElement = New ICPElement With {.Label = "Al", .Measurement = 150, .Units = "ppm"}
  Private Property Al_Check_Warning_High As ICPElement = New ICPElement With {.Label = "Al", .Measurement = 100, .Units = "ppm"}
  Private Property Al_Check_Error_Low As ICPElement = New ICPElement With {.Label = "Al", .Measurement = 40, .Units = "ppm"}
  Private Property Al_Check_Warning_Low As ICPElement = New ICPElement With {.Label = "Al", .Measurement = 50, .Units = "ppm"}
#End Region

#Region "Set up Arcos V2 Test Cases"
  Private ReadOnly filePath As String = AppDomain.CurrentDomain.BaseDirectory + "\"
  Private ReadOnly SQLConnectionStringBeta As String = "Data Source=AGRSQLDev; Initial Catalog=AgronomicLimsBeta;Integrated Security=SSPI;Trusted_Connection=yes;"

  Private ReadOnly fileNameAC002029 As String = "AC002029_ArcosV2.xml"
  Private ReadOnly fileNameBlank_Arcos As String = "Blank_ArcosV2.xml"
  Private ReadOnly fileNameCCV_QC_ArcosV2 As String = "CCV QC_ArcosV2.xml"
  Private ReadOnly fileNameICV_Low_QC_ArcosV2 As String = "ICV Low QC_ArcosV2.xml"
  Private ReadOnly fileNameICV_QC_ArcosV2 As String = "ICV QC_ArcosV2.xml"
  Private ReadOnly fileNameLow_S_ArcosV2 As String = "Low S_ArcosV2.xml"
  Private ReadOnly fileNameStandard_1_ArcosV2 As String = "Standard 1_ArcosV2.xml"
  Private ReadOnly fileNameStandard_2_ArcosV2 As String = "Standard 2_ArcosV2.xml"
  Private ReadOnly fileNameRS242_ArcosV2 As String = "RS000242_ArcosV2.xml"
  Private ReadOnly fileNameRS242_Confirmed_ArcosV2 As String = "RS000242_Confirmed_ArcosV2.xml"
  Private ReadOnly fileNameRS242_Recheck_ArcosV2 As String = "RS000242_Rechck_ArcosV2.xml"
  Private ReadOnly fileNameRS242_Recheck_Confirmed_ArcosV2 As String = "RS000242_Recheck_Confirmed_ArcosV2.xml"
  Private ReadOnly numberOfElementsTested As Integer = 11

#Region "Set Up Get Sample From XML"
  Private Property AC002029 As ICPSampleResult = GetSampleFromXML(filePath + fileNameAC002029)
  Private Property BlankArcosV2 As ICPSampleResult = GetSampleFromXML(filePath + fileNameBlank_Arcos)
  Private Property CCVAcrcosV2 As ICPSampleResult = GetSampleFromXML(filePath + fileNameCCV_QC_ArcosV2)
  Private Property ICVLowQCArcosV2 As ICPSampleResult = GetSampleFromXML(filePath + fileNameICV_Low_QC_ArcosV2)
  Private Property ICVQCArcosV2 As ICPSampleResult = GetSampleFromXML(filePath + fileNameICV_QC_ArcosV2)
  Private Property LowS_ArcosV2 As ICPSampleResult = GetSampleFromXML(filePath + fileNameLow_S_ArcosV2)
  Private Property Standard1_ArcosV2 As ICPSampleResult = GetSampleFromXML(filePath + fileNameStandard_1_ArcosV2)
  Private Property Standard2_ArcosV2 As ICPSampleResult = GetSampleFromXML(filePath + fileNameStandard_2_ArcosV2)
  Private Property RS242_ArcosV2 As ICPSampleResult = GetSampleFromXML(filePath + fileNameRS242_ArcosV2)
  Private Property RS242_Confirmed_ArcosV2 As ICPSampleResult = GetSampleFromXML(filePath + fileNameRS242_Confirmed_ArcosV2)
  Private Property RS242_Recheck_ArcosV2 As ICPSampleResult = GetSampleFromXML(filePath + fileNameRS242_Recheck_ArcosV2)
  Private Property RS242_Recheck_Confirmed_ArcosV2 As ICPSampleResult = GetSampleFromXML(filePath + fileNameRS242_Recheck_Confirmed_ArcosV2)
#End Region

  Private Function GetSampleFromXML(ByVal fileName As String) As ICPSampleResult
    Return New ICPArcosSampleResultFactory(file:=fileName).SampleResult
  End Function

#Region "Create File Read Tests Arcos V2"
  <TestMethod()> Public Sub AC002029_ArcosV2_TestFileConnection()
    Dim directoryExists As Boolean = Directory.Exists(filePath)
    Dim fileExists As Boolean = File.Exists(filePath + fileNameAC002029)

    Assert.IsTrue(directoryExists)
    Assert.IsTrue(fileExists)
  End Sub
  <TestMethod()> Public Sub Blank_ArcosV2_TestFileConnection()
    Dim directoryExists As Boolean = Directory.Exists(filePath)
    Dim fileExists As Boolean = File.Exists(filePath + fileNameBlank_Arcos)

    Assert.IsTrue(directoryExists)
    Assert.IsTrue(fileExists)
  End Sub
  <TestMethod()> Public Sub CCV_ArcosV2_TestFileConnection()
    Dim directoryExists As Boolean = Directory.Exists(filePath)
    Dim fileExists As Boolean = File.Exists(filePath + fileNameCCV_QC_ArcosV2)

    Assert.IsTrue(directoryExists)
    Assert.IsTrue(fileExists)
  End Sub
  <TestMethod()> Public Sub Low_QC_ArcosV2_TestFileConnection()
    Dim directoryExists As Boolean = Directory.Exists(filePath)
    Dim fileExists As Boolean = File.Exists(filePath + fileNameICV_Low_QC_ArcosV2)

    Assert.IsTrue(directoryExists)
    Assert.IsTrue(fileExists)
  End Sub
  <TestMethod()> Public Sub ICV_QC_ArcosV2_TestFileConnection()
    Dim directoryExists As Boolean = Directory.Exists(filePath)
    Dim fileExists As Boolean = File.Exists(filePath + fileNameICV_QC_ArcosV2)

    Assert.IsTrue(directoryExists)
    Assert.IsTrue(fileExists)
  End Sub
  <TestMethod()> Public Sub Low_S_ArcosV2_TestFileConnection()
    Dim directoryExists As Boolean = Directory.Exists(filePath)
    Dim fileExists As Boolean = File.Exists(filePath + fileNameLow_S_ArcosV2)

    Assert.IsTrue(directoryExists)
    Assert.IsTrue(fileExists)
  End Sub
  <TestMethod()> Public Sub Standard_1_ArcosV2_TestFileConnection()
    Dim directoryExists As Boolean = Directory.Exists(filePath)
    Dim fileExists As Boolean = File.Exists(filePath + fileNameStandard_1_ArcosV2)

    Assert.IsTrue(directoryExists)
    Assert.IsTrue(fileExists)
  End Sub
  <TestMethod()> Public Sub Standard_2_ArcosV2_TestFileConnection()
    Dim directoryExists As Boolean = Directory.Exists(filePath)
    Dim fileExists As Boolean = File.Exists(filePath + fileNameStandard_2_ArcosV2)

    Assert.IsTrue(directoryExists)
    Assert.IsTrue(fileExists)
  End Sub

#End Region
  ' Test Compair to Database
  ' SELECT * FROM Lab_ICPResults AS icp WHERE icp.LabNumber = 'AC002029' AND icp.LabID = 1 AND icp.BatchID = 44211 AND icp.Confirmed = 1
  ' Number in Database have been rounded, here is raw numbers
#Region "AC002029 Sample Arcos V2"
  <TestMethod()> Public Sub AC002029_ArcosV2_XMLToLabNumber_Correct()
    Assert.AreEqual("AC002029", AC002029.LabNumber)
  End Sub
  <TestMethod()> Public Sub AC002029_ArcosV2_XMLToElementCount_Correct()
    Assert.AreEqual(numberOfElementsTested, AC002029.Elements.Count)
  End Sub
  <TestMethod()> Public Sub AC002029_ArcosV2_XMLToSampleTypeCorrect_Correct()
    Assert.AreEqual("LabTestSample", AC002029.SampleType.ToString)
  End Sub
  <TestMethod()> Public Sub AC002029_ArcosV2_XMLToCheckType_Correct()
    Assert.AreEqual("", AC002029.Check)
  End Sub
  <TestMethod()> Public Sub AC002029_ArcosV2_XMLToElementAl_Correct()
    Assert.AreEqual(84.2956, AC002029.Elements.Where(
                Function(x) x.Label.Equals("Al", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub AC002029_ArcosV2_XMLToElementCa_Correct()
    Assert.AreEqual(289.594, AC002029.Elements.Where(
                Function(x) x.Label.Equals("Ca", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub AC002029_ArcosV2_XMLToElementCu_Correct()
    Assert.AreEqual(0.243641, AC002029.Elements.Where(
                Function(x) x.Label.Equals("Cu", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub AC002029_ArcosV2_XMLToElementFe_Correct()
    Assert.AreEqual(12.3466, AC002029.Elements.Where(
                Function(x) x.Label.Equals("Fe", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub AC002029_ArcosV2_XMLToElementK_Correct()
    Assert.AreEqual(10.2198, AC002029.Elements.Where(
                Function(x) x.Label.Equals("K", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub AC002029_ArcosV2_XMLToElementMg_Correct()
    Assert.AreEqual(88.2298, AC002029.Elements.Where(
                Function(x) x.Label.Equals("Mg", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub AC002029_ArcosV2_XMLToElementMn_Correct()
    Assert.AreEqual(1.26002, AC002029.Elements.Where(
                Function(x) x.Label.Equals("Mn", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub AC002029_ArcosV2_XMLToElementNa_Correct()
    Assert.AreEqual(3.87011, AC002029.Elements.Where(
                Function(x) x.Label.Equals("Na", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub AC002029_ArcosV2_XMLToElementP_Correct()
    Assert.AreEqual(7.4684, AC002029.Elements.Where(
                Function(x) x.Label.Equals("P", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub AC002029_ArcosV2_XMLToElementS_Correct()
    Assert.AreEqual(1.74709, AC002029.Elements.Where(
                Function(x) x.Label.Equals("S", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub AC002029_ArcosV2_XMLToElementZn_Correct()
    Assert.AreEqual(3.23666, AC002029.Elements.Where(
                Function(x) x.Label.Equals("Zn", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
#End Region
  ' Test Compair to Database
  ' Select * From Lab_ICPResults As ICP Where ICP.LabID = 1 AND ICP.LabNumber = 'Blank' And icp.BatchID = 48108 ORDER BY TestResultID
  ' Number in Database have been rounded, here is raw numbers
#Region "Blank Contorl Sample Arcos V2"
  <TestMethod()> Public Sub Blank_ArcosV2_LabNumber_Correct()

    Assert.IsNotNull(BlankArcosV2)
    Assert.AreEqual("Blank", BlankArcosV2.LabNumber)
  End Sub
  <TestMethod()> Public Sub Blank_ArcosV2_CheckName_Correct()
    Assert.AreEqual("Blank", BlankArcosV2.Check)
  End Sub
  <TestMethod()> Public Sub Blank_ArcosV2_ElementCount_Correct()
    Assert.AreEqual(12, BlankArcosV2.Elements.Count)
  End Sub
  <TestMethod()> Public Sub Blank_ArcosV2_SampleType_Correct()
    Assert.AreEqual("ControlSample", BlankArcosV2.SampleType.ToString)
  End Sub
  <TestMethod()> Public Sub Blank_ArcosV2_XMLToElementAl_Correct()
    Assert.AreEqual(Nothing, BlankArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Al", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Blank_ArcosV2_XMLToElementCa_Correct()
    Assert.AreEqual(1336.22, BlankArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Ca", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Blank_ArcosV2_XMLToElementCu_Correct()
    Assert.AreEqual(-134.2, BlankArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Cu", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Blank_ArcosV2_XMLToElementFe_Correct()
    Assert.AreEqual(-65.2362, BlankArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Fe", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Blank_ArcosV2_XMLToElementK_Correct()
    Assert.AreEqual(-87.0149, BlankArcosV2.Elements.Where(
                Function(x) x.Label.Equals("K", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Blank_ArcosV2_XMLToElementMg_Correct()
    Assert.AreEqual(458.415, BlankArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Mg", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Blank_ArcosV2_XMLToElementMn_Correct()
    Assert.AreEqual(-69.7927, BlankArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Mn", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Blank_ArcosV2_XMLToElementNa_Correct()
    Assert.AreEqual(698.294, BlankArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Na", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Blank_ArcosV2_XMLToElementP_Correct()
    Assert.AreEqual(77.6422, BlankArcosV2.Elements.Where(
                Function(x) x.Label.Equals("P", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Blank_ArcosV2_XMLToElementS_Correct()
    Assert.AreEqual(96.3236, BlankArcosV2.Elements.Where(
                Function(x) x.Label.Equals("S", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Blank_ArcosV2_XMLToElementZn_Correct()
    Assert.AreEqual(372.498, BlankArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Zn", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
#End Region
  ' Test Compair to Database
  ' Select * From Lab_ICPResults As ICP Where ICP.LabID = 1 AND icp.LabNumber = 'CCV QC' And icp.BatchID = 48108 ORDER BY TestResultID
  ' Number in Database have been rounded, here is raw numbers
#Region "CCV Sample Arcos V2"
  <TestMethod()> Public Sub CCV_ArcosV2_LabNumber_Correct()

    Assert.IsNotNull(CCVAcrcosV2)
    Assert.AreEqual("CCV QC", CCVAcrcosV2.LabNumber)
  End Sub
  <TestMethod()> Public Sub CCV_ArcosV2_CheckName_Correct()
    Assert.AreEqual(String.Empty, CCVAcrcosV2.Check)
  End Sub
  <TestMethod()> Public Sub CCV_ArcosV2_ElementCount_Correct()
    Assert.AreEqual(numberOfElementsTested, CCVAcrcosV2.Elements.Count)
  End Sub
  <TestMethod()> Public Sub CCV_ArcosV2_SampleType_Correct()
    Assert.AreEqual("CcvSample", CCVAcrcosV2.SampleType.ToString)
  End Sub
  <TestMethod()> Public Sub CCV_ArcosV2_XMLToElementAl_Correct()
    Assert.AreEqual(9.78757, CCVAcrcosV2.Elements.Where(
                Function(x) x.Label.Equals("Al", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub CCV_ArcosV2_XMLToElementCa_Correct()
    Assert.AreEqual(101.343, CCVAcrcosV2.Elements.Where(
                Function(x) x.Label.Equals("Ca", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub CCV_ArcosV2_XMLToElementCu_Correct()
    Assert.AreEqual(2.50755, CCVAcrcosV2.Elements.Where(
                Function(x) x.Label.Equals("Cu", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub CCV_ArcosV2_XMLToElementFe_Correct()
    Assert.AreEqual(2.65097, CCVAcrcosV2.Elements.Where(
                Function(x) x.Label.Equals("Fe", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub CCV_ArcosV2_XMLToElementK_Correct()
    Assert.AreEqual(28.6874, CCVAcrcosV2.Elements.Where(
                Function(x) x.Label.Equals("K", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub CCV_ArcosV2_XMLToElementMg_Correct()
    Assert.AreEqual(29.419, CCVAcrcosV2.Elements.Where(
                Function(x) x.Label.Equals("Mg", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub CCV_ArcosV2_XMLToElementMn_Correct()
    Assert.AreEqual(2.58188, CCVAcrcosV2.Elements.Where(
                Function(x) x.Label.Equals("Mn", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub CCV_ArcosV2_XMLToElementNa_Correct()
    Assert.AreEqual(9.68035, CCVAcrcosV2.Elements.Where(
                Function(x) x.Label.Equals("Na", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub CCV_ArcosV2_XMLToElementP_Correct()
    Assert.AreEqual(31.4562, CCVAcrcosV2.Elements.Where(
                Function(x) x.Label.Equals("P", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub CCV_ArcosV2_XMLToElementS_Correct()
    Assert.AreEqual(30.063, CCVAcrcosV2.Elements.Where(
                Function(x) x.Label.Equals("S", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub CCV_ArcosV2_XMLToElementZn_Correct()
    Assert.AreEqual(2.51409, CCVAcrcosV2.Elements.Where(
                Function(x) x.Label.Equals("Zn", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
#End Region
  ' Test Compair to Database
  ' Select * From Lab_ICPResults As ICP Where ICP.LabID = 1 AND icp.LabNumber = 'ICV Low QC' And icp.BatchID = 48108 ORDER BY TestResultID
  ' Number in Database have been rounded, here is raw numbers
#Region "ICV Low QC Sample Arcos V2"
  <TestMethod()> Public Sub ICVLowQC_ArcosV2_LabNumber_Correct()

    Assert.IsNotNull(ICVLowQCArcosV2)
    Assert.AreEqual("ICV Low QC", ICVLowQCArcosV2.LabNumber)
  End Sub
  <TestMethod()> Public Sub ICVLowQC_ArcosV2_CheckName_Correct()
    Assert.AreEqual(String.Empty, ICVLowQCArcosV2.Check)
  End Sub
  <TestMethod()> Public Sub ICVLowQC_ArcosV2_ElementCount_Correct()
    Assert.AreEqual(numberOfElementsTested, ICVLowQCArcosV2.Elements.Count)
  End Sub
  <TestMethod()> Public Sub ICVLowQC_ArcosV2_SampleType_Correct()
    Assert.AreEqual("CheckSample", ICVLowQCArcosV2.SampleType.ToString)
  End Sub
  <TestMethod()> Public Sub ICVLowQC_ArcosV2_XMLToElementAl_Correct()
    Assert.AreEqual(5.20933, ICVLowQCArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Al", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub ICVLowQC_ArcosV2_XMLToElementCa_Correct()
    Assert.AreEqual(52.0808, ICVLowQCArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Ca", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub ICVLowQC_ArcosV2_XMLToElementCu_Correct()
    Assert.AreEqual(1.28163, ICVLowQCArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Cu", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub ICVLowQC_ArcosV2_XMLToElementFe_Correct()
    Assert.AreEqual(1.37774, ICVLowQCArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Fe", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub ICVLowQC_ArcosV2_XMLToElementK_Correct()
    Assert.AreEqual(15.2218, ICVLowQCArcosV2.Elements.Where(
                Function(x) x.Label.Equals("K", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub ICVLowQC_ArcosV2_XMLToElementMg_Correct()
    Assert.AreEqual(15.6331, ICVLowQCArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Mg", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub ICVLowQC_ArcosV2_XMLToElementMn_Correct()
    Assert.AreEqual(1.29859, ICVLowQCArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Mn", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub ICVLowQC_ArcosV2_XMLToElementNa_Correct()
    Assert.AreEqual(5.00545, ICVLowQCArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Na", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub ICVLowQC_ArcosV2_XMLToElementP_Correct()
    Assert.AreEqual(15.5742, ICVLowQCArcosV2.Elements.Where(
                Function(x) x.Label.Equals("P", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub ICVLowQC_ArcosV2_XMLToElementS_Correct()
    Assert.AreEqual(15.535, ICVLowQCArcosV2.Elements.Where(
                Function(x) x.Label.Equals("S", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub ICVLowQC_ArcosV2_XMLToElementZn_Correct()
    Assert.AreEqual(1.32248, ICVLowQCArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Zn", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
#End Region
  ' Test Compair to Database
  ' Select * From Lab_ICPResults As ICP Where ICP.LabID = 1 AND icp.LabNumber = 'ICV QC' And icp.BatchID = 48115 ORDER BY TestResultID
  ' Number in Database have been rounded, here is raw numbers
#Region "ICV QC Sample Arcos V2"
  <TestMethod()> Public Sub ICVQC_ArcosV2_LabNumber_Correct()

    Assert.IsNotNull(ICVQCArcosV2)
    Assert.AreEqual("ICV QC", ICVQCArcosV2.LabNumber)
  End Sub
  <TestMethod()> Public Sub ICVQC_ArcosV2_CheckName_Correct()
    Assert.AreEqual(String.Empty, ICVQCArcosV2.Check)
  End Sub
  <TestMethod()> Public Sub ICVQC_ArcosV2_ElementCount_Correct()
    Assert.AreEqual(numberOfElementsTested, ICVQCArcosV2.Elements.Count)
  End Sub
  <TestMethod()> Public Sub ICVQC_ArcosV2_SampleType_Correct()
    Assert.AreEqual("CheckSample", ICVQCArcosV2.SampleType.ToString)
  End Sub
  <TestMethod()> Public Sub ICVQC_ArcosV2_XMLToElementAl_Correct()
    Assert.AreEqual(10.005, ICVQCArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Al", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub ICVQC_ArcosV2_XMLToElementCa_Correct()
    Assert.AreEqual(103.598, ICVQCArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Ca", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub ICVQC_ArcosV2_XMLToElementCu_Correct()
    Assert.AreEqual(2.51123, ICVQCArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Cu", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub ICVQC_ArcosV2_XMLToElementFe_Correct()
    Assert.AreEqual(2.71308, ICVQCArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Fe", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub ICVQC_ArcosV2_XMLToElementK_Correct()
    Assert.AreEqual(29.3338, ICVQCArcosV2.Elements.Where(
                Function(x) x.Label.Equals("K", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub ICVQC_ArcosV2_XMLToElementMg_Correct()
    Assert.AreEqual(30.1902, ICVQCArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Mg", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub ICVQC_ArcosV2_XMLToElementMn_Correct()
    Assert.AreEqual(2.56845, ICVQCArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Mn", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub ICVQC_ArcosV2_XMLToElementNa_Correct()
    Assert.AreEqual(9.88153, ICVQCArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Na", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub ICVQC_ArcosV2_XMLToElementP_Correct()
    Assert.AreEqual(31.0907, ICVQCArcosV2.Elements.Where(
                Function(x) x.Label.Equals("P", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub ICVQC_ArcosV2_XMLToElementS_Correct()
    Assert.AreEqual(31.4572, ICVQCArcosV2.Elements.Where(
                Function(x) x.Label.Equals("S", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub ICVQC_ArcosV2_XMLToElementZn_Correct()
    Assert.AreEqual(2.54853, ICVQCArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Zn", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
#End Region
  ' Test Compair to Database
  ' Select * From Lab_ICPResults As ICP Where ICP.LabID = 1 AND icp.LabNumber = 'Low S' And icp.BatchID = 48108 ORDER BY TestResultID
  ' Number in Database have been rounded, here is raw numbers
#Region "Low S Sample Arcos V2"
  <TestMethod()> Public Sub LowS_ArcosV2_LabNumber_Correct()

    Assert.IsNotNull(LowS_ArcosV2)
    Assert.AreEqual("Low S", LowS_ArcosV2.LabNumber)
  End Sub
  <TestMethod()> Public Sub LowS_ArcosV2_CheckName_Correct()
    Assert.AreEqual("Low S", LowS_ArcosV2.Check)
  End Sub
  <TestMethod()> Public Sub LowS_ArcosV2_ElementCount_Correct()
    Assert.AreEqual(numberOfElementsTested, LowS_ArcosV2.Elements.Count)
  End Sub
  <TestMethod()> Public Sub LowS_ArcosV2_SampleType_Correct()
    Assert.AreEqual("ControlSample", LowS_ArcosV2.SampleType.ToString)
  End Sub
  <TestMethod()> Public Sub LowS_ArcosV2_XMLToElementAl_Correct()
    Assert.AreEqual(3119.62, LowS_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Al", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub LowS_ArcosV2_XMLToElementCa_Correct()
    Assert.AreEqual(1191.19, LowS_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Ca", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub LowS_ArcosV2_XMLToElementCu_Correct()
    Assert.AreEqual(-182.933, LowS_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Cu", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub LowS_ArcosV2_XMLToElementFe_Correct()
    Assert.AreEqual(-32.9947, LowS_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Fe", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub LowS_ArcosV2_XMLToElementK_Correct()
    Assert.AreEqual(-118.711, LowS_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("K", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub LowS_ArcosV2_XMLToElementMg_Correct()
    Assert.AreEqual(342.592, LowS_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Mg", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub LowS_ArcosV2_XMLToElementMn_Correct()
    Assert.AreEqual(-50.7931, LowS_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Mn", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub LowS_ArcosV2_XMLToElementNa_Correct()
    Assert.AreEqual(592.162, LowS_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Na", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub LowS_ArcosV2_XMLToElementP_Correct()
    Assert.AreEqual(685.114, LowS_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("P", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub LowS_ArcosV2_XMLToElementS_Correct()
    Assert.AreEqual(475.494, LowS_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("S", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub LowS_ArcosV2_XMLToElementZn_Correct()
    Assert.AreEqual(338.685, LowS_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Zn", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
#End Region
  ' Test Compair to Database
  ' Select * From Lab_ICPResults As ICP Where ICP.LabID = 1 AND icp.LabNumber = 'Standard 1' And icp.BatchID = 43322 ORDER BY TestResultID
  ' Number in Database have been rounded, here is raw numbers
#Region "Standard 1 Arcos V2"
  <TestMethod()> Public Sub Standard1_ArcosV2_LabNumber_Correct()

    Assert.IsNotNull(Standard1_ArcosV2)
    Assert.AreEqual("Standard 1", Standard1_ArcosV2.LabNumber)
  End Sub
  <TestMethod()> Public Sub Standard1_ArcosV2_CheckName_Correct()
    Assert.AreEqual("Standard 1", Standard1_ArcosV2.Check)
  End Sub
  <TestMethod()> Public Sub Standard1_ArcosV2_ElementCount_Correct()
    Assert.AreEqual(numberOfElementsTested, Standard1_ArcosV2.Elements.Count)
  End Sub
  <TestMethod()> Public Sub Standard1_ArcosV2_SampleType_Correct()
    Assert.AreEqual("ControlSample", Standard1_ArcosV2.SampleType.ToString)
  End Sub
  <TestMethod()> Public Sub Standard1_ArcosV2_XMLToElementAl_Correct()
    Assert.AreEqual(340449.0, Standard1_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Al", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Standard1_ArcosV2_XMLToElementCa_Correct()
    Assert.AreEqual(20765400.0, Standard1_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Ca", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Standard1_ArcosV2_XMLToElementCu_Correct()
    Assert.AreEqual(547224.0, Standard1_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Cu", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Standard1_ArcosV2_XMLToElementFe_Correct()
    Assert.AreEqual(373354.0, Standard1_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Fe", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Standard1_ArcosV2_XMLToElementK_Correct()
    Assert.AreEqual(210524.0, Standard1_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("K", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Standard1_ArcosV2_XMLToElementMg_Correct()
    Assert.AreEqual(391585.0, Standard1_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Mg", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Standard1_ArcosV2_XMLToElementMn_Correct()
    Assert.AreEqual(1892180.0, Standard1_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Mn", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Standard1_ArcosV2_XMLToElementNa_Correct()
    Assert.AreEqual(768538.0, Standard1_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Na", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Standard1_ArcosV2_XMLToElementP_Correct()
    Assert.AreEqual(752.651, Standard1_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("P", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Standard1_ArcosV2_XMLToElementS_Correct()
    Assert.AreEqual(475.494, Standard1_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("S", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Standard1_ArcosV2_XMLToElementZn_Correct()
    Assert.AreEqual(1099610.0, Standard1_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Zn", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
#End Region
  ' Test Compair to Database
  ' Select * From Lab_ICPResults As ICP Where ICP.LabID = 1 AND icp.LabNumber = 'Standard 2' And icp.BatchID = 43322 ORDER BY TestResultID
  ' Number in Database have been rounded, here is raw numbers
#Region "Standard 2 Arcos V2"
  <TestMethod()> Public Sub Standard2_ArcosV2_LabNumber_Correct()

    Assert.IsNotNull(Standard2_ArcosV2)
    Assert.AreEqual("Standard 2", Standard2_ArcosV2.LabNumber)
  End Sub
  <TestMethod()> Public Sub Standard2_ArcosV2_CheckName_Correct()
    Assert.AreEqual("Standard 2", Standard2_ArcosV2.Check)
  End Sub
  <TestMethod()> Public Sub Standard2_ArcosV2_ElementCount_Correct()
    Assert.AreEqual(numberOfElementsTested, Standard2_ArcosV2.Elements.Count)
  End Sub
  <TestMethod()> Public Sub Standard2_ArcosV2_SampleType_Correct()
    Assert.AreEqual("ControlSample", Standard2_ArcosV2.SampleType.ToString)
  End Sub
  <TestMethod()> Public Sub Standard2_ArcosV2_XMLToElementAl_Correct()
    Assert.AreEqual(7360.45, Standard2_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Al", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Standard2_ArcosV2_XMLToElementCa_Correct()
    Assert.AreEqual(235605.0, Standard2_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Ca", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Standard2_ArcosV2_XMLToElementCu_Correct()
    Assert.AreEqual(9859.75, Standard2_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Cu", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Standard2_ArcosV2_XMLToElementFe_Correct()
    Assert.AreEqual(7449.9, Standard2_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Fe", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Standard2_ArcosV2_XMLToElementK_Correct()
    Assert.AreEqual(3688.25, Standard2_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("K", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Standard2_ArcosV2_XMLToElementMg_Correct()
    Assert.AreEqual(7443.2, Standard2_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Mg", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Standard2_ArcosV2_XMLToElementMn_Correct()
    Assert.AreEqual(36754.3, Standard2_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Mn", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Standard2_ArcosV2_XMLToElementNa_Correct()
    Assert.AreEqual(8864.27, Standard2_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Na", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Standard2_ArcosV2_XMLToElementP_Correct()
    Assert.AreEqual(591328.0, Standard2_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("P", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Standard2_ArcosV2_XMLToElementS_Correct()
    Assert.AreEqual(339536.0, Standard2_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("S", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
  <TestMethod()> Public Sub Standard2_ArcosV2_XMLToElementZn_Correct()
    Assert.AreEqual(19512.5, Standard2_ArcosV2.Elements.Where(
                Function(x) x.Label.Equals("Zn", StringComparison.CurrentCultureIgnoreCase)).Select(
                Function(y) y.Measurement).SingleOrDefault)
  End Sub
#End Region
#End Region

End Class
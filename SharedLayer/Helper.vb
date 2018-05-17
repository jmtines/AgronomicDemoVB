Option Explicit On
Option Strict On
Imports System.Text.RegularExpressions

Public Class Helper
  Public Shared Function CleanNumber(ByVal Number As String) As Integer
    Number = Regex.Replace(Number, "[^0-9]", String.Empty)
    Number = Number.TrimStart("0"c)
    If (Number <> String.Empty) Then
      Return Convert.ToInt32(Number)
    Else
      Return 0
    End If
  End Function
  Public Shared Function LabNumberRemovedInvalidCharacters(ByVal labNumber As String) As String
    Return Regex.Replace(labNumber.ToUpper, "[^0-9A-Z]", String.Empty)
  End Function
  Public Shared Function LabNumberIsValidFormat(ByVal labNumber As String) As Boolean
    Return Regex.IsMatch(labNumber, "^[A-Z]{1,2}[0-9]{6}\Z")
  End Function
  Public Shared Function LabNumberValidFormater(ByVal labNumber As String) As String
    Dim prefix As String = LabNumberGetPrefix(labNumber)

    Dim digits As Integer = LabNumberGetDigits(labNumber)
    Dim newLabNumber As String = prefix + LabOrReportDigitAddLeadingZeros(digits.ToString)

    Return newLabNumber
  End Function
  Public Shared Function LabNumberGetPrefix(ByVal labNumber As String) As String
    Dim prefix As String
    prefix = Regex.Match(LabNumberRemovedInvalidCharacters(labNumber), "^([A-Za-z]{1,2})(?=[0-9]{1,6})").Value
    If String.IsNullOrEmpty(prefix) Then
      Throw New ArgumentException("Lab Number prefix was not found.")
    End If
    Return prefix
  End Function
  Public Shared Function LabNumberGetDigits(ByVal labNumber As String) As Integer
    labNumber = Replace(labNumber, LabNumberGetPrefix(labNumber), String.Empty)
    Dim number As Integer
    If Integer.TryParse(Regex.Match(
                        LabNumberRemovedInvalidCharacters(labNumber),
                        "([0-9]{1,6})").Value, number).Equals(False) Or number = 0 Then
      Throw New ArgumentException("labNumber is not valid.")
    End If
    Return number
  End Function

  Public Shared Function LabOrReportDigitAddLeadingZeros(ByVal CurrentValue As String) As String
    Return CurrentValue.PadLeft(6, CChar("0"))
  End Function
End Class

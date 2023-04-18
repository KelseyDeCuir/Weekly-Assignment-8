Option Strict On

Public Class Form1
    Private _intSizeOfArray As Integer = 11
    Private _strSavings(_intSizeOfArray) As String
    Private _decBill(_intSizeOfArray) As Decimal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim objReader As IO.StreamReader
        Dim strSavingsAmount As String
        Dim intCount As Integer = 0
        Dim intFill As Integer

        lblMonthSavings.Text = ""
        lblAverageSavings.Text = ""
        lblSignificantSavings.Text = ""

        'Path: C:\Users\kdecu\GUI Dev\savings.txt
        Try
            If IO.File.Exists("C:\Users\kdecu\GUI Dev\savings.txt") = True Then
                objReader = IO.File.OpenText("C:\Users\kdecu\GUI Dev\savings.txt")

                Do While objReader.Peek <> -1
                    _strSavings(intCount) = objReader.ReadLine()
                    strSavingsAmount = objReader.ReadLine()
                    _decBill(intCount) = Convert.ToDecimal(strSavingsAmount)
                    intCount += 1

                Loop
                objReader.Close()
                For intFill = 0 To (_strSavings.Length - 1)
                    cboMonth.Items.Add(_strSavings(intFill))
                Next
            End If
        Catch ex As InvalidOperationException
            MsgBox("Invalid file, restart the program when the file is valid.",, "Error")
            Close()
        End Try
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged

        Dim intSelectedMonthIndex As Integer

        intSelectedMonthIndex = cboMonth.SelectedIndex
        lblMonthSavings.Text = "The electric savings " & _strSavings(intSelectedMonthIndex) & " is $" & _decBill(intSelectedMonthIndex).ToString() & "."



    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click

        ComputeAverage()
        ComputeMaxSavings()

    End Sub

    Private Sub ComputeMaxSavings()
        Dim intMonths As Integer
        Dim intLargestSavingValue As Integer = 0
        Dim intIndexValue As Integer = 0
        Dim strYearValue As String = ""

        For Each intMonths In _decBill
            intLargestSavingValue = Math.Max(intLargestSavingValue, intMonths)
            If (intMonths >= intLargestSavingValue) Then
                strYearValue = _strSavings(intIndexValue)
            End If
            intIndexValue += 1
        Next
        lblSignificantSavings.Text = strYearValue & " had the most significant monthly savings."
    End Sub

    Private Sub ComputeAverage()
        Dim intCountYears As Integer
        Dim intYears As Integer = 0
        Dim decTotalBill As Decimal = 0
        Dim decAverageNumberOfBill As Decimal = 0D

        For Each intCountYears In _decBill
            decTotalBill += _decBill(intYears)
            intYears += 1
        Next
        decAverageNumberOfBill = decTotalBill / Convert.ToDecimal(_decBill.Length())
        lblAverageSavings.Text = "The average monthly savings: " & decAverageNumberOfBill.ToString("C2")

    End Sub
End Class

Structure Employee
    Dim strName As String
    Dim intIndice As Integer
End Structure


Public Class Test
    Public Shared Sub Main()
        Dim arySql(15) As Employee
        Dim intCounter As Integer

        arySql(0).strName = "J"
        arySql(0).intIndice = 3
        arySql(1).strName = "B"
        arySql(1).intSalary = 6

        'Set other array elements here.

        arySql(15).strName = "P"
        arySql(15).intSalary = 1

        'Show the elements of the array.
        For intCounter = 0 To 15
            Console.WriteLine("Array element: " & intCounter & vbCrLf & _
                   "Name: " & aryEmployees(intCounter).strName & vbCrLf & _
                   "Salary: " & aryEmployees(intCounter).intSalary)
        Next intCounter
    End Sub


End Class
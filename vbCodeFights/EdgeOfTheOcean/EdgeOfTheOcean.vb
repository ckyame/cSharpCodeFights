Public Class EdgeOfTheOcean
    Function adjacentElementsProduct(inputArray As List(Of Integer)) As Integer
        Dim a As Integer = inputArray.Item(0),
            b As Integer = inputArray.Item(1),
            c As Integer = inputArray.Item(0) * inputArray.Item(1)
        For i As Integer = 0 To inputArray.Count - 2
            If c <= inputArray.Item(i) * inputArray.Item(i + 1) Then
                a = inputArray.Item(i)
                b = inputArray.Item(i + 1)
                c = inputArray.Item(i) * inputArray.Item(i + 1)
            End If
        Next
        Return c
    End Function

    Function shapeArea(n As Integer) As Integer
        Return If(n = 1, 1, Convert.ToInt32(Math.Pow(n, 2) + Convert.ToInt32(Math.Pow(n - 1, 2))))
    End Function

    Function makeArrayConsecutive2(statues As List(Of Integer)) As Integer
        Dim s As Integer() = statues.ToArray()
        Array.Sort(s)
        Dim c As Integer = s(0),
            r As Integer = 0
        For i As Integer = 0 To s.Count - 1
            r += If(s(i) - c > 1, (s(i) - c) - 1, 0)
            c = s(i)
        Next
        Return r
    End Function

    Function almostIncreasingSequence(s As List(Of Integer)) As Boolean
        Dim f As Boolean = Not True,
            d As Boolean = Not True
        Dim i As Integer = -1,
            j As Integer = 0
        For k As Integer = 1 To s.Count - 2
            d = Not True
            If s.Item(j) >= s.Item(k) Then
                If f Then
                    Return Not True
                End If
                f = True
                If k > 1 And s.Item(i) >= s.Item(k) Then
                    d = True
                End If
            End If
            If f = Not True Then
                i = j
            End If
            If d = Not True Then
                j = k
            End If
        Next
        Return True
    End Function

    Function matrixElementsSum(matrix As List(Of List(Of Integer))) As Integer
        Dim total As Integer = 0
        For row As Integer = 0 To matrix.Item(0).Count - 1
            Try
                For col As Integer = 0 To matrix.Item(row).Count - 1
                    If row = 0 Then
                        total += matrix.Item(row).Item(col)
                    Else
                        If matrix.Item(row - 1).Item(col) > 0 Then
                            If row - 2 > -1 Then
                                If matrix.Item(row - 2).Item(col) > 0 Then
                                    total += matrix.Item(row).Item(col)
                                End If
                            Else
                                total += matrix.Item(row).Item(col)
                            End If
                        End If
                    End If
                Next
            Catch ex As Exception
            End Try
        Next
        Return total
    End Function
End Class

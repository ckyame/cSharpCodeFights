Imports NUnit.Framework

<TestFixture()> Public Class EdgeOfTheOceanTests

    Dim Ocean As EdgeOfTheOcean

    <TestFixtureSetUp()> Public Sub EdgeOfTheOceanTestsInit()
        Ocean = New EdgeOfTheOcean()
    End Sub

    <Test()>
    <TestCase({3, 6, -2, -5, 7, 3}, 21)>
    <TestCase({-1, -2}, 2)>
    <TestCase({5, 1, 2, 3, 1, 4}, 6)>
    <TestCase({1, 2, 3, 0}, 6)>
    <TestCase({9, 5, 10, 2, 24, -1, -48}, 50)>
    <TestCase({5, 6, -4, 2, 3, 2, -23}, 30)>
    <TestCase({4, 1, 2, 3, 1, 5}, 6)>
    <TestCase({-23, 4, -3, 8, -12}, -12)>
    <TestCase({1, 0, 1, 0, 1000}, 0)>
    Public Sub adjacentElementsProduct(inputArray() As Integer, expected As Integer)
        Dim input As List(Of Integer) = inputArray.ToList()
        Dim result As Integer = Ocean.adjacentElementsProduct(input)
        Assert.AreEqual(expected, result)
    End Sub

    <Test>
    <TestCase(2, 5)>
    <TestCase(3, 13)>
    <TestCase(1, 1)>
    <TestCase(5, 41)>
    Public Sub shapeArea(n As Integer, expected As Integer)
        Dim result As Integer = Ocean.shapeArea(n)
        Assert.AreEqual(expected, result)
    End Sub

    <Test>
    <TestCase({6, 2, 3, 8}, 3)>
    <TestCase({0, 3}, 2)>
    <TestCase({5, 4, 6}, 0)>
    <TestCase({6, 3}, 2)>
    <TestCase({1}, 0)>
    Public Sub makeArrayConsecutive(statues() As Integer, expected As Integer)
        Dim result As Integer = Ocean.makeArrayConsecutive2(statues.ToList())
        Assert.AreEqual(expected, result)
    End Sub

    <Test>
    <TestCase({1, 3, 2, 1}, False)>
    <TestCase({1, 3, 2}, True)>
    <TestCase({1, 2, 1, 2}, False)>
    <TestCase({1, 4, 10, 4, 2}, False)>
    <TestCase({10, 1, 2, 3, 4, 5}, True)>
    <TestCase({1, 1, 1, 2, 3}, False)>
    <TestCase({0, -2, 5, 6}, True)>
    <TestCase({1, 2, 3, 4, 5, 3, 5, 6}, False)>
    <TestCase({40, 50, 60, 10, 20, 30}, False)>
    <TestCase({1, 1}, True)>
    <TestCase({10, 1, 2, 3, 4, 5, 6, 1}, False)>
    <TestCase({1, 2, 3, 4, 3, 6}, True)>
    <TestCase({1, 2, 3, 4, 99, 5, 6}, True)>
    <TestCase({123, -17, -5, 1, 2, 3, 12, 43, 45}, True)>
    <TestCase({3, 5, 67, 98, 3}, True)>
    Public Sub almostIncreasingSequence(sequence() As Integer, expected As Boolean)
        Dim result As Boolean = Ocean.almostIncreasingSequence(sequence.ToList())
        Assert.AreEqual(expected, result)
    End Sub
End Class
﻿Public Class Course

    Public Property CRN As Integer
    Public Property Department As String
    Public Property CourseName As String
    Public Property Title As String
    Public Property Instructor As String
    Public Property Days As String
    Public Property Begin As String
    Public Property EndInst As String
    Public Property Location As String
    Public Property Period As Integer
    Public Totals() As Integer

    Dim Generator As Random

    Public Sub New()

        Generator = New Random
        Period = Generator.Next(1, 20)

        'Currently not built out yet b/c not using real period data ALH,
        'need to parse out start/end time strings and go from there

        'Determine Morning or Evening and which period class is in
        'Very bad ugly code!!!! Needs refactoring ALH

        'In order: Evening, Morning, TuesThurs, MonWedFri, MonWed
        Totals = New Integer() {0, 0, 0, 0, 0}

        Select Case Period
            Case 1 To 2 'Monday Morning
                Totals(1) = Totals(1) + 1
                Totals(3) = Totals(3) + 1
            Case 3 To 4 'Monday Evening
                'eveningTotal.Hours = 1
                'monWedFriTotal.Hours = 1
                Totals(0) = Totals(0) + 1
                Totals(3) = Totals(3) + 1
            Case 5 To 6 'Tues Morning
                'morningTotal.Hours = 1
                'tuesThursTotal.Hours = 1
                Totals(1) = Totals(1) + 1
                Totals(2) = Totals(2) + 1
            Case 7 To 8 'Tues Evening
                'eveningTotal.Hours = 1
                'tuesThursTotal.Hours = 1
                Totals(0) = Totals(0) + 1
                Totals(2) = Totals(2) + 1
            Case 9 To 10 'Wed Morning
                'morningTotal.Hours = 1
                'monWedFriTotal.Hours = 1
                Totals(1) = Totals(1) + 1
                Totals(3) = Totals(3) + 1
            Case 11 To 12 'Wed Evening
                'eveningTotal.Hours = 1
                'monWedFriTotal.Hours = 1
                Totals(0) = Totals(0) + 1
                Totals(3) = Totals(3) + 1
            Case 13 To 14 'Thurs Morn
                'morningTotal.Hours = 1
                'tuesThursTotal.Hours = 1
                Totals(1) = Totals(1) + 1
                Totals(2) = Totals(2) + 1
            Case 15 To 16 'Thurs Evening
                'eveningTotal.Hours = 1
                'tuesThursTotal.Hours = 1
                Totals(0) = Totals(0) + 1
                Totals(2) = Totals(2) + 1
            Case 17 To 18 'Fri Morn
                'morningTotal.Hours = 1
                'monWedFriTotal.Hours = 1
                Totals(1) = Totals(1) + 1
                Totals(3) = Totals(3) + 1
            Case 19 To 20 'Fri Evening
                'eveningTotal.Hours = 1
                'monWedFriTotal.Hours = 1
                Totals(0) = Totals(0) + 1
                Totals(3) = Totals(3) + 1
            Case Else
                Throw New Exception
        End Select
    End Sub
End Class

Module AirlineReservationSystem

    Sub Main()
        Dim PegasusAircraft As New Aircraft(1, "Airbus", "A320")
        Dim AnadoluJetAircraft As New Aircraft(1, "Boeing", "737")
        Dim TK2186 As New Flight(1, "TK2186", #2021-6-1#, #13:15:00#, "TZX", "SAW", PegasusAircraft)
        Dim WindowSeat As New Seat(1, "F3", TK2186, "Economic")

        WindowSeat.Book()

        Console.ReadLine()
    End Sub

    Public Class Aircraft
        Private ReadOnly Property Id As Integer
        Private ReadOnly Property NameOfManifacturer As String
        Private ReadOnly Property Model As String
        Private ReadOnly Property NumberOfSeats As Integer

        Public Sub New(id As Integer, nameOfManifacturer As String, model As String)
            Me.Id = id
            Me.NameOfManifacturer = nameOfManifacturer
            Me.Model = model

            If Me.Model = "A320" Then
                Me.NumberOfSeats = 180
            ElseIf Me.Model = "737" Then
                Me.NumberOfSeats = 170
            End If

        End Sub

        Public Sub Takeoff()
            Console.WriteLine(Me.NameOfManifacturer & " " & Me.Model & " is taking off. Id number is " & Me.Id & " and it has " & Me.NumberOfSeats & " seats.")
        End Sub

        Public Sub Land()
            Console.WriteLine(Me.NameOfManifacturer & " " & Me.Model & " is landing.")
        End Sub
    End Class

    Public Class Flight
        Private ReadOnly Property Id As Integer
        Private ReadOnly Property Number As String
        Private ReadOnly Property DateOfDeparture As Date
        Private ReadOnly Property TimeOfDeparture As Date
        Private ReadOnly Property WhereFrom As String
        Private ReadOnly Property WhereTo As String
        Private ReadOnly Property TypeOfAircraft As Aircraft
        Private ReadOnly Property Availability As Boolean

        Public Sub New(id As Integer,
                       number As String,
                       dateOfDeparture As Date,
                       timeOfDeparture As Date,
                       whereFrom As String,
                       whereTo As String,
                       typeOfAircraft As Aircraft)
            Me.Id = id
            Me.Number = number
            Me.DateOfDeparture = dateOfDeparture
            Me.TimeOfDeparture = timeOfDeparture
            Me.WhereFrom = whereFrom
            Me.WhereTo = whereTo
            Me.TypeOfAircraft = typeOfAircraft
        End Sub

        Public Sub Schedule()
            Console.WriteLine("The flight number " & Me.Number & " has been scheduled." & vbCrLf &
                              "Id number is " & Me.Id & vbCrLf &
                              "Departure date is " & Me.DateOfDeparture & vbCrLf &
                              "Departure time is " & Me.TimeOfDeparture)
        End Sub

        Public Sub Delay()
            Console.WriteLine("The flight number " & Me.Number & " has been delayed.")
        End Sub

        Public Sub Cancel()
            Console.WriteLine("The flight number " & Me.Number & " has been canceled.")
        End Sub
    End Class

    Public Class Seat
        Private ReadOnly Property Id As Integer
        Private ReadOnly Property Number As String
        Private ReadOnly Property NumberOfFlight As Flight
        Private ReadOnly Property Type As String
        Private ReadOnly Property Price As Double
        Private ReadOnly Property Availability As Boolean

        Public Sub New(id As Integer, number As String, numberOfFlight As Flight, type As String)
            Me.Id = id
            Me.Number = number
            Me.NumberOfFlight = numberOfFlight
            Me.Type = type

            If Me.Type = "Economic" Then
                Me.Price = 249.99
            ElseIf Me.Type = "Business" Then
                Me.Price = "599.99"
            End If

        End Sub

        Public Sub Book()
            Console.WriteLine("The seat number " & Me.Number & " has been booked." & vbCrLf &
                                "Seat type is " & Me.Type & vbCrLf &
                                "Price is " & Me.Price)
        End Sub
    End Class

End Module

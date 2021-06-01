Module AirlineReservationSystem

    Public Class Aircraft

        Private ReadOnly Property Id() As Integer
        Private ReadOnly Property NameOfManifacturer() As String
        Private ReadOnly Property Model() As String
        Private ReadOnly Property NumberOfSeats() As Integer

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

    Sub Main()
        Dim PegasusAircraft As New Aircraft(1, "Airbus", "A320")
        PegasusAircraft.Takeoff()

        Dim AnadoluJetAircraft As New Aircraft(1, "Boeing", "737")
        AnadoluJetAircraft.Takeoff()

        Console.ReadLine()
    End Sub

End Module

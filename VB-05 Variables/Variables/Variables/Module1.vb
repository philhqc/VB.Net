Module Module1

    Sub Main()

        'Dim x As Integer
        'Dim y As Integer 

        'x = 7
        'y = x + 3

        'Console.WriteLine(y)
        'Console.ReadLine()

        Console.WriteLine("What is your name?")
        Console.Write("Type your first name: ")
        Dim myFirstName As String
        'Dim myFirstName As String = "Bob"

        myFirstName = Console.ReadLine()

        Console.Write("Type your last name: ")
        'Dim myLastName As String
        'myLastName = Console.ReadLine()
        Dim myLastName As String = Console.ReadLine()

        Console.WriteLine("Hello, " & myFirstName & " " & myLastName)
        Console.ReadLine()


    End Sub

End Module

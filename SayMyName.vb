'Jake Burrell
'RCET0265
'Fall 2020
'Say My Name
'https://github.com/burrjake/SayMyName.git

Option Strict On
Option Explicit On
Option Compare Text

Module SayMyName

    Sub Main()
        Dim userMessage As String

        'ask user "What's your name?"
        Console.WriteLine("What's your name?")
        'collect user's message
        userMessage = Console.ReadLine()
        If userMessage = "Jake" Or userMessage = "Jake Burrell" Then
            'display the mssage "Hello, creator." if Jake or Jake Burrell is entered for the name
            Console.WriteLine("Hello, creator.")
        ElseIf userMessage = "Emily" Or userMessage = "Joe" Then
            'dispay the message "Hello, Joe or Emily. When your done press enter."
            Console.WriteLine("Hello, " & userMessage & ". When you're done press enter.")
        Else
            'display the message "Hello there. When your done press enter." if the user is not Jake, Jake Burrell, Emily, or Joe
            Console.WriteLine("Hello there. When your done press enter.")
        End If
        Console.ReadLine()

    End Sub

End Module

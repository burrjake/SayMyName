'Jake Burrell
'RCET0265
'Fall 2020
'Say My Name
'https://github.com/burrjake/SayMyName.git

Option Strict On
Option Explicit On

Module SayMyName

    Sub Main()
        Dim userMessage As String

        'ask user "What's your name?"
        Console.WriteLine("What's your name?")
        'collect user's message
        userMessage = Console.ReadLine()
        'dispay the message "Hello, what user entered when your done press enter."
        Console.WriteLine("Hello, " & userMessage & " when you're done press enter.")
        Console.ReadLine()
    End Sub

End Module

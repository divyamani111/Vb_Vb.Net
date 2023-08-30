Imports System.Text.RegularExpressions
Module Module1
    Sub showMatch(ByVal text As String, ByVal expr As String)
        Console.WriteLine("The Expression: " + expr)
        Dim mc As MatchCollection = Regex.Matches(text, expr)
        Dim m As Match
        For Each m In mc
            Console.WriteLine(m)

        Next m
    End Sub
    Sub Main()
        Dim str As String = "A Thousand Splendid Suns"
        Console.WriteLine("Matching words that start with 's' : ")
        showMatch(str, "\bS\S*")
        Console.WriteLine("Matching words that start with 's' and end with 'd': ")
        showMatch(str, "\bS\S*d\b")
        'replace extra whitespace
        Dim input As String = "Hello   World   "
        Dim pattern As String = "\s+"
        Dim replacement As String = " "
        Dim rgx As Regex = New Regex(pattern)
        Dim result As String = rgx.Replace(input, replacement)
        Console.WriteLine("Original String: {0}", input)
        Console.WriteLine("Replacement String: {0}", result)
        Console.ReadKey()
    End Sub

End Module

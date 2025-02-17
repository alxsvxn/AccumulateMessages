'Alexis Villagran
'RCET0265
'Spring 2025
'ConvertAndValidate
'

Option Explicit On
Option Strict On
Option Compare Binary


Module MessageProgram
    Sub Main(args As String())
        'uncomment to test interactively
        'Test.Manual()
        Test.Auto()
    End Sub

    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String
        'your code her
        Static text As New Text.StringBuilder
        If clear Then
            text.clear()
        ElseIf Not String.IsNullOrEmpty(newMessage) Then
            text.AppendLine(newMessage)
        End If



        Return text.ToString
    End Function


End Module

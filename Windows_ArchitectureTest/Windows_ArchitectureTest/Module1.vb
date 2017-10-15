

Module Module1
    Public Property MyMachineArchitecture As String
    Public Property Arch As String

    Sub Main()

        MyMachineArchitecture = Environment.GetEnvironmentVariable(“PROCESSOR_ARCHITECTURE”).ToString()
        If MyMachineArchitecture = "x86" Then
            Small()
        Else
            Big()
        End If
        Console.WriteLine(Arch)
        Console.Read()

    End Sub

End Module

Module Module1
    Dim CantMonstruos As Integer
    Dim EnfrentamientoAux()

    Function Cargas(Opcion As Integer)
        Dim H As Integer = 1000000
        Dim R As Integer = 1000000

        If Opcion = 0 Then

            Console.Write("Cantidad de monstruos por bando: ")
            CantMonstruos = Console.ReadLine()

            If CantMonstruos < 1 Or CantMonstruos > 200000 Then
                Console.WriteLine("Ingrese una cantidad de monstruos dentro del rango de 1-200000 inclusive")
                CantMonstruos = Console.ReadLine()
            End If

            Return True

        ElseIf (Opcion = 1) Then
            Dim PwHechi(CantMonstruos - 1)
            For A As Integer = 0 To CantMonstruos - 1
                Console.Write("Poder de los monstruos de La hechicera: ")
                PwHechi(A) = Int(Console.ReadLine())
                If PwHechi(A) > H Then
                    Console.WriteLine("Ingrese un nivel de poder del monstruo Menor o igual a " + H)
                    PwHechi(A) = Console.ReadLine()
                End If
            Next

            Return PwHechi

        ElseIf (opcion = 2) Then
            Dim PwRival(CantMonstruos - 1)
            For B As Integer = 0 To CantMonstruos - 1
                Console.Write("Poder de los monstruos del Rival: ")
                PwRival(B) = Int(Console.ReadLine())
                If PwRival(B) > R Then
                    Console.WriteLine("Ingrese un nivel de poder del monstruo Menor o igual a " + R)
                    PwRival(B) = Console.ReadLine()
                End If
            Next

            Return PwRival
        Else
            Dim Entrena(CantMonstruos - 1)
            For i As Integer = 0 To CantMonstruos - 1
                Entrena(i) = i
            Next
            Return Entrena
        End If
    End Function

    Function Batamon(Hechicera(), Rival(), Enfrentamientos()) As Integer
        Dim WinsHex As Integer = 0
        Dim aux As Integer
        Dim aux2 As Integer

        ReDim Preserve Hechicera(CantMonstruos - 1)
        ReDim Preserve Rival(CantMonstruos - 1)
        ReDim Preserve Enfrentamientos(CantMonstruos)
        ReDim Preserve EnfrentamientoAux(CantMonstruos)

        'Dim Aux_Hechicera(CantMonstruos - 1)

        'Aux_Hechicera = Hechicera

        For D As Integer = 0 To CantMonstruos - 1
            For E As Integer = 0 To CantMonstruos - 2

                If Hechicera(E) >= Rival(D) Then

                    aux2 = Enfrentamientos(E + 1)
                    Enfrentamientos(E + 1) = Enfrentamientos(E)
                    Enfrentamientos(E) = aux2

                    aux = Hechicera(E + 1)
                    Hechicera(E + 1) = Hechicera(E)
                    Hechicera(E) = aux

                End If

            Next
        Next

        For F = 0 To CantMonstruos - 1

            Console.WriteLine(Str(Hechicera(F)) + "  " + Str(Rival(F)))

            If Hechicera(F) > Rival(F) Or Hechicera(F) = Rival(F) Then

                WinsHex += 1

            End If
        Next

        Console.WriteLine(" ")

        EnfrentamientoAux = Enfrentamientos

        Return WinsHex
    End Function

    Sub Main()

        Cargas(0)

        Dim Hechicera()
        Dim Rival()
        Dim Enfrentamientos()

        Hechicera = Cargas(1)
        Rival = Cargas(2)
        Enfrentamientos = Cargas(3)

        Console.WriteLine(Batamon(Hechicera, Rival, Enfrentamientos))

        '''Console.WriteLine(CantMonstruos + 1)
        '''For i = 0 To CantMonstruos
        '''    Console.Write(PwMtrHex(i))
        '''    Console.Write("  ")

        '''Next
        '''Console.WriteLine(" ")
        '''For i = 0 To CantMonstruos
        '''    Console.Write(PwMtrRv(i))
        '''    Console.Write("  ")

        '''Next

        '''Console.WriteLine(" ")

        Enfrentamientos = EnfrentamientoAux

        For C As Integer = 0 To CantMonstruos - 1
            Console.Write(Str(Enfrentamientos(C) + 1) + "  ")
        Next
        Console.WriteLine(" ")

        Console.ReadKey()
    End Sub

End Module

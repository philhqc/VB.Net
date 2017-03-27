Module Module1

    ' Champs privé (Private field) : variable acessible
    ' pour toutes les méthodes qui sont à l'intérieur de
    ' ce module (ce fichier .vb).
    Private k As String = ""


    Sub Main()

        Dim j As String = ""

        ' Le For est Un bloc de code. les variables déclarées
        ' à l'intérieur ne peuvent être utilisées à 
        ' l'extérieur.
        For i = 1 To 10
            Console.WriteLine("i: " & i)
            j = i.ToString()
            k = i.ToString()
        Next
        ' À l'extérieur du bloc de code, on est à 
        'l'extérieur du Scope (en français = la portée)
        'Donc la ligne suivante ne fonctionnera pas.
        'Out of scope, même si Intellicence dit sécurité.
        'Console.WriteLine(i)

        ' Le j est déclaré avant le for, donc il sera perçu.
        ' Il va être affiché une seule fois, car à 
        ' l 'extérieur de la boucle.
        Console.WriteLine("j: " & j)
        Console.WriteLine("k: " & k)
        methodeAide()


        Dim monAuto As New Car()
        monAuto.FaitQuelqueChoseImportant()


        ' Le concept d'encapsulation c'est rendre
        ' privé des méthodes afin que l'utilisateur
        ' ne voit pas tout ce qui s'y passe.



        Console.ReadLine()

    End Sub

    Private Sub methodeAide()
        Console.WriteLine("k (via methodeAide): " & k)
    End Sub



End Module

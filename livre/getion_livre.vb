Module getion_livre
    Public Structure Livre
        Dim titre As String
        Dim auteur As String
        Dim ISBN As Integer
    End Structure
    Public Bibliotheque(100) As Livre
    Dim nbLivres As Integer = 0
    Function AjouterLivre(l As Livre) As Boolean
        If nbLivres < 100 And Not IlExiste(l.ISBN) Then
            Bibliotheque(nbLivres) = l
            nbLivres += 1
            Return True
        Else
            Return False
        End If
    End Function
    Sub AfficherLivres(lstISBN As ListBox, lstTitre As ListBox, lstAuteur As ListBox)
        For i As Integer = 0 To nbLivres - 1
            lstISBN.Items.Add(Bibliotheque(i).ISBN)
            lstTitre.Items.Add(Bibliotheque(i).titre)
            lstAuteur.Items.Add(Bibliotheque(i).auteur)
        Next
    End Sub
    Function IlExiste(ISBN As Integer) As Boolean
        For i As Integer = 0 To nbLivres - 1
            If Bibliotheque(i).ISBN = ISBN Then
                Return True
            End If
        Next
        Return False
    End Function
    Sub AfficherLivre2(lstISBN As ListBox, lstTitre As ListBox, lstAuteur As ListBox, ISBN As Integer)
        For i As Integer = 0 To nbLivres - 1
            If Bibliotheque(i).ISBN = ISBN Then
                lstISBN.Items.Add(Bibliotheque(i).ISBN)
                lstTitre.Items.Add(Bibliotheque(i).titre)
                lstAuteur.Items.Add(Bibliotheque(i).auteur)
            End If
        Next
    End Sub
End Module

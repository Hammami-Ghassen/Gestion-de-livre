Public Class Form1
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Dim l As Livre
        l.titre = txtTitre.Text
        l.auteur = txtAuteur.Text
        l.ISBN = Val(txtISBN.Text)
        If AjouterLivre(l) Then
            MsgBox("Livre ajouté")
        Else
            MsgBox("Impossible d'ajiouter le livre")
        End If
    End Sub

    Private Sub btnAfficher_Click(sender As Object, e As EventArgs) Handles btnAfficher.Click
        Form2.Show()
    End Sub
End Class

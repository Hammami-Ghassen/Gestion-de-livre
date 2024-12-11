Imports System.Text.RegularExpressions
Public Class Form1
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        If String.IsNullOrWhiteSpace(txtISBN.Text) Then
            MsgBox("Le champ ISBN doit être rempli", MessageBoxIcon.Warning, "Erreur")
            txtISBN.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtTitre.Text) Then
            MsgBox("Le champ Titre doit être rempli", MessageBoxIcon.Warning, "Erreur")
            txtTitre.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtAuteur.Text) Then
            MsgBox("Le champ Auteur doit être rempli", MessageBoxIcon.Warning, "Erreur")
            txtAuteur.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txtISBN.Text) Then
            MsgBox("Le champ ISBN doit être un nombre", MessageBoxIcon.Warning, "Erreur")
            txtISBN.Focus()
            Exit Sub
        End If
        If Regex.IsMatch(txtAuteur.Text, "\d") Then
            MsgBox("Le champ Auteur ne doit pas contenir des chiffres", MessageBoxIcon.Warning, "Erreur")
            txtAuteur.Focus()
            Exit Sub
        End If


        Dim l As Livre
        l.titre = txtTitre.Text
        l.auteur = txtAuteur.Text
        l.ISBN = Val(txtISBN.Text)
        Select Case AjouterLivre(l)
            Case 0
                MsgBox("Livre ajouté")
            Case 1
                MsgBox("Bibliothéque est plein", MessageBoxIcon.Asterisk, "Erreur")
            Case 2
                MsgBox("Ce livre déja ajouté", MessageBoxIcon.Asterisk, "Erreur")
        End Select
        txtISBN.Clear()
        txtTitre.Clear()
        txtAuteur.Clear()
    End Sub

    Private Sub btnAfficher_Click(sender As Object, e As EventArgs) Handles btnAfficher.Click
        Form2.Show()
    End Sub
End Class

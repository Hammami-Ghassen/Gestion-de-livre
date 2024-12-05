<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Afficher2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dgvLivre = New DataGridView()
        ISBN = New DataGridViewTextBoxColumn()
        Titre = New DataGridViewTextBoxColumn()
        Auteur = New DataGridViewTextBoxColumn()
        CType(dgvLivre, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvLivre
        ' 
        dgvLivre.Columns.AddRange(New DataGridViewColumn() {ISBN, Titre, Auteur})
        dgvLivre.Location = New Point(74, 12)
        dgvLivre.Name = "dgvLivre"
        dgvLivre.Size = New Size(483, 349)
        dgvLivre.TabIndex = 0
        ' 
        ' ISBN
        ' 
        ISBN.HeaderText = "ISBN"
        ISBN.Name = "ISBN"
        ' 
        ' Titre
        ' 
        Titre.HeaderText = "Titre"
        Titre.Name = "Titre"
        ' 
        ' Auteur
        ' 
        Auteur.HeaderText = "Auteur"
        Auteur.Name = "Auteur"
        ' 
        ' Frm_Afficher2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvLivre)
        Name = "Frm_Afficher2"
        Text = "Frm_Afficher2"
        CType(dgvLivre, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvLivre As DataGridView
    Friend WithEvents ISBN As DataGridViewTextBoxColumn
    Friend WithEvents Titre As DataGridViewTextBoxColumn
    Friend WithEvents Auteur As DataGridViewTextBoxColumn
End Class

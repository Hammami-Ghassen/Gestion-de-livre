<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lstAuteur = New ListBox()
        lstTitre = New ListBox()
        lstISBN = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(48, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 25)
        Label1.TabIndex = 1
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(221, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 25)
        Label2.TabIndex = 2
        Label2.Text = "Titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(387, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 25)
        Label3.TabIndex = 3
        Label3.Text = "Auteur"
        ' 
        ' lstAuteur
        ' 
        lstAuteur.FormattingEnabled = True
        lstAuteur.ItemHeight = 15
        lstAuteur.Location = New Point(387, 93)
        lstAuteur.Name = "lstAuteur"
        lstAuteur.Size = New Size(137, 319)
        lstAuteur.TabIndex = 4
        ' 
        ' lstTitre
        ' 
        lstTitre.FormattingEnabled = True
        lstTitre.ItemHeight = 15
        lstTitre.Location = New Point(210, 93)
        lstTitre.Name = "lstTitre"
        lstTitre.Size = New Size(137, 319)
        lstTitre.TabIndex = 5
        ' 
        ' lstISBN
        ' 
        lstISBN.FormattingEnabled = True
        lstISBN.ItemHeight = 15
        lstISBN.Location = New Point(48, 93)
        lstISBN.Name = "lstISBN"
        lstISBN.Size = New Size(137, 319)
        lstISBN.TabIndex = 6
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(545, 480)
        Controls.Add(lstISBN)
        Controls.Add(lstTitre)
        Controls.Add(lstAuteur)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Public WithEvents lstAuteur As ListBox
    Public WithEvents lstTitre As ListBox
    Public WithEvents lstISBN As ListBox
End Class

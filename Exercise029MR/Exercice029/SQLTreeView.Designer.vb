<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SQLTreeView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SQLTreeView))
        Me.btnNouveau = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTitre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChargerDonnéesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FermerApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cBoCategorie = New System.Windows.Forms.ComboBox()
        Me.cBoClassification = New System.Windows.Forms.ComboBox()
        Me.cBoNationalite = New System.Windows.Forms.ComboBox()
        Me.mtxtNumeroFilm = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtDuree = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtAnnee = New System.Windows.Forms.MaskedTextBox()
        Me.cBoLangue = New System.Windows.Forms.ComboBox()
        Me.cBoAccessibilite = New System.Windows.Forms.ComboBox()
        Me.cBoRangee = New System.Windows.Forms.ComboBox()
        Me.numTablette = New System.Windows.Forms.NumericUpDown()
        Me.cBoProducteur = New System.Windows.Forms.ComboBox()
        Me.btnInserer = New System.Windows.Forms.Button()
        Me.btnMiseajour = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCategorie = New System.Windows.Forms.TextBox()
        Me.txtClassification = New System.Windows.Forms.TextBox()
        Me.txtNationalite = New System.Windows.Forms.TextBox()
        Me.txtLangue = New System.Windows.Forms.TextBox()
        Me.txtAccessibilite = New System.Windows.Forms.TextBox()
        Me.txtNomProducteur = New System.Windows.Forms.TextBox()
        Me.txtPrenomProducteur = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.numTablette, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNouveau
        '
        Me.btnNouveau.Location = New System.Drawing.Point(263, 394)
        Me.btnNouveau.Name = "btnNouveau"
        Me.btnNouveau.Size = New System.Drawing.Size(97, 22)
        Me.btnNouveau.TabIndex = 443
        Me.btnNouveau.Text = "Nouveau film"
        Me.btnNouveau.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(264, 350)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 13)
        Me.Label14.TabIndex = 441
        Me.Label14.Text = "Producteur"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(264, 324)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 439
        Me.Label10.Text = "Tablette"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(264, 298)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 437
        Me.Label11.Text = "Rangée"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(264, 271)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 13)
        Me.Label13.TabIndex = 433
        Me.Label13.Text = "Code d'accessibilité"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(264, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 431
        Me.Label6.Text = "Langue"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(264, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 13)
        Me.Label7.TabIndex = 429
        Me.Label7.Text = "Année de production"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(264, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 427
        Me.Label8.Text = "Nationalité"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(264, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 425
        Me.Label9.Text = "Durée"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(264, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 423
        Me.Label4.Text = "Classification"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(264, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 421
        Me.Label5.Text = "Catégorie"
        '
        'txtTitre
        '
        Me.txtTitre.Location = New System.Drawing.Point(376, 81)
        Me.txtTitre.Name = "txtTitre"
        Me.txtTitre.Size = New System.Drawing.Size(282, 20)
        Me.txtTitre.TabIndex = 420
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(264, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 419
        Me.Label3.Text = "Titre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(264, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 417
        Me.Label1.Text = "# de film"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(315, 18)
        Me.Label2.TabIndex = 416
        Me.Label2.Text = "Liste des films par nationalité et catégorie"
        '
        'TreeView2
        '
        Me.TreeView2.Location = New System.Drawing.Point(12, 60)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.Size = New System.Drawing.Size(231, 356)
        Me.TreeView2.TabIndex = 415
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 422)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(705, 214)
        Me.Button4.TabIndex = 444
        Me.Button4.Text = resources.GetString("Button4.Text")
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.FermerApplicationToolStripMenuItem, Me.AProposDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(729, 24)
        Me.MenuStrip1.TabIndex = 445
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChargerDonnéesToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'ChargerDonnéesToolStripMenuItem
        '
        Me.ChargerDonnéesToolStripMenuItem.Name = "ChargerDonnéesToolStripMenuItem"
        Me.ChargerDonnéesToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ChargerDonnéesToolStripMenuItem.Text = "Charger données"
        '
        'FermerApplicationToolStripMenuItem
        '
        Me.FermerApplicationToolStripMenuItem.Name = "FermerApplicationToolStripMenuItem"
        Me.FermerApplicationToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.FermerApplicationToolStripMenuItem.Text = "Fermer application"
        '
        'AProposDeToolStripMenuItem
        '
        Me.AProposDeToolStripMenuItem.Name = "AProposDeToolStripMenuItem"
        Me.AProposDeToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.AProposDeToolStripMenuItem.Text = "A propos de"
        '
        'cBoCategorie
        '
        Me.cBoCategorie.FormattingEnabled = True
        Me.cBoCategorie.Location = New System.Drawing.Point(376, 107)
        Me.cBoCategorie.Name = "cBoCategorie"
        Me.cBoCategorie.Size = New System.Drawing.Size(78, 21)
        Me.cBoCategorie.TabIndex = 446
        '
        'cBoClassification
        '
        Me.cBoClassification.FormattingEnabled = True
        Me.cBoClassification.Location = New System.Drawing.Point(376, 133)
        Me.cBoClassification.Name = "cBoClassification"
        Me.cBoClassification.Size = New System.Drawing.Size(78, 21)
        Me.cBoClassification.TabIndex = 447
        '
        'cBoNationalite
        '
        Me.cBoNationalite.FormattingEnabled = True
        Me.cBoNationalite.Location = New System.Drawing.Point(376, 185)
        Me.cBoNationalite.Name = "cBoNationalite"
        Me.cBoNationalite.Size = New System.Drawing.Size(78, 21)
        Me.cBoNationalite.TabIndex = 449
        '
        'mtxtNumeroFilm
        '
        Me.mtxtNumeroFilm.Location = New System.Drawing.Point(376, 55)
        Me.mtxtNumeroFilm.Mask = "\F00000"
        Me.mtxtNumeroFilm.Name = "mtxtNumeroFilm"
        Me.mtxtNumeroFilm.Size = New System.Drawing.Size(100, 20)
        Me.mtxtNumeroFilm.TabIndex = 450
        '
        'mtxtDuree
        '
        Me.mtxtDuree.Location = New System.Drawing.Point(376, 160)
        Me.mtxtDuree.Mask = "000"
        Me.mtxtDuree.Name = "mtxtDuree"
        Me.mtxtDuree.Size = New System.Drawing.Size(59, 20)
        Me.mtxtDuree.TabIndex = 451
        Me.mtxtDuree.Text = "120"
        '
        'mtxtAnnee
        '
        Me.mtxtAnnee.Location = New System.Drawing.Point(376, 212)
        Me.mtxtAnnee.Mask = "0000"
        Me.mtxtAnnee.Name = "mtxtAnnee"
        Me.mtxtAnnee.Size = New System.Drawing.Size(59, 20)
        Me.mtxtAnnee.TabIndex = 452
        Me.mtxtAnnee.Text = "2012"
        '
        'cBoLangue
        '
        Me.cBoLangue.FormattingEnabled = True
        Me.cBoLangue.Location = New System.Drawing.Point(376, 237)
        Me.cBoLangue.Name = "cBoLangue"
        Me.cBoLangue.Size = New System.Drawing.Size(78, 21)
        Me.cBoLangue.TabIndex = 453
        '
        'cBoAccessibilite
        '
        Me.cBoAccessibilite.FormattingEnabled = True
        Me.cBoAccessibilite.Location = New System.Drawing.Point(376, 263)
        Me.cBoAccessibilite.Name = "cBoAccessibilite"
        Me.cBoAccessibilite.Size = New System.Drawing.Size(78, 21)
        Me.cBoAccessibilite.TabIndex = 454
        '
        'cBoRangee
        '
        Me.cBoRangee.FormattingEnabled = True
        Me.cBoRangee.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.cBoRangee.Location = New System.Drawing.Point(376, 290)
        Me.cBoRangee.Name = "cBoRangee"
        Me.cBoRangee.Size = New System.Drawing.Size(59, 21)
        Me.cBoRangee.TabIndex = 456
        Me.cBoRangee.Text = "A"
        '
        'numTablette
        '
        Me.numTablette.Location = New System.Drawing.Point(376, 316)
        Me.numTablette.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numTablette.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numTablette.Name = "numTablette"
        Me.numTablette.Size = New System.Drawing.Size(59, 20)
        Me.numTablette.TabIndex = 457
        Me.numTablette.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cBoProducteur
        '
        Me.cBoProducteur.FormattingEnabled = True
        Me.cBoProducteur.Location = New System.Drawing.Point(376, 342)
        Me.cBoProducteur.Name = "cBoProducteur"
        Me.cBoProducteur.Size = New System.Drawing.Size(78, 21)
        Me.cBoProducteur.TabIndex = 458
        '
        'btnInserer
        '
        Me.btnInserer.Location = New System.Drawing.Point(366, 394)
        Me.btnInserer.Name = "btnInserer"
        Me.btnInserer.Size = New System.Drawing.Size(113, 22)
        Me.btnInserer.TabIndex = 459
        Me.btnInserer.Text = "Insérer le film"
        Me.btnInserer.UseVisualStyleBackColor = True
        '
        'btnMiseajour
        '
        Me.btnMiseajour.Location = New System.Drawing.Point(485, 394)
        Me.btnMiseajour.Name = "btnMiseajour"
        Me.btnMiseajour.Size = New System.Drawing.Size(113, 22)
        Me.btnMiseajour.TabIndex = 460
        Me.btnMiseajour.Text = "Mise-à-jour du film"
        Me.btnMiseajour.UseVisualStyleBackColor = True
        '
        'btnSupprimer
        '
        Me.btnSupprimer.Location = New System.Drawing.Point(603, 394)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(113, 22)
        Me.btnSupprimer.TabIndex = 461
        Me.btnSupprimer.Text = "Supprimer le film"
        Me.btnSupprimer.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(441, 163)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(189, 13)
        Me.Label15.TabIndex = 462
        Me.Label15.Text = "(3 chiffres, En minutes - défaut de 120)"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(441, 215)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(169, 13)
        Me.Label16.TabIndex = 463
        Me.Label16.Text = "(L'année - 4 chiffres - défaut 2012)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(441, 293)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(167, 13)
        Me.Label17.TabIndex = 464
        Me.Label17.Text = "(Une lettre de A à Z, A par défaut)"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(441, 318)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(164, 13)
        Me.Label18.TabIndex = 465
        Me.Label18.Text = "(Un chiffre de 1 à 5, 1 par défaut)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(482, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(224, 13)
        Me.Label12.TabIndex = 466
        Me.Label12.Text = "(F suivi de 5 chiffres - NE JAMAIS MODIFIER)"
        '
        'txtCategorie
        '
        Me.txtCategorie.BackColor = System.Drawing.SystemColors.Window
        Me.txtCategorie.Enabled = False
        Me.txtCategorie.Location = New System.Drawing.Point(460, 107)
        Me.txtCategorie.Name = "txtCategorie"
        Me.txtCategorie.Size = New System.Drawing.Size(231, 20)
        Me.txtCategorie.TabIndex = 467
        Me.txtCategorie.TabStop = False
        '
        'txtClassification
        '
        Me.txtClassification.BackColor = System.Drawing.SystemColors.Window
        Me.txtClassification.Enabled = False
        Me.txtClassification.Location = New System.Drawing.Point(460, 133)
        Me.txtClassification.Name = "txtClassification"
        Me.txtClassification.Size = New System.Drawing.Size(231, 20)
        Me.txtClassification.TabIndex = 468
        Me.txtClassification.TabStop = False
        '
        'txtNationalite
        '
        Me.txtNationalite.BackColor = System.Drawing.SystemColors.Window
        Me.txtNationalite.Enabled = False
        Me.txtNationalite.Location = New System.Drawing.Point(460, 185)
        Me.txtNationalite.Name = "txtNationalite"
        Me.txtNationalite.Size = New System.Drawing.Size(231, 20)
        Me.txtNationalite.TabIndex = 469
        Me.txtNationalite.TabStop = False
        '
        'txtLangue
        '
        Me.txtLangue.BackColor = System.Drawing.SystemColors.Window
        Me.txtLangue.Enabled = False
        Me.txtLangue.Location = New System.Drawing.Point(460, 237)
        Me.txtLangue.Name = "txtLangue"
        Me.txtLangue.Size = New System.Drawing.Size(231, 20)
        Me.txtLangue.TabIndex = 470
        Me.txtLangue.TabStop = False
        '
        'txtAccessibilite
        '
        Me.txtAccessibilite.BackColor = System.Drawing.SystemColors.Window
        Me.txtAccessibilite.Enabled = False
        Me.txtAccessibilite.Location = New System.Drawing.Point(460, 263)
        Me.txtAccessibilite.Name = "txtAccessibilite"
        Me.txtAccessibilite.Size = New System.Drawing.Size(231, 20)
        Me.txtAccessibilite.TabIndex = 471
        Me.txtAccessibilite.TabStop = False
        '
        'txtNomProducteur
        '
        Me.txtNomProducteur.BackColor = System.Drawing.SystemColors.Window
        Me.txtNomProducteur.Enabled = False
        Me.txtNomProducteur.Location = New System.Drawing.Point(460, 342)
        Me.txtNomProducteur.Name = "txtNomProducteur"
        Me.txtNomProducteur.Size = New System.Drawing.Size(111, 20)
        Me.txtNomProducteur.TabIndex = 472
        Me.txtNomProducteur.TabStop = False
        '
        'txtPrenomProducteur
        '
        Me.txtPrenomProducteur.BackColor = System.Drawing.SystemColors.Window
        Me.txtPrenomProducteur.Enabled = False
        Me.txtPrenomProducteur.Location = New System.Drawing.Point(577, 342)
        Me.txtPrenomProducteur.Name = "txtPrenomProducteur"
        Me.txtPrenomProducteur.Size = New System.Drawing.Size(114, 20)
        Me.txtPrenomProducteur.TabIndex = 473
        Me.txtPrenomProducteur.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(457, 365)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(125, 13)
        Me.Label19.TabIndex = 479
        Me.Label19.Text = "(Producteur 1 par défaut)"
        '
        'SQLTreeView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 636)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtPrenomProducteur)
        Me.Controls.Add(Me.txtNomProducteur)
        Me.Controls.Add(Me.txtAccessibilite)
        Me.Controls.Add(Me.txtLangue)
        Me.Controls.Add(Me.txtNationalite)
        Me.Controls.Add(Me.txtClassification)
        Me.Controls.Add(Me.txtCategorie)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnSupprimer)
        Me.Controls.Add(Me.btnMiseajour)
        Me.Controls.Add(Me.btnInserer)
        Me.Controls.Add(Me.cBoProducteur)
        Me.Controls.Add(Me.numTablette)
        Me.Controls.Add(Me.cBoRangee)
        Me.Controls.Add(Me.cBoAccessibilite)
        Me.Controls.Add(Me.cBoLangue)
        Me.Controls.Add(Me.mtxtAnnee)
        Me.Controls.Add(Me.mtxtDuree)
        Me.Controls.Add(Me.mtxtNumeroFilm)
        Me.Controls.Add(Me.cBoNationalite)
        Me.Controls.Add(Me.cBoClassification)
        Me.Controls.Add(Me.cBoCategorie)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnNouveau)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTitre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TreeView2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SQLTreeView"
        Me.Text = "SQLTreeView"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.numTablette, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNouveau As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTitre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TreeView2 As System.Windows.Forms.TreeView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChargerDonnéesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FermerApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cBoCategorie As System.Windows.Forms.ComboBox
    Friend WithEvents cBoClassification As System.Windows.Forms.ComboBox
    Friend WithEvents cBoNationalite As System.Windows.Forms.ComboBox
    Friend WithEvents mtxtNumeroFilm As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtDuree As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtAnnee As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cBoLangue As System.Windows.Forms.ComboBox
    Friend WithEvents cBoAccessibilite As System.Windows.Forms.ComboBox
    Friend WithEvents cBoRangee As System.Windows.Forms.ComboBox
    Friend WithEvents numTablette As System.Windows.Forms.NumericUpDown
    Friend WithEvents cBoProducteur As System.Windows.Forms.ComboBox
    Friend WithEvents btnInserer As System.Windows.Forms.Button
    Friend WithEvents btnMiseajour As System.Windows.Forms.Button
    Friend WithEvents btnSupprimer As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents AProposDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtCategorie As System.Windows.Forms.TextBox
    Friend WithEvents txtClassification As System.Windows.Forms.TextBox
    Friend WithEvents txtNationalite As System.Windows.Forms.TextBox
    Friend WithEvents txtLangue As System.Windows.Forms.TextBox
    Friend WithEvents txtAccessibilite As System.Windows.Forms.TextBox
    Friend WithEvents txtNomProducteur As System.Windows.Forms.TextBox
    Friend WithEvents txtPrenomProducteur As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As Label
End Class

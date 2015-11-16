//Partie.cs
//Rush Hour
//Programmé par Jean-Philippe Croteau
//Le 14 mai 2013
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RushHour
{
    public partial class FormRushHour : Form
    {
        private Color[] tabCouleur = { Color.Green, Color.Purple, Color.Orange, Color.Red, Color.Blue, Color.Yellow, Color.Cyan, Color.Brown, Color.Pink, Color.Gray, Color.Black, Color.White };
        private Partie jeu;
        private int caseXselectionne;
        private int caseYselectionne;
        private Auto autoSelectionne;

        /// <summary>
        /// Constructeur du FormRushHour
        /// </summary>
        public FormRushHour()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ferme le jeu
        /// </summary>
        private void btnQuiter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Chargement du jeu
        /// </summary>
        private void FormRushHour_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < tlpRushHour.ColumnCount; i++)
            {
                for (int j = 0; j < tlpRushHour.RowCount; j++)
                {
                    PictureBox boite = new PictureBox();
                    boite.Width = tlpRushHour.Width / tlpRushHour.ColumnCount;
                    boite.Height = tlpRushHour.Height / tlpRushHour.RowCount;
                    boite.BackColor = Color.Gray;
                    boite.Margin = new Padding(0, 0, 0, 0);
                    tlpRushHour.Controls.Add(boite, i, j);
                    boite.Click += new System.EventHandler(Case_Click);
                }
            }
            jeu = new Partie(1);
            Actualiser();
            caseXselectionne = 0;
            caseYselectionne = 0;
            autoSelectionne = new Auto(0, 0, 0, 0, 0);
        }

        /// <summary>
        /// Clic sur une case du jeu
        /// </summary>
        private void Case_Click(object sender, EventArgs e)
        {
            int nbauto = 0;
            nbauto = jeu.NbAutodifficulte[jeu.Difficulte];
            Control caseClic = (Control)sender;
            int positionX = tlpRushHour.GetColumn(caseClic);
            int positionY = tlpRushHour.GetRow(caseClic);
            for (int i = 0; i < nbauto; i++)
            {

                if (jeu.LesAutos[i].PositionX == positionX && jeu.LesAutos[i].PositionY == positionY)
                {
                    caseXselectionne = positionX;
                    caseYselectionne = positionY;
                    autoSelectionne = jeu.LesAutos[i];
                }
            }
            for (int i = 0; i < nbauto; i++)
            {
                if (jeu.LesAutos[i] == autoSelectionne)
                {
                    if (autoSelectionne.Orientation == (int)CodeOrientation.Droite)
                    {
                        if (positionX == caseXselectionne + 1 && positionY == caseYselectionne)
                        {
                            if (jeu.PeutAvancer(jeu.LesAutos[i].Couleur))
                            {
                                jeu.LesAutos[jeu.TabJeu[caseXselectionne, caseYselectionne]].Avancer();
                                AutoBouger(positionX, positionY, i);
                            }
                            
                        }
                        else if (positionX == caseXselectionne - 1 && positionY == caseYselectionne)
                        {
                            if (jeu.PeutReculer(jeu.LesAutos[i].Couleur))
                            {
                                jeu.LesAutos[jeu.TabJeu[caseXselectionne, caseYselectionne]].Reculer();
                                AutoBouger(positionX, positionY, i);
                            }
                        }
                    }
                    else if (autoSelectionne.Orientation == (int)CodeOrientation.Bas)
                    {
                        if (positionY == caseYselectionne + 1 && positionX == caseXselectionne)
                        {
                            if (jeu.PeutAvancer(jeu.LesAutos[i].Couleur))
                            {
                                jeu.LesAutos[jeu.TabJeu[caseXselectionne, caseYselectionne]].Avancer();
                                AutoBouger(positionX, positionY, i);
                            }
                        }
                        else if (positionY == caseYselectionne - 1 && positionX == caseXselectionne)
                        {
                            if (jeu.PeutReculer(jeu.LesAutos[i].Couleur))
                            {
                                jeu.LesAutos[jeu.TabJeu[caseXselectionne, caseYselectionne]].Reculer();
                                AutoBouger(positionX, positionY, i);
                            }
                        }
                    }
                }
            }


            Actualiser();
        }

        /// <summary>
        /// Met à jour quelle voiture est sélectionner avec les bonnes positions
        /// </summary>
        /// <param name="positionX">Position en X de la nouvelle case seletionnée</param>
        /// <param name="positionY">Position en Y de la nouvelle case seletionnée</param>
        /// <param name="autoBouger">Couleur de l'auto bouger</param>
        private void AutoBouger(int positionX, int positionY, int autoBouger)
        {
            caseXselectionne = positionX;
            caseYselectionne = positionY;
            autoSelectionne = jeu.LesAutos[autoBouger];
        }

        /// <summary>
        /// Sélection du niveau débutant
        /// </summary>
        private void débutantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartieDebutant();
        }
        /// <summary>
        /// Sélection du niveau intermédiaire
        /// </summary>
        private void intermédiaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartieInter();
        }
        /// <summary>
        /// Sélection du niveau expert
        /// </summary>
        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartieExpert();
        }
        /// <summary>
        /// Débute une partie de niveau débutant
        /// </summary>
        private void PartieDebutant()
        {
            jeu = new Partie(1);
            Actualiser();
        }
        /// <summary>
        /// Débute une partie de niveau intermédiaire
        /// </summary>
        private void PartieInter()
        {
            jeu = new Partie(2);
            Actualiser();
        }
        /// <summary>
        /// Débute une partie de niveau expert
        /// </summary>
        private void PartieExpert()
        {
            jeu = new Partie(3);
            Actualiser();
        }


        /// <summary>
        /// Actualise l'affichage
        /// </summary>
        private void Actualiser()
        {
            jeu.Actualiser();
            for (int i = 0; i < jeu.TabJeu.GetLength(0); i++)
            {
                for (int j = 0; j < jeu.TabJeu.GetLength(1); j++)
                {
                    PictureBox boite = (PictureBox)tlpRushHour.GetControlFromPosition(i, j);
                    boite.BackColor = tabCouleur[jeu.TabJeu[i, j]];
                }
            }
            if (jeu.LesAutos[(int)CodeCouleur.Rouge].PositionX == 5)
            {
                MessageBox.Show("Vous Avez réussi !!!!!!!!!!!!!!!!!");
                int difficulteEnCour = jeu.Difficulte;
                if (difficulteEnCour == 1)
                {
                    PartieInter();
                }
                else
                {
                    PartieExpert();
                }
            }
            pbAutoEnCours.BackColor = tabCouleur[autoSelectionne.Couleur];
        }
    }
}

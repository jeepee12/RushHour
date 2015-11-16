//Partie.cs
//Rush Hour
//Programmé par Jean-Philippe Croteau
//Le 14 mai 2013
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RushHour
{
    enum CodeCouleur { Vert, Mauve, Orange, Rouge, Bleu, Jaune, Cyan, Brun, Rose, Gris, Noir, Blanc };
    class Partie
    {
        private int[,] tabJeu;
        public const int TailleX = 8;
        public const int TailleY = 8;
        private Auto[] lesAutos;
        private int[] nbAutodifficulte = { 0, 8, 9, 10 };
        private int difficulte;

        /// <summary>
        /// Constructeur de la classe Partie
        /// </summary>
        /// <param name="difficulte">Niveau de difficulté(1,2,3)</param>
        public Partie(int difficulte)
        {
            this.difficulte = difficulte;
            this.tabJeu = new int[TailleX, TailleY];
            lesAutos = new Auto[nbAutodifficulte[difficulte]];
            if (difficulte == 1)
            {

                lesAutos[(int)CodeCouleur.Vert] = new Auto(2, 1, 1, (int)CodeOrientation.Droite, (int)CodeCouleur.Vert);
                lesAutos[(int)CodeCouleur.Jaune] = new Auto(3, 6, 1, (int)CodeOrientation.Bas, (int)CodeCouleur.Jaune);
                lesAutos[(int)CodeCouleur.Mauve] = new Auto(3, 1, 2, (int)CodeOrientation.Bas, (int)CodeCouleur.Mauve);
                lesAutos[(int)CodeCouleur.Rouge] = new Auto(2, 2, 3, (int)CodeOrientation.Droite, (int)CodeCouleur.Rouge);
                lesAutos[(int)CodeCouleur.Bleu] = new Auto(3, 4, 2, (int)CodeOrientation.Bas, (int)CodeCouleur.Bleu);
                lesAutos[(int)CodeCouleur.Orange] = new Auto(2, 1, 5, (int)CodeOrientation.Bas, (int)CodeCouleur.Orange);
                lesAutos[(int)CodeCouleur.Cyan] = new Auto(2, 5, 5, (int)CodeOrientation.Droite, (int)CodeCouleur.Cyan);
                lesAutos[(int)CodeCouleur.Brun] = new Auto(3, 3, 6, (int)CodeOrientation.Droite, (int)CodeCouleur.Brun);
            }
            else if (difficulte == 2)
            {
                lesAutos[(int)CodeCouleur.Vert] = new Auto(2, 1, 1, (int)CodeOrientation.Droite, (int)CodeCouleur.Vert);
                lesAutos[(int)CodeCouleur.Cyan] = new Auto(2, 1, 2, (int)CodeOrientation.Droite, (int)CodeCouleur.Cyan);
                lesAutos[(int)CodeCouleur.Orange] = new Auto(2, 3, 1, (int)CodeOrientation.Bas, (int)CodeCouleur.Orange);
                lesAutos[(int)CodeCouleur.Jaune] = new Auto(3, 4, 1, (int)CodeOrientation.Bas, (int)CodeCouleur.Jaune);
                lesAutos[(int)CodeCouleur.Mauve] = new Auto(3, 1, 3, (int)CodeOrientation.Bas, (int)CodeCouleur.Mauve);
                lesAutos[(int)CodeCouleur.Rouge] = new Auto(2, 2, 3, (int)CodeOrientation.Droite, (int)CodeCouleur.Rouge);
                lesAutos[(int)CodeCouleur.Bleu] = new Auto(3, 2, 4, (int)CodeOrientation.Droite, (int)CodeCouleur.Bleu);
                lesAutos[(int)CodeCouleur.Rose] = new Auto(2, 2, 5, (int)CodeOrientation.Droite, (int)CodeCouleur.Rose);
                lesAutos[(int)CodeCouleur.Brun] = new Auto(3, 1, 6, (int)CodeOrientation.Droite, (int)CodeCouleur.Brun);
            }
            else
            {
                lesAutos[(int)CodeCouleur.Vert] = new Auto(2, 1, 1, (int)CodeOrientation.Bas, (int)CodeCouleur.Vert);
                lesAutos[(int)CodeCouleur.Orange] = new Auto(2, 2, 1, (int)CodeOrientation.Droite, (int)CodeCouleur.Orange);
                lesAutos[(int)CodeCouleur.Jaune] = new Auto(3, 4, 1, (int)CodeOrientation.Bas, (int)CodeCouleur.Jaune);
                lesAutos[(int)CodeCouleur.Rouge] = new Auto(2, 1, 3, (int)CodeOrientation.Droite, (int)CodeCouleur.Rouge);
                lesAutos[(int)CodeCouleur.Rose] = new Auto(2, 3, 3, (int)CodeOrientation.Bas, (int)CodeCouleur.Rose);
                lesAutos[(int)CodeCouleur.Gris] = new Auto(2, 4, 4, (int)CodeOrientation.Droite, (int)CodeCouleur.Gris);
                lesAutos[(int)CodeCouleur.Mauve] = new Auto(3, 6, 3, (int)CodeOrientation.Bas, (int)CodeCouleur.Mauve);
                lesAutos[(int)CodeCouleur.Brun] = new Auto(2, 3, 5, (int)CodeOrientation.Bas, (int)CodeCouleur.Brun);
                lesAutos[(int)CodeCouleur.Bleu] = new Auto(3, 4, 6, (int)CodeOrientation.Droite, (int)CodeCouleur.Bleu);
                lesAutos[(int)CodeCouleur.Cyan] = new Auto(2, 2, 2, (int)CodeOrientation.Droite, (int)CodeCouleur.Cyan);
            }
            MettreDefault();
            Actualiser();
        }

        /// <summary>
        /// Actualiser les valeur du code de couleur du jeu
        /// </summary>
        public void Actualiser()
        {
            MettreDefault();
            for (int i = 0; i < nbAutodifficulte[this.difficulte]; i++)
            {
                for (int j = 0; j < lesAutos[i].Longueur; j++)
                {
                    if (lesAutos[i].Orientation == (int)CodeOrientation.Bas)
                    {
                        tabJeu[lesAutos[i].PositionX, lesAutos[i].PositionY + j] = lesAutos[i].Couleur;
                    }
                    else
                    {
                        tabJeu[lesAutos[i].PositionX + j, lesAutos[i].PositionY] = lesAutos[i].Couleur;
                    }
                }
            }
        }

        /// <summary>
        /// met les couleur par défault(tour noir et milieu blanc)
        /// </summary>
        public void MettreDefault()
        {
            //Met TOUT blanc
            for (int i = 0; i < tabJeu.GetLength(0); i++)
            {
                for (int j = 0; j < tabJeu.GetLength(1); j++)
                {
                    tabJeu[i, j] = (int)CodeCouleur.Blanc;
                }
            }
            //met le tour en noir
            for (int i = 0; i < TailleX; i++)
            {
                tabJeu[i, 0] = (int)CodeCouleur.Noir;
                tabJeu[i, 7] = (int)CodeCouleur.Noir;
            }
            for (int i = 0; i < TailleY; i++)
            {
                tabJeu[0, i] = (int)CodeCouleur.Noir;
                tabJeu[7, i] = (int)CodeCouleur.Noir;
            }
            tabJeu[7, 3] = (int)CodeCouleur.Blanc;
        }

        /// <summary>
        /// tableau des codes de couleurs selon leur emplacement
        /// </summary>
        public int[,] TabJeu
        {
            get { return tabJeu; }
            set { tabJeu = value; }
        }

        /// <summary>
        /// tableau des autos du jeu
        /// </summary>
        public Auto[] LesAutos
        {
            get { return lesAutos; }
            set { lesAutos = value; }
        }
        /// <summary>
        /// niveau de difficulté de la partie en cours
        /// </summary>
        public int Difficulte
        {
            get { return difficulte; }
            set { difficulte = value; }
        }
        /// <summary>
        /// le nombre d'auto selon la difficulté
        /// </summary>
        public int[] NbAutodifficulte
        {
            get { return nbAutodifficulte; }
        }

        /// <summary>
        /// Vérifie si l'auto de la couleur passer en paramètre peut avancer
        /// </summary>
        /// <param name="couleurAuto">Couleur de l'auto qu'on veut avancer</param>
        /// <returns>Retourne si c'est possible(true) ou non(false)</returns>
        public bool PeutAvancer(int couleurAuto)
        {
            bool ilPeut = true;
            if (lesAutos[couleurAuto].Orientation == (int)CodeOrientation.Droite)
            {
                if (tabJeu[lesAutos[couleurAuto].PositionX + lesAutos[couleurAuto].Longueur, lesAutos[couleurAuto].PositionY] != (int)CodeCouleur.Blanc)
                {
                    ilPeut = false;
                }
            }
            else
            {
                if (tabJeu[lesAutos[couleurAuto].PositionX, lesAutos[couleurAuto].PositionY + lesAutos[couleurAuto].Longueur] != (int)CodeCouleur.Blanc)
                {
                    ilPeut = false;
                }
            }

            return ilPeut;
        }

        /// <summary>
        /// Vérifie si l'auto de la couleur passer en paramètre peut reculer
        /// </summary>
        /// <param name="couleurAuto">Couleur de l'auto qu'on veut reculer</param>
        /// <returns>Retourne si c'est possible(true) ou non(false)</returns>
        public bool PeutReculer(int couleurAuto)
        {
            bool ilPeut = true;
            if (lesAutos[couleurAuto].Orientation == (int)CodeOrientation.Droite)
            {
                if (tabJeu[lesAutos[couleurAuto].PositionX - 1, lesAutos[couleurAuto].PositionY] != (int)CodeCouleur.Blanc)
                {
                    ilPeut = false;
                }
            }
            else
            {
                if (tabJeu[lesAutos[couleurAuto].PositionX, lesAutos[couleurAuto].PositionY - 1] != (int)CodeCouleur.Blanc)
                {
                    ilPeut = false;
                }

            }
            return ilPeut;
        }
    }
}

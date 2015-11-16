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
    enum CodeOrientation { Bas, Droite };
    class Auto
    {
        private int longueur;
        private int positionX;
        private int positionY;
        private int orientation;
        private int couleur;

        /// <summary>
        /// Constructeur de la classe Auto
        /// </summary>
        /// <param name="longueur">Longueur de l'auto</param>
        /// <param name="positionX">Position en X en haut à gauche de l'auto</param>
        /// <param name="positionY">Position en Y en haut à gauche de l'auto</param>
        /// <param name="orientation">Si l'auto est orienté vers le bas ou vers la droite(enum pour aide)</param>
        /// <param name="couleur">Couleur de l'auto(enum pour aide)</param>
        public Auto(int longueur, int positionX, int positionY, int orientation, int couleur)
        {
            this.longueur = longueur;
            this.positionX = positionX;
            this.positionY = positionY;
            this.orientation = orientation;
            this.couleur = couleur;
        }
        /// <summary>
        /// fait avancer l'auto de 1
        /// </summary>
        public void Avancer()
        {
            if (this.orientation == (int)CodeOrientation.Bas)
            {
                PositionY += 1;
            }
            else
            {
                PositionX += 1;
            }
        }
        /// <summary>
        /// fait reculer l'auto de 1
        /// </summary>
        public void Reculer()
        {
            if (this.orientation == (int)CodeOrientation.Bas)
            {
                PositionY -= 1;
            }
            else
            {
                PositionX -= 1;
            }
        }

        /// <summary>
        /// longeur de l'auto
        /// </summary>
        public int Longueur
        {
            get { return longueur; }
            set { longueur = value; }
        }

        /// <summary>
        /// Position en X en haut à gauche de l'auto
        /// </summary>
        public int PositionX
        {
            get { return positionX; }
            set { positionX = value; }
        }

        /// <summary>
        /// Position en Y en haut à gauche de l'auto
        /// </summary>
        public int PositionY
        {
            get { return positionY; }
            set { positionY = value; }
        }

        /// <summary>
        /// Orientation de l'auto
        /// </summary>
        public int Orientation
        {
            get { return orientation; }
            set { orientation = value; }
        }

        /// <summary>
        /// Couleur de l'auto
        /// </summary>
        public int Couleur
        {
            get { return couleur; }
            set { couleur = value; }
        }
    }
}

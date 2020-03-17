using System;

namespace ConsoleApp2
{
    internal class Cercle : Forme
    {
        public int Rayon { get; set; }

        public override double aire()
        {
            return Math.PI * (Rayon * Rayon);
        }

        public override double perimetre()
        {
            return 2 * Math.PI * Rayon;
        }

        public override string ToString()
        {
            return "Cercle de Rayon " + Rayon + "\nAire = " + aire() + "\nPerimetre = " + perimetre() + "\n";
        }
    }
}
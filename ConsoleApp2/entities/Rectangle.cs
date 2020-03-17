namespace ConsoleApp2
{
    internal class Rectangle : Forme
    {
        public int Largeur { get; set; }
        public int Longueur { get; set; }

        public override double aire()
        {
            return Longueur * Largeur;
        }

        public override double perimetre()
        {
            return 2 * (Longueur + Largeur);
        }

        public override string ToString()
        {
            return "Rectangle de Longueur " + Longueur + " et de Longueur " + Longueur + base.ToString();
        }
    }
}
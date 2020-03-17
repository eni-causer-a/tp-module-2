namespace ConsoleApp2
{
    internal class Carre : Forme
    {
        public int Longueur { get; set; }

        public override double aire()
        {
            return Longueur * Longueur;
        }

        public override double perimetre()
        {
            return 4 * Longueur;
        }
        

        public override string ToString()
        {
            return "Carre de cote " + Longueur  + "\nAire = " + aire() + "\nPerimetre = " + perimetre() + "\n" ;
        }

    }
}
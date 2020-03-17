namespace ConsoleApp2
{
    internal abstract class Forme
    {
        public abstract double aire();
        public abstract double perimetre();

        public override string ToString()
        {
            return "\nAire = " + aire() + "\nPerimetre = " + perimetre() + "\n";
        }
    }


}
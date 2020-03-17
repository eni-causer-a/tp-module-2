using System;

namespace ConsoleApp2
{
    internal class Triangle : Forme
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public override double aire()
        {
            var p = perimetre() / 2;
            return Math.Sqrt(p * (p-A)*(p-B)*(p-C) ) ;
        }

        public override double perimetre()
        {
            return A + B + C;
        }

        public override string ToString()
        {
            return "Triangle de cote A = " + A + " B = " + B + " C = " + C  + base.ToString();
        }
    }
}
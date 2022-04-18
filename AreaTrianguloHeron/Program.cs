using System;
using System.Globalization;

namespace AreaTrianguloHeron
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            string[] lados = Console.ReadLine().Split(" ");
            x.LadoA = double.Parse(lados[0], CultureInfo.InvariantCulture);
            x.LadoB = double.Parse(lados[1], CultureInfo.InvariantCulture);
            x.LadoC = double.Parse(lados[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            lados = Console.ReadLine().Split(" ");
            y.LadoA = double.Parse(lados[0], CultureInfo.InvariantCulture);
            y.LadoB = double.Parse(lados[1], CultureInfo.InvariantCulture);
            y.LadoC = double.Parse(lados[2], CultureInfo.InvariantCulture);

            double semiperimetroX, semiperimetroY, areaX, areaY;

            semiperimetroX = (x.LadoA + x.LadoB + x.LadoC) / 2;
            semiperimetroY = (y.LadoA + y.LadoB + y.LadoC) / 2;
            areaX = semiperimetroX * (semiperimetroX - x.LadoA) * (semiperimetroX - x.LadoB) *
                (semiperimetroX - x.LadoC);
            areaY = semiperimetroY * (semiperimetroY - y.LadoA) * (semiperimetroY - y.LadoB) *
                (semiperimetroY - y.LadoC);

            if (areaX > areaY) Console.WriteLine("O triangulo X possui maior área de {0} ua.", areaX);
            else if (areaX == areaY) Console.WriteLine("Os dois triângulos possuem a mesma área " +
                "de {} ua.", areaX);
            else Console.WriteLine("O triangulo Y possui maior área de {0} ua.", areaY);
        }
    }
}
namespace Kujundid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kujund: ");
            Console.WriteLine("1. Ruut");
            Console.WriteLine("2. Ring");
            Console.WriteLine("3. Ristkülik");
            Console.WriteLine("4. Kolmnurk");

            string tehe = Console.ReadLine();

            switch (tehe)
            {
                case "Ruut":
                    TeeRuut();
                    break;
                case "Ring":
                    TeeRing();
                    break;
                case "Ristkülik":
                    TeeRistkülik();
                    break;
                case "Kolmnurk":
                    Teekolmnurk();
                    break;
                default:
                    Console.WriteLine("Valikut ei tehtud");
                    break;
            }
        }
        private static void Teekolmnurk()
        {
            int side;

            do
            {
                Console.Write("Sisesta kolmnurga külje pikkus: ");
                if (!int.TryParse(Console.ReadLine(), out side) || side <= 0)
                {
                    Console.WriteLine("Pikkus peab olema positiivne");
                }
            }
            while (side <= 0);

            Console.WriteLine();

            for (int i = 1; i <= side; i++)
            {
                for (int k = side; k >= 1; k--)
                {
                    if(k >= i)
                    {
                        Console.Write("* ");
                    }
                    
                }
       
                Console.WriteLine();
            }
            Console.WriteLine($"Kolmnurga pindala on {(Convert.ToDouble(side) * side) / 2 }");
            Console.WriteLine($"Kolmnurga ümbermõõt on {Math.Sqrt((side * side)+(side * side)) + side + side}");
            Console.ReadKey();
        }

        private static void TeeRistkülik()
        {
            int side;
            int side2;

            do
            {
                Console.Write("Sisesta pikkus: ");
                if (!int.TryParse(Console.ReadLine(), out side) || side <= 0)
                {
                    Console.WriteLine("Pikkus peab olema positiivne");
                }
                Console.Write("Sisesta Laius: ");
                if (!int.TryParse(Console.ReadLine(), out side2) || side2 <= 0)
                {
                    Console.WriteLine("Laius peab olema positiivne");
                }
            }
            while (side <= 0 || side2 <= 0);

            Console.WriteLine();

            for (int i = 1; i <= side; i++)
            {
                for (int j = 1; j <= side2; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Ristküliku ümbermõõt on {2 * (side + side2)}");
            Console.WriteLine($"Ristküliku pindala on  {side2 * side}");
        }

        private static void TeeRuut()
        {
            int side;

            do
            {
                Console.Write("Sisesta küljepikkus: ");
                if (!int.TryParse(Console.ReadLine(), out side) || side <= 0)
                {
                    Console.WriteLine("Külje pikkus peab olema positiivne");
                }
            }
            while (side <= 0);

            Console.WriteLine();

            for (int i = 1; i <= side; i++)
            {
                for (int j = 1; j <= side; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Ruudu ümbermõõt on {4 * side}");
            Console.WriteLine($"Ruudi pindala on  {side * side}");
        }

        private static void TeeRing()
        {
            double radius;
            double thickness = 0.4;
            char symbol = '*';

            do
            {
                Console.Write("Sisesta raadius: ");
                if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                {
                    Console.WriteLine("Raadius peab olema positiivne");
                }
            }
            while (radius <= 0);

            Console.WriteLine();
            double rOut = radius + thickness;

            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value <= rOut * rOut)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Ringi pindala on {3.14 * rOut * rOut}");
            Console.WriteLine($"Ringi ümbermõõt on {3.14 * (rOut * 2)}");
            Console.ReadKey();
        }
    }
}
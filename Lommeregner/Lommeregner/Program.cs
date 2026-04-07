namespace Lommeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICaculator calc = new Caculator();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════╗");
                Console.WriteLine("║        Lommeregner       ║");
                Console.WriteLine("╠══════════════════════════╣");
                Console.WriteLine("║  1. Addition (+)         ║");
                Console.WriteLine("║  2. Subtraktion (-)      ║");
                Console.WriteLine("║  3. Multiplikation (×)   ║");
                Console.WriteLine("║  4. Division (÷)         ║");
                Console.WriteLine("║  5. Potens (a^b)         ║");
                Console.WriteLine("║  6. Kvadratrod (√a)      ║");
                Console.WriteLine("║  0. Afslut               ║");
                Console.WriteLine("╚══════════════════════════╝");
                Console.Write("\nVælg operation: ");

                var valg = Console.ReadLine();

                if (valg == "0") break;

                try
                {
                    switch (valg)
                    {
                        case "1":
                            Console.Write("Tal 1: "); int a1 = int.Parse(Console.ReadLine()!);
                            Console.Write("Tal 2: "); int b1 = int.Parse(Console.ReadLine()!);
                            Console.WriteLine($"Resultat: {calc.Add(a1, b1)}");
                            break;
                        case "2":
                            Console.Write("Tal 1: "); int a2 = int.Parse(Console.ReadLine()!);
                            Console.Write("Tal 2: "); int b2 = int.Parse(Console.ReadLine()!);
                            Console.WriteLine($"Resultat: {calc.Subtract(a2, b2)}");
                            break;
                        case "3":
                            Console.Write("Tal 1: "); int a3 = int.Parse(Console.ReadLine()!);
                            Console.Write("Tal 2: "); int b3 = int.Parse(Console.ReadLine()!);
                            Console.WriteLine($"Resultat: {calc.Multiply(a3, b3)}");
                            break;
                        case "4":
                            Console.Write("Tal 1: "); int a4 = int.Parse(Console.ReadLine()!);
                            Console.Write("Tal 2: "); int b4 = int.Parse(Console.ReadLine()!);
                            Console.WriteLine($"Resultat: {calc.Divide(a4, b4):F2}");
                            break;
                        case "5":
                            Console.Write("Base: "); double a5 = double.Parse(Console.ReadLine()!);
                            Console.Write("Eksponent: "); double b5 = double.Parse(Console.ReadLine()!);
                            Console.WriteLine($"Resultat: {calc.Power(a5, b5)}");
                            break;
                        case "6":
                            Console.Write("Tal: "); double a6 = double.Parse(Console.ReadLine()!);
                            Console.WriteLine($"Resultat: {calc.SquareRoot(a6):F4}");
                            break;
                        default:
                            Console.WriteLine("Ugyldigt valg.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Fejl: {ex.Message}");
                }

                Console.Write("\nTryk Enter for at fortsætte...");
                Console.ReadLine();
            }
        }
    }
}

namespace Labb1ckurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapa variabler för namn och ålder och array för fyra saker
            string[] name = new string[4];
            int[] age = new int[4];
            int totalAge = 0;

            // Läs in namn och ålder från användaren
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Ange namn för person {i + 1}: ");
                name[i] = Console.ReadLine();

                Console.Write($"Ange ålder för {name[i]}: ");
                age[i] = Convert.ToInt32(Console.ReadLine());

                // Lägg till åldervärdet i totalålder så vi kan hålla koll
                totalAge += age[i];
            }

            // Beräkna medelåldern med hjälp av totalAge, lär ändra här om vi vill utöka programmet med fler personer
            double averageAge = totalAge / 4.0;

            // Skriv ut namn, ålder och medelålder för varje person och gemensamma ålder
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{name[i]} är {age[i]} år gammal.");
            }

            // Skriv ut den gemensamma medelåldern och total ålder
            Console.WriteLine($"Gemensam medelålder är {averageAge:F2} år.");
            Console.WriteLine($"Gemensam total ålder blir {totalAge}");
        }
    }
}
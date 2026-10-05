namespace ConsoleAppBoucle_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cout = 150;
            double recetteSemaine = 31;
            double recetteTotale = 0;
            int semaines = 0;

            while (recetteTotale <= cout)
            {
                recetteTotale = recetteTotale + recetteSemaine;
                semaines = semaines + 1;

                
                recetteSemaine = recetteSemaine - recetteSemaine * 20 / 100;
            }

            Console.WriteLine("Le film est beneficiaire au bout de " + semaines + " semaines.");
            Console.WriteLine("Recette totale : " + Math.Round(recetteTotale, 2) + " millions d'euros.");
        }
    }
}

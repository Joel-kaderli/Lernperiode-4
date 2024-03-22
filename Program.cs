namespace dictionaries_übung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> einkaufliste = new Dictionary<string, int>();

            while (true) 
            {
                Console.WriteLine("1. Artikel hinzugefügt");
                Console.WriteLine("2. Einkaufsliste anzeigen");
                Console.WriteLine("3. Beenden");

                switch (auswahl)
                {
                    case 1:
                        ArtikelHinzufuegen(einkaufsliste);
                        break;
                    case 2:
                        EinkaufslisteAnzeigen(einkaufsliste);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie erneut.");
                        break;
                }
            }
        }
    }
}
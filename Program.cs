using System;
using System.Collections.Generic;

class EinkaufslisteProgramm
{
    Dictionary<string, int> einkaufsliste = new Dictionary<string, int>();

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("1. Artikel hinzufügen");
            Console.WriteLine("2. Einkaufsliste anzeigen");
            Console.WriteLine("3. Beenden");

            int auswahl = Convert.ToInt32(Console.ReadLine());

            switch (auswahl)
            {
                case 1:
                    ArtikelHinzufuegen();
                    break;
                case 2:
                    EinkaufslisteAnzeigen();
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

    void ArtikelHinzufuegen()
    {
        Console.WriteLine("Geben Sie den Artikelnamen ein:");
        string artikel = Console.ReadLine();

        Console.WriteLine("Geben Sie die Menge ein:");
        int menge = Convert.ToInt32(Console.ReadLine());

        if (einkaufsliste.ContainsKey(artikel))
        {
            einkaufsliste[artikel] += menge;
        }
        else
        {
            einkaufsliste.Add(artikel, menge);
        }

        Console.WriteLine($"{menge} {artikel} wurde zur Einkaufsliste hinzugefügt.");
    }

    void EinkaufslisteAnzeigen()
    {
        if (einkaufsliste.Count == 0)
        {
            Console.WriteLine("Die Einkaufsliste ist leer.");
        }
        else
        {
            Console.WriteLine("Einkaufsliste:");
            foreach (var paar in einkaufsliste)
            {
                Console.WriteLine($"{paar.Key}: {paar.Value}");
            }
        }
    }

    static void Main()
    {
        new EinkaufslisteProgramm().Start();
    }
}
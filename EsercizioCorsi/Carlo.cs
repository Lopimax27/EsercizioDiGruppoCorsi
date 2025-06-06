using System;

// Classe che rappresenta un corso online, derivata da Corso
public class CorsoOnline : Corso
{
    private string piattaforma;
    public string Piattaforma
    {
        get { return piattaforma; }
        set { piattaforma = value; }
    }

    private string linkAccesso;
    public string LinkAccesso
    {
        get { return linkAccesso; }
        set { linkAccesso = value; }
    }

    // Override del metodo per erogare il corso online
    public override void ErogaCorso(List<Studente> studenti)
    {
        // Lista studenti locale (vuota, da implementare)

        Console.WriteLine("Lista studenti:");
        for (int i = 0; i < studenti.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {studenti[i].Nome}");
        }
        Console.Write("Seleziona lo studente a cui assegnare il voto (numero): ");
        int scelta = int.Parse(Console.ReadLine());
        if (scelta > 0 && scelta <= studenti.Count)
        {
            Console.Write($"Inserisci il voto per {studenti[scelta - 1].Nome}: ");
            int voto = int.Parse(Console.ReadLine());
            studenti[scelta - 1].Voto = voto;
            Console.WriteLine($"Voto {voto} assegnato a {studenti[scelta - 1].Nome}.");
        }
        else
        {
            Console.WriteLine("Selezione non valida.");
        }
    }

    // Override del metodo per stampare i dettagli del corso online
    public override void StampaDettagli()
    {
        Console.WriteLine($"Il corso {Titolo} viene erogato sulla piattaforma {Piattaforma} con {LinkAccesso} utilizzato come link d'accesso");
    }

    // Costruttore della classe CorsoOnline
    public CorsoOnline(string _titolo, int _durataOre,List<Studente> studenti, string piattaforma, string linkAccesso) : base(_titolo, _durataOre,studenti)
    {
        Piattaforma = piattaforma;
        LinkAccesso = linkAccesso;
    }
} 
//fate il main caspio
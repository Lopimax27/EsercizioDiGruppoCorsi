using System;

// Classe astratta che rappresenta un corso generico
public abstract class Corso
{
    private string _titolo;
    private int _durataOre;

    // Proprietà per il titolo del corso
    public string Titolo
    {
        get
        {
            return _titolo;
        }
        set
        {
            _titolo = value;
        }
    }

    // Proprietà per la durata del corso in ore
    public int DuratoOre
    {
        get
        {
            return _durataOre;
        }
        set
        {
            // Correzione: assegnare il valore solo se > 0
            if (value > 0)
            {
                _durataOre = value;
            }
            else
            {
                Console.WriteLine("Durata ore non valida");
            }
        }
    }

    // Metodo astratto per erogare il corso
    public abstract void ErogaCorso();

    // Metodo astratto per stampare i dettagli del corso
    public abstract void StampaDettagli();

    // Costruttore della classe Corso
    public Corso(string _titolo, int _durataOre)
    {
        Titolo = _titolo;
        DuratoOre = _durataOre;
    }
}

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
        Console.WriteLine($"Il corso viene erogato sulla piattaforma {Piattaforma} con {LinkAccesso} utilizzato come link d'accesso");
    }

    // Costruttore della classe CorsoOnline
    public CorsoOnline(string _titolo, int _durataOre, string piattaforma, string linkAccesso) : base(_titolo, _durataOre)
    {
        Piattaforma = piattaforma;
        LinkAccesso = linkAccesso;
    }
}
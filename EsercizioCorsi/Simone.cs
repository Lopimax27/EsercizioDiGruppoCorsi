using System;

public class CorsoInPresenza : Corso
{
    private string _aula;
    private int _numeroPosti;

    public string Aula
    {
        get
        {
            return _aula;
        }

        set
        {
            _aula = value;
        }
    }

    public int NumeroPosti
    {
        get
        {
            return _numeroPosti;
        }

        set
        {
            if (value > 0)
            {
                _numeroPosti = value;
            }

            else
            {
                Console.WriteLine("Numero di posti non valido.");
            }
        }
    }

    public override void ErogaCorso(List<Studente> studenti)
    {
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

    public override void StampaDettagli()
    {
        Console.WriteLine($"Corso in presenza | Titolo: {Titolo} | Durata ore: {DuratoOre} | Aula: {Aula} | Numero di posti: {NumeroPosti}");
    }

    public CorsoInPresenza(string titolo, int durata,List<Studente> studenti, string aula, int numeroPosti) : base(titolo, durata,studenti)
    {
        Aula = aula;
        NumeroPosti = numeroPosti;
    }
}

public class Studente
{
    private string _nome;
    private int _eta, _voto;

    public string Nome
    {
        get
        {
            return _nome;
        }

        set
        {
            _nome = value;
        }
    }

    public int Eta
    {
        get
        {
            return _eta;
        }

        set
        {
            if (value > 0)
            {
                _eta = value;
            }

            else
            {
                Console.WriteLine("Età inserita non valida.");
            }
        }
    }

    public int Voto
    {
        get
        {
            return _voto;
        }

        set
        {
            if (value > 0)
            {
                _voto = value;
            }

            else
            {
                Console.WriteLine("Voto inserito non valido.");
            }
        }
    }

    public Studente(string nome, int eta)
    {
        Nome = nome;
        Eta = eta;
    }

    public override string ToString()
    {
        return $"Nome: {Nome} | Età: {Eta}";
    }
}
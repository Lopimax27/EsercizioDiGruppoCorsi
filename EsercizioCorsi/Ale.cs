using System;

public abstract class Corso
{
    private string _titolo;
    private int _durataOre;
    private List<Studente> _studenti;

    public List<Studente> Studenti
    {
        get
        {
            return _studenti;
        }
        set
        {
            _studenti = value;
        }   
    }

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
    public int DuratoOre
    {
        get
        {
            return _durataOre;
        }
        set
        {
            if (value > 0)
            {
                _durataOre=value;
            }
            else
            {
                Console.WriteLine("Durata ore non valida");
            }
        }
    }

    public abstract void ErogaCorso(List<Studente> studenti);
    public abstract void StampaDettagli();

    public Corso(string titolo, int durata,List<Studente> studenti)
    {
        Titolo = titolo;
        DuratoOre = durata;
        Studenti = studenti;
    }
}

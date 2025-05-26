public class Program
{
    public static void Main()
    {
        List<Corso> corsi = new List<Corso>();
        List<Studente> studenti = new List<Studente>();

        bool x = true;

        do
        {
            Console.WriteLine("1.Aggiungi un corso\n2.Visualizza i corsi\n3.Eroga un corso\n4.Aggiunge studente\n0.Uscire");
            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    corsi.Add(InputCorsi());
                    break;
                case 2:
                    StampaCorsi(corsi);
                    break;
                case 3:
                    ErogaCorsi(corsi);
                case 4:
                    AggiungiStudente(corsi);
                    break;
                case 0:
                    x = false;
                    break;
                default:
                    Console.WriteLine("Scelta non valido");
                    break;
            }

        } while (x);
    }
    public static Corso InputCorsi()
    {
        Console.WriteLine("Inserisci il titolo del corso: ");
        string titolo = Console.ReadLine();

        Console.WriteLine("Inserisci la durata ore del corso: ");
        int durata = int.Parse(Console.ReadLine());

        Console.WriteLine("Il corso è online o in presenza 1/2");
        int scelta = int.Parse(Console.ReadLine());

        if (scelta == 1)
        {
            Console.WriteLine("Inserisci l'aula del corso: ");
            string aula = Console.ReadLine();
            Console.WriteLine("Inserisci il numero di posti");
            int numero = int.Parse(Console.ReadLine());

            return new CorsoInPresenza(titolo, durata, aula, numero);
        }
        else if (scelta == 2)
        {
            Console.WriteLine("Inserisci la piattaforma: ");
            string piattaforma = Console.ReadLine();
            Console.WriteLine("Inserisci il link di accesso: ");
            string link = Console.ReadLine();

            return new CorsoOnline(titolo, durata, piattaforma, link);
        }
        return null;
    }

    public static void AggiungiStudente(List<Corso> corsi)
    {
        StampaCorsi(corsi);

        Console.WriteLine("Scegli corso:");
        int scelta = int.Parse(Console.ReadLine());

        corsi[scelta].ErogaCorso(corsi[scelta].Studenti);
    }
}
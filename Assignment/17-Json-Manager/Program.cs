void JasonManager()
{
    Menu();
    Smista(Scelta());
}
int Scelta()
{
    while (true)
    {
        int SceltaUtente = int.Parse(Console.ReadLine());
        if (SceltaUtente < 1 || SceltaUtente > 7)
        {
            continue;
        }
        return SceltaUtente;
    }
}
void Smista(int scelta)
{
    switch (scelta)
    {
        case 1:
            Console.WriteLine("Aggiunto Prodotto");
            AggiungiProdotti();
            break;
        case 2:
            Console.WriteLine("Modifica File");
            ModificaFile();
            break;
        case 3:
            Console.WriteLine("Elimina File");
            EliminaFile();
            break;
        case 4:
            Console.WriteLine("Visualizza File");
            VisualizzaProdotti();
            break;
        case 5:
            Console.WriteLine("5");
            break;
        case 6:
            Console.WriteLine("6");
            break;
        case 7:
            Console.WriteLine("7");
            break;
        default:
            Console.WriteLine("Error");
            break;
    }
}
void Menu()
{
    Console.WriteLine("questo è il menu");
}
void AggiungiProdotti()
{
    Console.WriteLine("aggiunto prodotto");
}
void ModificaFile()
{
    Console.WriteLine("Il file è stato modificato");
}
void EliminaFile()
{
    Console.WriteLine("Il File è stato eliminati");
}
void VisualizzaProdotti()
{
    Console.WriteLine("Il File è stato visualizzato");
}

JasonManager();
public class Prodotti
{
    public string Codice { get; set; }
    public string Nome { get; set; }
    public bool Disponibile { get; set; }
    public int Quantita { get; set; }
    public List<string> Categorie { get; set; }
    public Posizione posizione { get; set; }
}

public class Posizione
{
    public string Magazzino { get; set; }
    public int Scaffale { get; set; }
}

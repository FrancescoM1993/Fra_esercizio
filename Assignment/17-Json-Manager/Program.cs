using Newtonsoft.Json;
string path = @"prodotti/prodotti1.json";


void JasonManager()
{
    Menu();
    Smista(Scelta());
}

int Scelta()
{
    while (true)
    {
        string? input = Console.ReadLine();
        if (input == null)
        {
            continue;
        }
        int SceltaUtente = int.Parse(input);
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
    Console.WriteLine("Questo è il menu");
    Console.WriteLine("1. Aggiungi Prodotto");
    Console.WriteLine("2. Modifica File");
    Console.WriteLine("3. Elimina File");
    Console.WriteLine("4. Visualizza File");
    Console.WriteLine("5. Opzione 5");
    Console.WriteLine("6. Opzione 6");
    Console.WriteLine("7. Opzione 7");
    Console.WriteLine("Scegli un'opzione (1-7):");
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
    if (File.Exists(path))
    {
        File.Delete(path);
        Console.WriteLine("File eliminato con successo.");
    }
}

void VisualizzaProdotti()
{
    if (!File.Exists(path))
    {
        Console.WriteLine("Il file non esiste.");
        return;
    }
    string json = File.ReadAllText(path);
    Prodotti? prodotti = JsonConvert.DeserializeObject<Prodotti>(json);
    if (prodotti == null)
    {
        Console.WriteLine("Nessun prodotto trovato nel file.");
        return;
    }
    Console.WriteLine($"Codice: {prodotti.Codice}");
    Console.WriteLine($"Nome: {prodotti.Nome}");
    Console.WriteLine($"Disponibile: {prodotti.Disponibile}");
    Console.WriteLine($"Quantità: {prodotti.Quantita}");
    if (prodotti.Categorie != null && prodotti.Categorie.Count > 0)
    {
        Console.WriteLine("Categorie:");
        foreach (var categoria in prodotti.Categorie)
        {
            Console.WriteLine($"- {categoria}");
        }
    }
}

JasonManager();
public class Prodotti
{
    public string? Codice { get; set; }
    public string? Nome { get; set; }
    public bool Disponibile { get; set; }
    public int Quantita { get; set; }
    public List<string>? Categorie { get; set; }
    public Posizione? posizione { get; set; }
}

public class Posizione
{
    public string? Magazzino { get; set; }
    public int Scaffale { get; set; }
}

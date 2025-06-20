using Newtonsoft.Json;

string path = @"prodotti";
VerificaCartella(path);
JasonManager();

void VerificaCartella(string Cartella)
{
    if (Directory.Exists(Cartella))
    {
        Console.WriteLine("Cartella esiste");
    }
    else
    {
        Directory.CreateDirectory(Cartella);
    }
}

void JasonManager()
{
    Menu();
    Smista(Scelta());
}

int Scelta()
{
    while (true)
    {
        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Non è stato digitato nulla, riprova.");
            continue;
        }
        else
        {
            int SceltaUtente;
            if (int.TryParse(input, out SceltaUtente))
            {
                if (SceltaUtente < 1 || SceltaUtente > 8)
                {
                    Console.WriteLine("Scelta non valida, riprova.");
                    continue;
                }
                else
                {

                    return SceltaUtente;
                }
            }
            Console.WriteLine($"Scegli");
            Menu();
        }
    }
}

void Smista(int scelta)
{
    switch (scelta)
    {
        case 1:
            AggiungiProdotti();
            break;
        case 2:
            ModificaFile();
            break;
        case 3:
            EliminaFile();
            break;
        case 4:
            VisualizzaCartella();
            break;
        case 5:
            
            VisualizzaContenutoFile();
            break;
        case 6:
            
            VisualizzaProdottiPerCategoria();
            break;
        case 7:
            
            VisualizzaProdottiPerMagazzino();
            break;
        case 8:
            Console.WriteLine("Esci");
            return;
        default:
            Console.WriteLine("Error");
            break;
    }

}

void Menu()
{
    Console.WriteLine("Questo è il menu");
    Console.WriteLine("1. Aggiungi Prodotto");
    Console.WriteLine("2. Modifica Prodotto");
    Console.WriteLine("3. Elimina File");
    Console.WriteLine("4. Visualizza Cartella");
    Console.WriteLine("5. Visualizzare il contenuto di un file");
    Console.WriteLine("6. Visualizzare i prodotti disponibili per categoria");
    Console.WriteLine("7. Visualizzare i prodotti disponibili per magazzino");
    Console.WriteLine("8. Esci");
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("Scegli un'opzione (1-8) 8 per uscire:");
}

void AggiungiProdotti()
{
    var prodotto = new Prodotti
    {
        Codice = LeggiStringa("Codice"),
        Nome = LeggiStringa("Nome prodotto"),
        Quantita = LeggiIntero("Quantità"),
        Disponibile = false,
        Categorie = new List<string> { LeggiStringa("Categoria 1"), LeggiStringa("Categoria 2") },
        Posizione = new Posizione
        {
            Magazzino = LeggiStringa("Magazzino"),
            Scaffale = LeggiIntero("Scaffale")
        }
    };
    prodotto.Disponibile = LeggiBooleano(prodotto.Quantita);

    string json = JsonConvert.SerializeObject(prodotto, Formatting.Indented);
    string filePath = Path.Combine(path, $"{prodotto.Codice}.json");
    File.WriteAllText(filePath, json);
    Console.WriteLine("Prodotto aggiunto!");
}

void ModificaFile()
{
    Console.WriteLine("Inserisci il codice del prodotto da modificare:");
    string codiceProdotto = Console.ReadLine();

    string filePath = Path.Combine(path, $"{codiceProdotto}.json");

    if (!File.Exists(filePath))
    {
        Console.WriteLine("File non trovato!");
        return;
    }

    string json = File.ReadAllText(filePath);
    Prodotti prodotto = JsonConvert.DeserializeObject<Prodotti>(json);

    prodotto.Nome = LeggiStringa("Nuovo nome prodotto");
    prodotto.Quantita = LeggiIntero("Nuova quantità");

    json = JsonConvert.SerializeObject(prodotto, Formatting.Indented);
    File.WriteAllText(filePath, json);
    Console.WriteLine("Prodotto modificato!");
}

void EliminaFile()
{
    Console.WriteLine("Inserisci il codice del prodotto da eliminare:");
    string codiceProdotto = Console.ReadLine();

    string fileToDel = Path.Combine(path, $"{codiceProdotto}.json");

    if (File.Exists(fileToDel))
    {
        Console.WriteLine("Il file esiste, procedo con l'eliminazione...");
        File.Delete(fileToDel);
        Console.WriteLine("File eliminato con successo.");
    }
    else
    {
        Console.WriteLine("Il file non esiste.");
    }
}

void VisualizzaCartella()
{
    string[] fileVisualizzato = Directory.GetFiles(path, "*.json");
    if (fileVisualizzato.Length == 0)
    {
        Console.WriteLine("Nessun prodotto trovato.");
        return;
    }

    foreach (var file in fileVisualizzato)
    {
        string json = File.ReadAllText(file);
        Prodotti prodotto = JsonConvert.DeserializeObject<Prodotti>(json);
        Console.WriteLine($"Codice: {prodotto.Codice}, Nome: {prodotto.Nome}, Quantità: {prodotto.Quantita}");
    }
}

void VisualizzaContenutoFile()
{
    Console.WriteLine("Inserisci il codice del prodotto da visualizzare:");
    string codiceProdotto = Console.ReadLine();

    string filePath = Path.Combine(path, $"{codiceProdotto}.json");

    if (File.Exists(filePath))
    {
        string json = File.ReadAllText(filePath);
        Prodotti prodotto = JsonConvert.DeserializeObject<Prodotti>(json);

        Console.WriteLine($"Codice: {prodotto.Codice}");
        Console.WriteLine($"Nome: {prodotto.Nome}");
        Console.WriteLine($"Disponibile: {prodotto.Disponibile}");
        Console.WriteLine($"Quantità: {prodotto.Quantita}");
    }
    else
    {
        Console.WriteLine("Prodotto non trovato.");
    }
}

void VisualizzaProdottiPerCategoria()
{
    Console.WriteLine("Inserisci la categoria da visualizzare:");
    string categoria = Console.ReadLine();

    string[] fileCategoria = Directory.GetFiles(path, "*.json");
    foreach (var file in fileCategoria)
    {
        string json = File.ReadAllText(file);
        Prodotti prodotto = JsonConvert.DeserializeObject<Prodotti>(json);

        if (prodotto.Categorie.Contains(categoria))
        {
            Console.WriteLine($"Codice: {prodotto.Codice}, Nome: {prodotto.Nome}, Quantità: {prodotto.Quantita}");
        }
        else
        {
            Console.WriteLine("Non è stata trovato nessun prodotto per la categoria");
        }
    }
}

void VisualizzaProdottiPerMagazzino()
{
    Console.WriteLine("Inserisci il magazzino da visualizzare:");
    string magazzino = Console.ReadLine();

    string[] fileMagazzino = Directory.GetFiles(path, "*.json");
    foreach (var file in fileMagazzino)
    {
        string json = File.ReadAllText(file);
        Prodotti prodotto = JsonConvert.DeserializeObject<Prodotti>(json);

        if (prodotto.Posizione.Magazzino == magazzino)
        {
            Console.WriteLine($"Codice: {prodotto.Codice}, Nome: {prodotto.Nome}, Quantità: {prodotto.Quantita}");
        }
        else
        {
            Console.WriteLine("Non è stato trovato nessuna prodotto nel magazzino");
        }
    }
}

string LeggiStringa(string Stringa)
{
    Console.Write($"{Stringa}: ");
    return Console.ReadLine().Trim();
}

int LeggiIntero(string Stringa)
{
    Console.Write($"{Stringa}: ");
    return int.Parse(Console.ReadLine());
}

bool LeggiBooleano(int Intero)
{
    if (Intero > 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

public class Prodotti
{
    public string Codice { get; set; }
    public string Nome { get; set; }
    public bool Disponibile { get; set; }
    public int Quantita { get; set; }
    public List<string> Categorie { get; set; }
    public Posizione Posizione { get; set; }
}

public class Posizione
{
    public string Magazzino { get; set; }
    public int Scaffale { get; set; }
}

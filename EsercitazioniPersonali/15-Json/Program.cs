using Newtonsoft.Json; // importazione della libreria Newtonsoft.Json

// in questo caso il file è nella stessa cartella del programma
// percorso del file json
string path = @"Persona.json";

// In csharp, per leggere un file json, è possibile utilizzare la libreria Newtonsoft.Json

// I files json hanno bisogno di essere serializzati e deserializzati per poter essere utilizzati in csharp.

// dotnet add package Newtonsoft.Json

// I files csharp che usano la libreria Newtonsoft.json devono importare il namespace Newtonsoft.Json

// deserializzo il file json in un oggetto

// Partecipante partecipante = JsonConvert.DeserializeObject<Partecipante>(File.ReadAllText(path));
string json = File.ReadAllText(path); // Leggo il contenuto del file json

// deserializzo con JsonConvert
Partecipante partecipante = JsonConvert.DeserializeObject<Partecipante>(json); // Deserializzo il json in un oggetto Partecipante

// deserializzazione tramite Newtonsoft.Json
// Partecipante partecipante = JsonSerializer.Deserialize<Partecipante>(json); 

// una volta deserializzato, posso accedere ai campi dell'oggetto
Console.WriteLine($"Nome: {partecipante.nome}");
// età
Console.WriteLine($"Età: {partecipante.eta}");
// presente
Console.WriteLine($"Presente: {partecipante.presente}");
// interessi metodo 1 con foreach

/* foreach (var interesse in partecipante.interessi) // per ogni interesse nella lista interessi
{
    Console.WriteLine($"- {interesse}"); // stampo l'interesse
} 
*/

// interessi metodo 2 con string.Join
Console.WriteLine($"Interessi: {string.Join(", ", partecipante.interessi)}"); // stampo gli interessi come stringa

// deserializzo in modo specifico in questo caso indirizzo che è formato da piu campi.
Console.WriteLine($"Indirizzo: {partecipante.indirizzo.via}, {partecipante.indirizzo.citta}, {partecipante.indirizzo.cap}");

// creare la classe Partecipante
public class Partecipante
{
    public string nome { get; set; } // proprietà nome
    public int eta { get; set; } // proprietà età
    public bool presente { get; set; } // proprietà presente
    public List<string> interessi { get; set; } // proprietà interessi, una lista di stringhe
    public Indirizzo indirizzo { get; set; } // proprietà indirizzo, un oggetto di tipo Indirizzo
}

public class Indirizzo
{
    public string via { get; set; } // proprietà via
    public string citta { get; set; } // proprietà città
    public string cap { get; set; } // proprietà cap
}
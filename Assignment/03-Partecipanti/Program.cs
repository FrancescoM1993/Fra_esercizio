// Inizializza una lista di stringhe per memorizzare i nomi dei partecipanti

string partecipante1 = " ";

// Inizializza una variabile per memorizzare il nome dell'utente
string nomeUtente = "Mario"; // Nome dell'utente

// Inizializza una lista di stringhe per memorizzare i nomi dei partecipanti
  var partecipanti = new List<string>() { partecipante1 }; // Dichiarazione e inizializzazione di una lista di stringhe

//ciclo while per chiedere il nome dei partecipanti

int i = 0;
while (i < partecipanti.Count)
{
    Console.WriteLine($"Inserisci il nome del partecipante {i + 1}: ");
    string nome = Console.ReadLine();
    partecipanti[i] = nome;
    i++;
}

// Chiedi all'utente di inserire un nome
Console.WriteLine("Inserisci il nome del partecipante: ");

// Aggiungi il nome alla lista dei partecipanti
string nomePartecipante = Console.ReadLine();
partecipanti.Add(nomePartecipante);

// Se l'inserimento dell'utente è "fine", esci dal ciclo
while (nomePartecipante != "fine")
{
    Console.WriteLine("Inserisci il nome del partecipante: ");
    nomePartecipante = Console.ReadLine();
    if (nomePartecipante == "fine")
    {
    break; 
    }
    partecipanti.Add(nomePartecipante);
}

//stampa l'elenco dei partecipanti
Console.WriteLine("Elenco dei partecipanti:");
foreach (string partecipante in partecipanti)
{
    Console.WriteLine(partecipante);
}


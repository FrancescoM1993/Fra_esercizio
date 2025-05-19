#   ELENCO PARTECIPANTI

- Programma che chiede all'utente di inserire il nome di una serie di partecipanti fino a quando non scriverà "fine".
- Quando l'utente scrive "fine", il programma stampa l'elenco dei partecipanti.

## Suggerimenti

- Utilizzare una lista per memorizzare i nomi dei partecipanti.
- Utilizzare un ciclo `while` per continuare a chiedere i nomi fino a quando non viene inserito "fine".
- Utilizzare il metodo `Add` della lista per aggiungere i nomi alla lista.
- Utilizzare un ciclo `foreach` per stampare i nomi dei partecipanti alla fine.

> TODO: Assicurati di gestire correttamente il caso in cui l'utente non inserisca alcun nome.

## Esempio di codice

// Inizializza una lista di stringhe per memorizzare i nomi dei partecipanti

// Inizializza una variabile per memorizzare il nome dell'utente

// Inizializza un ciclo while per chiedere i nomi dei partecipanti

// Chiedi all'utente di inserire un nome

// Aggiungi il nome alla lista dei partecipanti

// Se l'inserimento dell'utente è "fine", esci dal ciclo

// Stampa l'elenco dei partecipanti

### Esempio di codice (completo)
```csharp
partecipanti = new List<string>(); // Inizializza una lista di stringhe per memorizzare i nomi
string nome; // Inizializza una variabile per il nome che l utente inserirà
while (true) // Inizia un ciclo while
{
    Console.WriteLine("Inserisci il nome del partecipante (o scrivi 'fine' per terminare):"); // Chiedi all utente di inserire un nome
    nome = Console.ReadLine(); // Acquisisci l input dell utente
    if (nome.ToLower() == "fine") // Se l inserimento dell utente è "fine", esci dal ciclo
    {
        break; // Esci dal ciclo
    }
    partecipanti.Add(nome); // Aggiungi il nome alla lista
}
// Stampa l elenco dei partecipanti
Console.WriteLine("Elenco dei partecipanti:");
foreach (string partecipante in partecipanti) // Per ogni partecipante nella lista
{
    Console.WriteLine(partecipante); // Stampa il nome del partecipante
}
```
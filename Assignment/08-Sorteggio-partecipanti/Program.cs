Dictionary<int, List<string>> catalogo = new Dictionary<int, List<string>>();

int idPartecipante = 0;
double dataNascita;

while (true)
{
    Console.WriteLine("Scegli un'opzione:");
    Console.WriteLine("1. Aggiungi un partecipante");
    Console.WriteLine("2. Rimuovi un partecipante");
    Console.WriteLine("3. Visualizza tutti i partecipanti");
    Console.WriteLine("4. Esci");

    string scelta = Console.ReadLine();

    switch (scelta)
    {
        case "1":

            Console.WriteLine("Inserisci il nome del partecipante:");
            string nomePartecipante = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nomePartecipante))
            {
                Console.WriteLine("Il nome del partecipante non può essere vuoto.");
                break;
            }

            Console.WriteLine("Inserisci il cognome del partecipante:");
            string cognomePartecipante = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(cognomePartecipante))
            {
                Console.WriteLine("Il cognome del partecipante non può essere vuoto.");
                break;
            }

            Console.WriteLine("Inserisci la data di nascita:");

            DateTime date = DateTime.Parse(Console.ReadLine());

            if (idPartecipante != 0)
            {
                Console.WriteLine("Data.");
                idPartecipante = double.Parse(Console.ReadLine());
            }
            dataNascita = date.ToString();
            catalogo.Add(idPartecipante, new List<string> { nomePartecipante, cognomePartecipante, dataNascita });
            idPartecipante++;
            break;

        case "2":

            Console.WriteLine("Inserisci l'ID del partecipante da rimuovere:");
            if (int.TryParse(Console.ReadLine(), out int idDaRimuovere) && catalogo.Remove(idDaRimuovere))
            {
                Console.WriteLine($"Prodotto con ID {idDaRimuovere} rimosso.");
            }
            else
            {
                Console.WriteLine($"Nessun prodotto trovato con ID {idDaRimuovere}.");
            }
            break;

        case "3":

            if (catalogo.Count == 0)
            {
                Console.WriteLine("Nessun partecipante disponibile.");
            }
            else
            {
                Console.WriteLine("Elenco dei partecipanti:");
                foreach (var kvp in catalogo)
                {
                    Console.WriteLine($"ID: {kvp.Key} Nome:{string.Join("_", kvp.Value)}");
                }
            }
            break;
        case "4":
            {
                Console.WriteLine("Uscita dal programma.");
            }

            return;
    }
}


    

          
          































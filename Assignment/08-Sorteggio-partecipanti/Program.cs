
int etapartecipante21 = 0
List<string> team = new List<string>();

while (true)
{
    Console.WriteLine("Inserisci il nome del partecipante ('fine' per terminare): ");
    string nome = Console.ReadLine();

}

Console.WriteLine("Inserisci la tua data di nascita");
string dataDiNascita = Console.ReadLine();
DateTime date = DateTime.Parse(dataDiNascita);
Console.WriteLine($"La data convertita e: {date}");

Random numeroRandom = new Random();
int numero = numeroRandom.next(1);





























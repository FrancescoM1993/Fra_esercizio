// tipi di dati
// i tipi di dati possono essere dati semplici o complessi (strutture di dati)

int eta2; // dichiaro una variabile di tipo intero 
eta2 = 30; // inizializzo la variabile di tipo intero

// variabili di tipo intero (si usa questo metodo rispetto a quello di sopra)
int eta = 30; // dichiarazione e inizializzazione della variabile di tipo intero

// variabili di tipo stringa (devo specificare il valore tra gli apici)
string numero = "5"; // dichiarazione e inizializzazione della variabile di tipo stringa

// variabili di tipo char (devo specificare il valore tra gli apici singoli)
char lettera = 'a'; // dichiarazione e inizializzazione della variabile di tipo char

// variabili di tipo float (devo separare gli interi dai decimali con il punto)
float pi = 3.14f; // dichiarazione e inizializzazione della variabile di tipo float

// La differenza tra float e double è che il primo ha una precisione di 7 cifre decimali mentre il secondo di 15
float pi2 = 3.14f; // dichiarazione e inizializzazione della variabile di tipo float
double pi3 = 3.14; // dichiarazione e inizializzazione della variabile di tipo double

// variabili di tipo booleano (con due stati: true o false)
bool maggiorenne = true; // dichiarazione e inizializzazione della variabile di tipo booleano

//eccetto le stringhe che vogliono gli apici doppi
//eccetto i char che vogliono gli apici singoli
//tutti gli altri tipi di dati non vogliono gli apici!!

// variabili di tipo var che permette di dichiarare una variabile senza specificare il tipo
// il tipo viene dedotto dal compilatore in base al valore assegnato
var eta4 = 30; // dichiarazione e inizializzazione della variabile di tipo var     
var nome = "Nome della persona"; // dichiarazione e inizializzazione della variabile di tipo var

// non posso dichiarare una variabile di tipo var senza inizializzarla
// var eta5; // errore: non posso dichiarare una variabile di tipo var senza inizializzarla
// var pero necessita di essere inizializzata al momento della dichiarazione

// variabili di tipo data
DateTime datanascita = new DateTime(1990, 1, 1); // dichiarazione e inizializzazione della variabile di tipo Data
// new é una parola chiave che serve per creare un oggetto (costruttore)

// esempio di utilizzo di una variabile attraverso i metodi di console
Console.WriteLine($"La variabile maggiorenne vale: {maggiorenne}"); // stampo il valore della variabile maggiorenne
Console.WriteLine($"La variabile nome vale: {nome}"); // stampo il valore della variabile nome




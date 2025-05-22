# ARRAY

Calcola la somma di tutti gli elementi di un array di interi e stampa il risultato.

## Suggerimenti

- Inizializza una variabile `somma` a 0 prima del ciclo.
- Utilizza un ciclo `for` per iterare attraverso gli elementi dell'array.
- Aggiungi ogni elemento alla variabile `somma` durante l'iterazione. (usando +=)

## Esempio di codice [solo commenti]

// Definisci un array di interi
// Inizializza la variabile somma a 0
// Utilizza un ciclo for per iterare attraverso gli elementi dell'array
// Aggiungi ogni elemento alla variabile somma
// Stampa il risultato finale

## Esempio di codice (completo)

```csharp

int[] eta = { 26, 12, 3, 33, 8 };
int somma = 0;
for (int i = 0; i < eta.Length; i++)
{
    somma += eta[i];

}
Console.WriteLine($"La somma degli elementi dell'array è: {somma}"); 
```
## Array (Stampa i numeri pari)
Scrivi un programma che crea un array di numeri interi e stampa solo i numeri pari.

## Suggerimenti
- Utilizza un ciclo `for` per iterare attraverso gli elementi dell'array.
- Utilizza l'operatore modulo `if` per verificare se un numero è pari.

## Esempio di codice (solo commenti)

// Definisci un array di numeri interi
// Utilizza un ciclo for per iterare attraverso gli elementi dell'array
// Utilizza l'operatore modulo per verificare se un numero è pari
// Stampa il numero se è pari

## Esempio di codice (completo)

```csharp




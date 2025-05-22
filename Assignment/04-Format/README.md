# FORMAT

Adattare il seguente metodo format per fomattare le stringhe:

```csharp
string nome = "Nome";
int eta = 10;
string frase = string.Format("Il partecipante si chiama {0} e ha {1} anni", nome, eta);
Console.WriteLine(frase); // output: Il partecipante si chiama Nome e ha 10 anni
```
Ad una collezione di nomi ed età.

Otterrò piu frasi ognuna riferita ad un elemento della collezione.

## Suggerimenti
- Esempio di collezione di nomi
```csharp
string[] nomi = { "Nome1", "Nome2", "Nome3" };
```
- Esempio di collezione di età
```csharp   
int[] eta = { 10, 20, 30 };
``` 
- Uso il ciclo forech per iterare su entrambe le collezioni
```csharp
foreach (var nome in nomi)
{
    // codice
}
```



// See https://aka.ms/new-console-template for more information
using System;


///Una volta dichiarato l’array di cibi preferiti
String[] food = { "Sushi", "Pizza", "Lasagne", "Pasta al Forno", "Carbonara" };

//La lunghezza della classifica
Console.WriteLine($"Lungezza lista: {food.Length}");
Console.WriteLine();

Console.WriteLine("Classifica cibi preferiti:");
//La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
for (int i = 0; i < food.Length; i++)
{
    Console.WriteLine($"{i + 1}) {food[i]}");
}

Console.WriteLine();

//Il vostro cibo top (prima posizione della classifica)
Console.WriteLine($"Cibo Top: {food[0]}");
//Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
Console.WriteLine($"Cibo preferito ma non troppo: {food[food.Length - 1]}");
//BONUS Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana. 
Console.WriteLine($"Cibo intermedio: {food[food.Length / 2]}");

Console.WriteLine("Bonus con Array Pari");

Console.WriteLine();
Console.WriteLine();
//Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari. In questo caso vanno stampati i 2 elementi in centro alla vostra classifica.
String[] foodEven = { "Sushi", "Pizza", "Lasagne", "Pasta al Forno", "Carbonara", "Spagetti con le vongole" };

Console.WriteLine($"Cibo intermedio: {food[food.Length / 2]}");
if (foodEven.Length % 2 == 0)
{
    Console.WriteLine($"Cibo intermedio: {food[(food.Length / 2) - 1]}");
}

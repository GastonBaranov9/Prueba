// Clase para representar los estados de un Pokémon
using System;
namespace Program;
public class Estado
{
    public bool Paralizado { get; set; } // Indica si el Pokémon está paralizado
    public bool Dormido { get; set; } // Indica si el Pokémon está dormido
    public bool Envenenado { get; set; } // Indica si el Pokémon está envenenado

    public void AplicarEfecto(Pokemon objetivo)
    {
        if (Paralizado)
        {
            Console.WriteLine($"{objetivo.Nombre} está paralizado y no puede atacar.");
        }
    }

    public void RemoverEfecto(Pokemon objetivo)
    {
        if (Paralizado)
        {
            Console.WriteLine($"{objetivo.Nombre} ya no está paralizado.");
        }
    }
}
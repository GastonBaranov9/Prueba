using System.Collections.Generic;
using System;
namespace Program;

// Clase para representar a un entrenador
public class Entrenador
{
    public string Nombre { get; set; } // Nombre del entrenador
    public List<Pokemon> Pokemons { get; set; } // Lista de Pokémon del entrenador
    public int PuntosDeExperiencia { get; set; } // Puntos de experiencia del entrenador

    public Entrenador(string nombre)
    {
        Nombre = nombre; // Asigna el nombre del entrenador
        Pokemons = new List<Pokemon>(); // Inicializa la lista de Pokémon
    }

    public void ElegirPokemon(int index)
    {
        // Lógica para elegir un Pokémon (validar índice)
        if (index >= 0 && index < Pokemons.Count)
        {
            Console.WriteLine($"{Nombre} ha elegido a {Pokemons[index].Nombre}.");
        }
        else
        {
            Console.WriteLine("Índice de Pokémon inválido.");
        }
    }

    public void CapturarPokemon(Pokemon nuevoPokemon)
    {
        Pokemons.Add(nuevoPokemon); // Añade el nuevo Pokémon a la lista
        Console.WriteLine($"{Nombre} ha capturado a {nuevoPokemon.Nombre}.");
    }
}
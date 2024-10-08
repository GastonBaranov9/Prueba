using System;
namespace Program;

public class Combate
{
    public static void RealizarCombate(Entrenador entrenador1, Entrenador entrenador2)
    {
        // Simulación de combate
        Console.WriteLine("¡Comienza la batalla!");

        // Entrenador 1 elige Pokémon
        entrenador1.ElegirPokemon(0); // Elige al primer Pokémon
        entrenador2.ElegirPokemon(0); // Elige al primer Pokémon del segundo entrenador

        // Simulación de turnos de combate
        var atacante = entrenador1.Pokemons[0];
        var defensor = entrenador2.Pokemons[0];

        // Realiza un ataque normal
        Ataque ataque1 = new Ataque { Nombre = "Impactrueno", Daño = 30 };
        atacante.AtaqueNormal(ataque1, defensor);

        // Realiza un ataque especial
        AtaqueEspecial ataqueEspecial = new AtaqueEspecial { Nombre = "Lanzallamas", Daño = 40 };
        defensor.AtaqueEspecial(ataqueEspecial, atacante);

        // Muestra la vida restante
        Console.WriteLine($"Vida de {defensor.Nombre}: {defensor.Vida}");
        Console.WriteLine($"Vida de {atacante.Nombre}: {atacante.Vida}");
    }
}
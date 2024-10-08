using System;
namespace Program;

class Program
{
    static void Main(string[] args)
    {
        // Crea entrenadores
        Entrenador entrenador1 = new Entrenador("Ash");
        Entrenador entrenador2 = new Entrenador("Misty");

        // Crea Pokémon para los entrenadores
        Pokemon pikachu = new Pokemon("Pikachu", "Eléctrico", 100);
        Pokemon bulbasaur = new Pokemon("Bulbasaur", "Planta", 100);
        Pokemon charmander = new Pokemon("Charmander", "Fuego", 100);
        Pokemon squirtle = new Pokemon("Squirtle", "Agua", 100);

        // Agrega Pokémon a los entrenadores
        entrenador1.CapturarPokemon(pikachu);
        entrenador1.CapturarPokemon(bulbasaur);
        entrenador2.CapturarPokemon(charmander);
        entrenador2.CapturarPokemon(squirtle);

        // Simulación de combate
        Console.WriteLine("¡Comienza la batalla!");
        
        // Entrenador 1 elige Pokémon
        entrenador1.ElegirPokemon(0); // Elige a Pikachu
        entrenador2.ElegirPokemon(1); // Elige a Squirtle

        // Realiza un ataque normal
        Ataque ataque1 = new Ataque { Nombre = "Impactrueno", Daño = 30 };
        pikachu.AtaqueNormal(ataque1, squirtle);

        // Realiza un ataque especial
        AtaqueEspecial ataqueEspecial = new AtaqueEspecial { Nombre = "Lanzallamas", Daño = 40 };
        charmander.AtaqueEspecial(ataqueEspecial, bulbasaur);
        
        // Muestra la vida restante
        Console.WriteLine($"Vida de Squirtle: {squirtle.Vida}");
        Console.WriteLine($"Vida de Bulbasaur: {bulbasaur.Vida}");
    }
}
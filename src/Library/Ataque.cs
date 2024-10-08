// Clase para representar un ataque
using System;
namespace Program;
public class Ataque
{
    public string Nombre { get; set; } // Nombre del ataque
    public int Daño { get; set; } // Daño base del ataque

    public void Atacar(Pokemon enemigo)
    {
        enemigo.Vida -= Daño;
        Console.WriteLine($"{enemigo.Nombre} ha recibido {Daño} de daño.");
    }
}

// Clase para representar un ataque especial
public class AtaqueEspecial : Ataque
{
    public int Potencia { get; set; } // Potencia del ataque especial

    public void AplicarEfectoEstado(Pokemon enemigo)
    {
        Estado estado = new Estado { Paralizado = true }; // Ejemplo de estado
        enemigo.AgregarEstado(estado);
        Console.WriteLine($"{enemigo.Nombre} ha sido paralizado.");
    }
}

// Clase para representar un movimiento
public class Movimiento
{
    public string Nombre { get; set; } // Nombre del movimiento
    public int DañoBase { get; set; } // Daño base del movimiento
    public Tipo TipoMovimiento { get; set; } // Tipo del movimiento

    public void Ejecutar(Pokemon atacante, Pokemon enemigo)
    {
        enemigo.Vida -= DañoBase; // Resta el daño base a la vida del enemigo
        Console.WriteLine($"{enemigo.Nombre} ha recibido {DañoBase} de daño por {Nombre}.");
    }
}


// Clase para representar la resistencia de un Pokémon
public class Resistencia
{
    public string TipoAtaque { get; set; } // Tipo de ataque contra el cual el Pokémon es resistente
    public float FactorResistencia { get; set; } // Factor de resistencia

    public Resistencia(string tipoAtaque, float factorResistencia)
    {
        TipoAtaque = tipoAtaque; // Asigna el tipo de ataque
        FactorResistencia = factorResistencia; // Asigna el factor de resistencia
    }
}

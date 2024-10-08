// Clase para representar un tipo de ataque
using System;
namespace Program;
public class Tipo
{
    public string NombreTipo { get; set; } // Nombre del tipo
    public float MultiplicadorEfectividad { get; set; } // Multiplicador de efectividad

    public float CalcularEfectividad(Tipo enemigo)
    {
        return MultiplicadorEfectividad; // Placeholder
    }
}
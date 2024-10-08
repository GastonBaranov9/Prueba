using System;
using System.Collections.Generic;
namespace Program;
// Clase para representar un Pokémon
public class Pokemon
{
    public string Nombre { get; set; } // Nombre del Pokémon
    public string Tipo { get; set; } // Tipo del Pokémon
    public int Vida { get; set; } // Vida actual del Pokémon
    private List<Estado> estados; // Lista de estados del Pokémon
    public List<Resistencia> Resistencias { get; set; } // Resistencias del Pokémon

    public Pokemon(string nombre, string tipo, int vida)
    {
        Nombre = nombre;
        Tipo = tipo;
        Vida = vida;
        estados = new List<Estado>();
        Resistencias = new List<Resistencia>();
    }

    public void AtaqueNormal(Ataque ataque, Pokemon enemigo)
    {
        float dañoFinal = ataque.Daño;
        foreach (var resistencia in Resistencias)
        {
            if (resistencia.TipoAtaque == ataque.Nombre)
            {
                dañoFinal *= resistencia.FactorResistencia;
                break;
            }
        }
        enemigo.Vida -= (int)dañoFinal;
        Console.WriteLine($"{enemigo.Nombre} ha recibido {dañoFinal} de daño.");
    }

    public void AtaqueEspecial(AtaqueEspecial ataqueEspecial, Pokemon enemigo)
    {
        ataqueEspecial.AplicarEfectoEstado(enemigo);
    }

    public void AgregarEstado(Estado estado)
    {
        estados.Add(estado);
        estado.AplicarEfecto(this);
    }

    public void RemoverEstado(Estado estado)
    {
        estados.Remove(estado);
        estado.RemoverEfecto(this);
    }

    public void AgregarResistencia(Resistencia resistencia)
    {
        Resistencias.Add(resistencia);
    }
}
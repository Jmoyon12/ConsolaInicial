using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class Anime
{
    private string Personaje;
    private string Habilidad;
    private string Escudo;

    public Anime(string Personaje, string Habilidad, string Escudo)
    {
        this.Personaje = Personaje;
        this.Habilidad = Habilidad;
        this.Personaje = Escudo;
    }
    public string Getpersonaje()
    {
        return Personaje;
    }
    public string Gethabilidad()
    {
        return Habilidad;
    }
    public string Getescudo()
    {
        return Escudo;
    }
}

class Caracteristicas : Anime
{
    private string Nombre;
    private string Peso;
    private string Talla;

    public Caracteristicas(string Personaje, string habilidad, string Escudo, string Nombre, string Peso, string Talla) : base(Personaje, habilidad, Escudo)
    {
        this.Nombre = Nombre;
        this.Peso = Peso;
        this.Talla = Talla;

    }
    public string Getnombre()
    {
        return Nombre;
    }
    public string Getpeso()
    {
        return Peso;
    }
    public string Gettalla()
    {
        return Talla;
    }
}

class Prueba
{
    public static void Main()
    {
        Caracteristicas op1 = new Caracteristicas("Tor", "Electricidad", "Martillo", "Steven", "35lb", "38");
        Caracteristicas op2 = new Caracteristicas("Capitan America", "Hielo", "Estrella", "loki", "40lb", "40");
        MostrarCaracteristicas(op1);
        MostrarCaracteristicas(op2);

        Console.ReadKey();
    }
    public static void MostrarCaracteristicas(Caracteristicas o)
    {
        System.Console.WriteLine("Personaje {0}  Habilidad {1}  Escudo {2} Nombre {3}  Peso {4} Talla{5}", o.Getpersonaje(), o.Gethabilidad(), o.Getescudo(), o.Getnombre(), o.Getpeso(), o.Gettalla());
    }
}
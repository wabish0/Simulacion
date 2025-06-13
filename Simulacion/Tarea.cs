using System;
using System.Threading;

public class Tarea
{
    public string Nombre { get; set; }
    public int Duracion { get; set; } 

    public Tarea(string nombre, int duracion)
    {
        Nombre = nombre;
        Duracion = duracion;
    }

    public void Ejecutar()
    {
        Console.WriteLine($"Iniciando tarea: {Nombre}");
        Thread.Sleep(Duracion * 1000);
        Console.WriteLine($"Tarea finalizada: {Nombre}\n");
    }
}

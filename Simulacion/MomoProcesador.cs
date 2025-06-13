using System;
using System.Collections.Generic;

public class Monoprocesador
{
    private List<Tarea> cola_tareas;

    public Monoprocesador()
    {
        cola_tareas = new List<Tarea>();
    }

    public void AgregarTarea(Tarea tarea)
    {
        cola_tareas.Add(tarea);
    }

    public void EjecutarTareas()
    {
        Console.WriteLine("\n== Iniciando ejecución de tareas ==\n");

        foreach (Tarea tarea in cola_tareas)
        {
            tarea.Ejecutar();
        }

        Console.WriteLine("== Todas las tareas han sido completadas ==");
    }
}

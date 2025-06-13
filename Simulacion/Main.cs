using System;

class ProgramaPrincipal
{
    static void Main()
    {
        Monoprocesador mono = new Monoprocesador();

        Console.WriteLine("Simulación de un Monoprocesador\n");

        Console.Write("¿Deseas agregar tareas manualmente? (s/n): ");
        string respuesta = Console.ReadLine();

        if (respuesta.ToLower() == "s")
        {
            string continuar = "s";

            while (continuar.ToLower() == "s")
            {
                Console.Write("Nombre de la tarea: ");
                string nombre = Console.ReadLine();

                Console.Write("Duración en segundos: ");
                int duracion;
                while (!int.TryParse(Console.ReadLine(), out duracion) || duracion < 0)
                {
                    Console.Write("Duración inválida. Ingrese un número válido: ");
                }

                Tarea nueva = new Tarea(nombre, duracion);
                mono.AgregarTarea(nueva);

                Console.Write("¿Deseas agregar otra tarea? (s/n): ");
                continuar = Console.ReadLine();
            }
        }
        else
        {
            // Tareas predeterminadas
            mono.AgregarTarea(new Tarea("Cargar datos", 2));
            mono.AgregarTarea(new Tarea("Procesar datos", 3));
            mono.AgregarTarea(new Tarea("Guardar resultados", 2));
        }

        mono.EjecutarTareas();

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}


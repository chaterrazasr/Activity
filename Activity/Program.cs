using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();

        for (int i = 1; i <= 10; int++)
        {
            numeros.Add(i);
        }

        Console.WriteLine("Elementos de la lista:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numeros);
        }

        if (numeros.Count > 0)
        {
            numeros.RemoveAt(0);
        }
        if (numeros.Count > 0)
        {
            numeros.RemoveAt(numeros.Count - 1);
        }
        Console.WriteLine("\nElementos de la lista después de eliminar el primero y el último:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }


        //Part2
        Dictionary<string, int> estudiantes = new Dictionary<string, int>();

        estudiantes.Add("Juan", 85);
        estudiantes.Add("María", 90);
        estudiantes.Add("Pedro", 78);
        estudiantes.Add("Ana", 92);
        estudiantes.Add("Luis", 88);

        Console.WriteLine("\nPares clave-valor en el diccionario:");
        foreach (var estudiante in estudiantes)
        {
            Console.WriteLine($"Nombre: {estudiante.Key}, Calificación: {estudiante.Value}");
        }

        estudiantes["Pedro"] = 82;

        estudiantes.Remove("Ana");

        Console.WriteLine("\nDiccionario actualizado:");

        foreach (var estudiante in estudiantes)
        {
            Console.WriteLine($"Nombre: {estudiante.Key}, Calificación: {estudiante.Value}");
        }

        //Part 3

        Queue<string> clientes = new Queue<string>();

        clientes.Enqueue("Cliente1");
        clientes.Enqueue("Cliente2");
        clientes.Enqueue("Cliente3");
        clientes.Enqueue("Cliente4");
        clientes.Enqueue("Cliente5");

        Console.WriteLine("\nNombres de clientes en la cola:");
        foreach (string cliente in clientes)
        {
            Console.WriteLine(cliente);
        }

        if (clientes.Count > 0)
        {
            clientes.Dequeue();
        }
        if (clientes.Count > 0)
        {
            clientes.Dequeue();
        }

        Console.WriteLine("\nCola actualizada después de eliminar dos clientes:");
        foreach (string cliente in clientes)
        {
            Console.WriteLine(cliente);
        }

    }
}


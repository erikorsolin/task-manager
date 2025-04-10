﻿using TaskManager.Controller;

using TaskManagerClass = TaskManager.Controller.TaskManager;

class Program
{
    static TaskManagerClass taskManager = new(); 

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nGERENCIADOR DE TAREFAS");
            Console.WriteLine("1. Adicionar Tarefa");
            Console.WriteLine("2. Listar todas as tarefas");
            Console.WriteLine("3. Mover Tarefa");
            Console.WriteLine("4. Remover Tarefa");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddTaskFlow();
                    break;
                case "2":
                    taskManager.ListTasks();
                    break;
                case "3":
                    MoveTaskFlow();
                    break;
                case "4":
                    RemoveTaskFlow();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    static void AddTaskFlow()
    {
        Console.Write("Título: ");
        string title = Console.ReadLine();
        Console.Write("Descrição: ");
        string description = Console.ReadLine(); 
        taskManager.AddTask(title, description);
    }

    static void MoveTaskFlow()
    {
        Console.Write("Digite o ID e o destino: ");
        ?string[] input = Console.ReadLine().Split(' ');
        if (input.Length == 2 && int.TryParse(input[0], out int id))
        {
            string column = input[1].ToLower();
            taskManager.MoveTask(id, column);
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }

    static void RemoveTaskFlow()
    {
        Console.Write("ID da tarefa a remover: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            taskManager.RemoveTask(id);
        }
        else
        {
            Console.WriteLine("ID inválido.");
        }
    }
}
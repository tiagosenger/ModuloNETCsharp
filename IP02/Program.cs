//Sistema de Gerenciamento de Tarefas

using System;
using System.Collections.Generic;
using System.Linq;

class Program{
    static List<Task> tasks = new List<Task>();

    static void Main(){
        
        while (true){
            Console.WriteLine("=== Sistema de Gerenciamento de Tarefas ===");
            Console.WriteLine("1. Criar Tarefa");
            Console.WriteLine("2. Listar Tarefas Pendentes");
            Console.WriteLine("3. Listar Tarefas Concluídas");
            Console.WriteLine("4. Marcar Tarefa como Concluída");
            Console.WriteLine("5. Excluir Tarefa");
            Console.WriteLine("6. Pesquisar Tarefas");
            Console.WriteLine("7. Exibir Estatísticas");
            Console.WriteLine("0. Sair");

            Console.Write("Escolha uma opção: ");
            string choice = Console.ReadLine();

            switch (choice){
                case "1":
                    CreateTask();
                    break;
                case "2":
                    ListPendingTasks();
                    break;
                case "3":
                    ListCompletedTasks();
                    break;
                case "4":
                    MarkTaskAsCompleted();
                    break;
                case "5":
                    DeleteTask();
                    break;
                case "6":
                    SearchTasks();
                    break;
                case "7":
                    DisplayStatistics();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void CreateTask(){
                    
        Console.WriteLine("=== Criar Nova Tarefa ===");

        Console.Write("Digite o título da tarefa: ");
        string title = Console.ReadLine();

        Console.Write("Digite a descrição da tarefa: ");
        string description = Console.ReadLine();

        Console.Write("Digite a data de vencimento (formato: dd/mm/yyyy): ");
        if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dueDate)){
            Task newTask = new Task{
                Title = title,
                Description = description,
                DueDate = dueDate
            };

            tasks.Add(newTask);

            Console.WriteLine("Tarefa criada com sucesso!");
        }
        else{
            Console.WriteLine("Formato de data inválido. Tarefa não criada.");
        }
    }
    
    static void ListPendingTasks(){
        
        Console.WriteLine("=== Lista de Tarefas Pendentes ===");

        var pendingTasks = tasks.Where(task => !task.IsCompleted);

        if (pendingTasks.Any())
        {
            foreach (var task in pendingTasks)
            {
                Console.WriteLine($"ID: {task.Id}\tTítulo: {task.Title}\tDescrição: {task.Description}\tVencimento: {task.DueDate.ToString("dd/MM/yyyy")}");
            }
        }
        else
        {
            Console.WriteLine("Não há tarefas pendentes.");
        }
    }

    static void ListCompletedTasks(){
        // a fazer
    }

    static void MarkTaskAsCompleted(){
       // a fazer
    }

    static void DeleteTask(){
        // a fazer
    }

    static void SearchTasks(){
        // a fazer
    }

    static void DisplayStatistics(){
       // a fazer
    }
}

class Task{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }
    public int Id { get; set; }
    List<Task> tasks = new List<Task>();
}
using System;
namespace Personal_Project
{
    public class Switch
    {
        public Switch()
        {
            List<Todo> Todos = new List<Todo>()
            {
                new Todo { Description = "Task 1", EstimatedHours = 6, Status = Status.Completed },
                new Todo { Description = "Task 2", EstimatedHours = 2, Status = Status.InProgress },
                new Todo { Description = "Task 3", EstimatedHours = 8, Status = Status.NotStarted },
                new Todo { Description = "Task 4", EstimatedHours = 12, Status = Status.Deleted },
                new Todo { Description = "Task 5", EstimatedHours = 6, Status = Status.InProgress },
                new Todo { Description = "Task 6", EstimatedHours = 2, Status = Status.NotStarted },
                new Todo { Description = "Task 7", EstimatedHours = 14, Status = Status.NotStarted },
                new Todo { Description = "Task 8", EstimatedHours = 8, Status = Status.Completed },
                new Todo { Description = "Task 9", EstimatedHours = 8, Status = Status.InProgress },
                new Todo { Description = "Task 10", EstimatedHours = 8, Status = Status.Completed },
                new Todo { Description = "Task 11", EstimatedHours = 4, Status = Status.NotStarted },
                new Todo { Description = "Task 12", EstimatedHours = 10, Status = Status.Completed },
                new Todo { Description = "Task 13", EstimatedHours = 12, Status = Status.Deleted },
                new Todo { Description = "Task 14", EstimatedHours = 6, Status = Status.Completed },

            };

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            PrintAssessment(Todos);
            Console.ReadLine();

        }

        private static void PrintAssessment(List<Todo> todos)
        {
            foreach (var todo in todos)
            {
                switch (todo.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;


                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;


                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;


                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;


                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;


                }

                Console.WriteLine(todo.Description);

            }
        }
    }

    class Todo
    {
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Status Status { get; set; }
    }

    enum Status
    {
        NotStarted,
        InProgress,
        OnHold,
        Completed,
        Deleted
    }
}

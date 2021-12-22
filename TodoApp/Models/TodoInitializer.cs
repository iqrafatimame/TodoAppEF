using TodoApp.Models;
using System;
using System.Linq;

namespace TodoApp.Models
{
    public static class TodoInitializer
    {
        public static void Initialize(TodoContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Todos.Any())
            {
                return;   // DB has been seeded
            }

            var todos = new Todo[]
            {
                new Todo{todoItem="Watch a movie", isCompleted = false },
                new Todo{todoItem="Take out the trash", isCompleted = false},
                new Todo{todoItem="Clean my room",isCompleted = true},
                new Todo{todoItem="Go out for a walk", isCompleted = true},
                new Todo{todoItem="DM Quiz Preparation", isCompleted = false},
            };
            foreach (Todo t in todos)
            {
                context.Todos.Add(t);
            }
            context.SaveChanges();
        }
    }
}
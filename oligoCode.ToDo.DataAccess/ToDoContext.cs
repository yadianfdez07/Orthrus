using oligoCode.ToDo.Model;
using System.Collections.Generic;
using System.Data.Entity;

namespace oligoCode.ToDo.DataAccess
{
    public class ToDoContext : DbContext
    {
        public ToDoContext() : base("ToDoDb")
        {
            Database.SetInitializer(new ToDoDatabaseInitializer());
        }
        public DbSet<ToDoItem> ToDoItems { get; set; }
    }

    public class ToDoDatabaseInitializer : DropCreateDatabaseAlways<ToDoContext>
    {
        protected override void Seed(ToDoContext context)
        {
            context.ToDoItems.AddRange(
                new List<ToDoItem>
                {
                    new ToDoItem{ Id = 1, Description = "ToDoItem 1 Description from DB"},
                    new ToDoItem{ Id = 2, Description = "ToDoItem 2 Description from DB"},
                    new ToDoItem{ Id = 3, Description = "ToDoItem 3 Description from DB"},
                    new ToDoItem{ Id = 4, Description = "ToDoItem 4 Description from DB" }
                });
            base.Seed(context);
        }
    }
}

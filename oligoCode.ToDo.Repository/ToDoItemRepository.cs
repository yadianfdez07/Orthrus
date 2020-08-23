using oligoCode.ToDo.DataAccess;
using oligoCode.ToDo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oligoCode.ToDo.Repository
{
    public class ToDoItemRepository
    {
        private readonly ToDoContext _toDoContext;

        public ToDoItemRepository()
        {
            _toDoContext = new ToDoContext();
        }

        public List<ToDoItem> GetToDoItems()
        {
            return _toDoContext.ToDoItems.ToList();
        }
    }
}

using oligoCode.ToDo.Model;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oligoCode.ToDo.ToDoItemModule
{
    public class ToDoItemListViewModel : BindableBase
    {
        private string message = "ToDoItem list view";

        public string Message { get => message; set => message = value; }

        private ObservableCollection<ToDoItem> toDoItems;
        public ObservableCollection<ToDoItem> ToDoItems
        {
            get { return toDoItems; }
            set { SetProperty(ref toDoItems, value); }
        }

        public ToDoItemListViewModel()
        {
            ToDoItems = new ObservableCollection<ToDoItem>(new List<ToDoItem>{
                new ToDoItem{ Id = 1, Description = "ToDoItem 1 Description"},
                new ToDoItem{ Id = 2, Description = "ToDoItem 2 Description"},
                new ToDoItem{ Id = 3, Description = "ToDoItem 3 Description"},
                new ToDoItem{ Id = 4, Description = "ToDoItem 4 Description" }
                });
        }
    }
}

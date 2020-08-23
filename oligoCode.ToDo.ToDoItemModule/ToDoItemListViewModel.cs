using oligoCode.ToDo.Model;
using oligoCode.ToDo.Repository;
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
        private readonly ToDoItemRepository _repository;

        public ObservableCollection<ToDoItem> ToDoItems
        {
            get { return toDoItems; }
            set { SetProperty(ref toDoItems, value); }
        }

        public ToDoItemListViewModel()
        {
            _repository = new ToDoItemRepository();
            ToDoItems = new ObservableCollection<ToDoItem>(_repository.GetToDoItems());
        }
    }
}

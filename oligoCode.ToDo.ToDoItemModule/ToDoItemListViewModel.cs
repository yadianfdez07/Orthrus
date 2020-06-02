using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oligoCode.ToDo.ToDoItemModule
{
    public class ToDoItemListViewModel : BindableBase
    {
        private string message = "ToDoItem list view";

        public string Message { get => message; set => message = value; }
    }
}

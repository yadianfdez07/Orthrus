﻿using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oligoCode.ToDo.Shell
{
    public class ShellViewModel : BindableBase
    {
        private string _title = "Prism Shell Application";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
    }
}

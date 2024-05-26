using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemoMvvm.Models
{
    public class ToDoItem
    {
        public bool IsChecked { get; set; }
        public string? Content { get; set; }
    }
}

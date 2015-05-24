using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4OOP.MenuEngine;

namespace Lab4OOP.Executables
{
    class CloseMenuExecutable : IExecutable
    {
        Menu _menu;

        public CloseMenuExecutable(Menu menu)
        {
            _menu = menu;
        }

        public void Execute()
        {           
            Console.Clear();
            _menu.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4OOP.MenuEngine;

namespace Lab4OOP.Executables
{
    public class ExitExecutable : IExecutable
    {
        public void Execute()
        {
            Environment.Exit(0);           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4OOP.Domain;
using Lab4OOP.MenuEngine;

namespace Lab4OOP.Executables
{
    class CompleteProductExecutable : IExecutable
    {
        private Product _product;
        private Menu _menu;

        public CompleteProductExecutable(Menu menu, Product product)
        {
            _product = product;
            _menu = menu;
        }

        public void Execute()
        {            
            _product.Status = "Выпущено";
            _product.IsDefective = false;
            new CloseMenuExecutable(_menu).Execute();
        }
    }
}

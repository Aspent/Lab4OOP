using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4OOP.MenuEngine;
using Lab4OOP.Domain;

namespace Lab4OOP.Executables
{
    class UtilizeProductExecutable : IExecutable
    {
        private Product _product;
        private Menu _menu;

        public UtilizeProductExecutable(Menu menu, Product product)
        {
            _product = product;
            _menu = menu;
        }

        public void Execute()
        {
            _product.Status = "Утилизация";
            _product.IsDefective = true;
            new CloseMenuExecutable(_menu).Execute();
        }
    }
}

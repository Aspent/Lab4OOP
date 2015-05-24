using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4OOP.Domain;
using Lab4OOP.MenuEngine;

namespace Lab4OOP.Executables
{
    class RefineProductExecutable : IExecutable
    {
        private Product _product;
        private Menu _menu;

        public RefineProductExecutable(Menu menu, Product product)
        {
            _product = product;
            _menu = menu;
        }

        public void Execute()
        {
            _product.Status = "Дорабатывается";
            _product.IsDefective = true;
            new CloseMenuExecutable(_menu).Execute();
        }
    }
}

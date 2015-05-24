using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4OOP.Domain;
using Lab4OOP.MenuEngine;

namespace Lab4OOP.Executables
{
    class ShowProductsExecutable : IExecutable
    {
        private ProductsRepository _productsRepository;

        public ShowProductsExecutable(ProductsRepository repository)
        {
            _productsRepository = repository;
        }

        public void Execute()
        {
            var products = _productsRepository.GetAll();
            var descriptionPrinter = new DescriptionPrinter(new ProductDescriptionsRepository());
            for (var i = 1; i <= products.Count; i++) 
            {
                Console.WriteLine("{0}: {1}, {2}", i, products[i-1].SerialNumber, products[i-1].ReleaseDateTime);
                Console.WriteLine("Статус: {0}", products[i - 1].Status);
                Console.WriteLine("Номенклатура: ");
                descriptionPrinter.PrintDescription(products[i - 1].Description);
                Console.WriteLine();
            }
        }
    }
}

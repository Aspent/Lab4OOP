using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4OOP.Domain;
using Lab4OOP.MenuEngine;

namespace Lab4OOP.Executables
{
    class DescriptionPrinter
    {
        private readonly ProductDescriptionsRepository _repository;

        public DescriptionPrinter()
        {
            _repository = new ProductDescriptionsRepository();
        }

        public DescriptionPrinter(ProductDescriptionsRepository repository)
        {
            _repository = repository;
        }

        public void PrintByNumber(int number)
        {
            var description = _repository.GetAll()[number - 1];
            Console.WriteLine("Артикул: {0}", description.Article);
            Console.WriteLine("Норма рабочего времени: {0}", description.StandardTime);
            Console.WriteLine("Название: {0}", description.Title);       
        }

        public void PrintAll()
        {
            for(int i=1; i <= _repository.GetAll().Count; i++)
            {
                Console.WriteLine("Введите {0}, чтобы выбрать эту номенклатуру", i);
                PrintByNumber(i);
                Console.WriteLine();
            }
        }

        public void PrintDescription(ProductDescription description)
        {
            Console.WriteLine("Артикул: {0}", description.Article);
            Console.WriteLine("Норма рабочего времени: {0}", description.StandardTime);
            Console.WriteLine("Название: {0}", description.Title);
        }
    }
}

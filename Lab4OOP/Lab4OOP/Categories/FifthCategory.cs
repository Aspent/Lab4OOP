using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4OOP.Domain;

namespace Lab4OOP.Categories
{
    class FifthCategory : ICategory
    {
        public bool Belongs(Batch batch)
        {
            return true;
        }
    }
}

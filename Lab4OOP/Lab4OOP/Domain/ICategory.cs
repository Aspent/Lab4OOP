﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4OOP.Domain
{
    interface ICategory
    {
        bool Belongs(Batch batch);
    }
}

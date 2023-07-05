﻿using AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class ModernFurnitureFactory : IFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }
    }
}

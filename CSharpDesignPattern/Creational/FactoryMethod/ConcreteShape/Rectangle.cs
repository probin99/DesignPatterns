﻿using CSharpDesignPattern.Creational.FactoryMethod.CommonInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern.Creational.FactoryMethod.ConcreteShape
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("This is RECTANGLE");
        }
    }
}

using CSharpDesignPattern.Creational.AbstractFactory.CommonInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern.Creational.AbstractFactory.DerivedClasses.IShapeDerivedClass
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("This is Square");
        }
    }
}

using CSharpDesignPattern.Creational.AbstractFactory.CommonInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern.Creational.AbstractFactory.DerivedClasses.IColorDerivedClass
{
    public class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Color is GREEN");
        }
    }
}

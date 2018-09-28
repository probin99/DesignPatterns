using CSharpDesignPattern.Creational.AbstractFactory.DerivedClasses.AbstractFactoryClass;
using CSharpDesignPattern.Creational.AbstractFactory.DerivedClasses.AbstractFactoryDerivedClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern.Creational.AbstractFactory.FactoryProducer
{
    public class FactoryProducerClass
    {
        public static AbstractFactoryclass GetFactory(string factoryType)
        {
            if(string.IsNullOrEmpty(factoryType))
            {
                return null;
            }
            else
            {
                string stringToLower = factoryType.ToLower();
                if(stringToLower == "shape")
                {
                    return new ShapeFactory();
                }
                else if(stringToLower == "color")
                {
                    return new ColorFactory();
                }
                else
                {
                    return null;
                }
            }
        }
    }
}

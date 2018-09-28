using CSharpDesignPattern.Creational.AbstractFactory.CommonInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern.Creational.AbstractFactory.DerivedClasses.AbstractFactoryClass
{
    public abstract class AbstractFactoryclass
    {
        public abstract IShape GetShape(string shapeStyle);
        public abstract IColor GetColor(string colorStyle);
    }
}

using CSharpDesignPattern.Creational.AbstractFactory.CommonInterface;
using CSharpDesignPattern.Creational.AbstractFactory.DerivedClasses.AbstractFactoryClass;
using CSharpDesignPattern.Creational.AbstractFactory.DerivedClasses.IShapeDerivedClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern.Creational.AbstractFactory.DerivedClasses.AbstractFactoryDerivedClass
{
    class ShapeFactory: AbstractFactoryclass
    {
        public override IShape GetShape(string shapeStyle)
        {
            if (string.IsNullOrEmpty(shapeStyle))
            {
                return null;
            }
            else
            {
                string stringToLower = shapeStyle.ToLower();
                if(stringToLower == "rectangle")
                {
                    return new Rectangle();
                }
                else if(stringToLower == "circle")
                {
                    return new Circle();
                }
                else if(stringToLower == "square")
                {
                    return new Square();
                }
                else
                {
                    return null;
                }
            }
        }
        public override IColor GetColor(string shapeStyle)
        {
            return null;
        }
    }
}

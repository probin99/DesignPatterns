using CSharpDesignPattern.Creational.FactoryMethod.CommonInterface;
using CSharpDesignPattern.Creational.FactoryMethod.ConcreteShape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern.Creational.FactoryMethod.Factory
{
    public class CreateShape
    {
        public IShape GetShape(string shapeType)
        {
            if(string.IsNullOrEmpty(shapeType))
            {
                return null;
            }
            else
            {
                string stringToLower = shapeType.ToLower();
                if (stringToLower == "rectangle")
                {
                    return new Rectangle();
                }
                else if (stringToLower == "circle")
                {
                    return new Circle();
                }
                else if (stringToLower == "square")
                {
                    return new Square();
                }
                else
                {
                    return null;
                }
            }
        }
    }
}

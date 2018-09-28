using CSharpDesignPattern.Creational.AbstractFactory.CommonInterface;
using CSharpDesignPattern.Creational.AbstractFactory.DerivedClasses.AbstractFactoryClass;
using CSharpDesignPattern.Creational.AbstractFactory.DerivedClasses.IColorDerivedClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern.Creational.AbstractFactory.DerivedClasses.AbstractFactoryDerivedClass
{
    public class ColorFactory : AbstractFactoryclass
    {
        public override IColor GetColor(string colorStyle)
        {
            if(string.IsNullOrEmpty(colorStyle))
            {
                return null;
            }
            else
            {
                string stringToLower = colorStyle.ToLower();
                if(stringToLower == "red")
                {
                    return new Red();
                }
                else if(stringToLower == "green")
                {
                    return new Green();
                }
                else if (stringToLower == "blue")
                {
                    return new Blue();
                }
                else
                {
                    return null;
                }
            }
        }

        public override IShape GetShape(string shapeStyle)
        {
            return null;
        }
    }
}

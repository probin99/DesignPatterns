using CSharpDesignPattern.Creational.AbstractFactory.CommonInterface;
using CSharpDesignPattern.Creational.AbstractFactory.DerivedClasses.AbstractFactoryClass;
using CSharpDesignPattern.Creational.AbstractFactory.FactoryProducer;
using CSharpDesignPattern.Creational.FactoryMethod.Factory;
using CSharpDesignPattern.Creational.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creational Design Pattern Types
            //1. Singleton
            // One class is responsible for creating one object which contains
            Message message = Message.GetObject();
            message.PrintMessage();



            ////2. Factory Method
            //CreateShape createShape = new CreateShape();
            ////Create Rectangle
            //IShape shapeA = createShape.GetShape("Rectangle");
            //shapeA.Draw();
            ////Create Circle
            //IShape shapeB = createShape.GetShape("Circle");
            //shapeB.Draw();
            ////Create Square
            //IShape shapeC = createShape.GetShape("Square");
            //shapeC.Draw();



            ////3. Abstract Factory
            //AbstractFactoryclass shapeFactory = FactoryProducerClass.GetFactory("Shape");
            //IShape shapeA = shapeFactory.GetShape("Rectangle");
            //shapeA.Draw();

            //IShape shapeB = shapeFactory.GetShape("Circle");
            //shapeB.Draw();

            //IShape shapeC = shapeFactory.GetShape("Square");
            //shapeC.Draw();

            //AbstractFactoryclass colorFactory = FactoryProducerClass.GetFactory("Color");
            //IColor colorA = colorFactory.GetColor("Red");
            //colorA.Fill();

            //IColor colorB = colorFactory.GetColor("Green");
            //colorB.Fill();

            //IColor colorC = colorFactory.GetColor("Blue");
            //colorC.Fill();

            //Hold Screen
            Console.ReadLine();
        }
    }
}

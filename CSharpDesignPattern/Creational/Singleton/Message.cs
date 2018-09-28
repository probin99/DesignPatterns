using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern.Creational.Message
{
    public class Message
    {
        //private static object of current class so that only one object is created
        private static Message message = new Message();
       
        //private consttructor so that class cannot be instantiated
        private Message()
        {

        }

        //public static class type method to get the object of class
        public static Message getObject()
        {
            return message;
        }

        //other accessible methods to perform some operation
        public void PrintMessage()
        {
            Console.WriteLine("Hello World");
        }
    }
}

using System;
using System.Linq;
using Creational.CreationSingleton;
using Creational.CreationSingleton.Factory.FactoryMethod;
using Creational.CreationSingleton.Factory.SimpleFactory;
using Creational.DependencyInjection;

namespace LearningDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns");

            /*string value = "alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta";
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException();
             
            var expected = value.Split(" ")
                .Distinct();
               
            Console.WriteLine(string.Join(" ", expected));*/

            string val1 = "F6EL9S fgasd ";
            var valArr = StringToArray(val1);

            Console.WriteLine("Singleton");

            /*Console.WriteLine("Singleton");
            var singletonObj = Singleton.GetInstance;
            singletonObj.ShowMessage("Hi Singleton");
            var singletonObj2 = Singleton.GetInstance;
            singletonObj2.ShowMessage($"{2} time called");*/

            /*AccessPoint _accessPoint = new AccessPoint();
            _accessPoint.Start();
            Console.ReadKey(true);*/

            /*
            FactoryMethodAccessPoint factoryMethodAccessPoint = new FactoryMethodAccessPoint();
            factoryMethodAccessPoint.Start(); */

            //Startup.Start();
        }

        public static string[] StringToArray(string str)
        {
            //if (string.IsNullOrWhiteSpace(str))
                return str.Split(' ');
            //return str.Split(" ").Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
        }
    }
}

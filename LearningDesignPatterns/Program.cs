using System;
using Creational.CreationSingleton;
using Creational.CreationSingleton.Factory.FactoryMethod;
using Creational.CreationSingleton.Factory.SimpleFactory;

namespace LearningDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns");
            /*Console.WriteLine("Singleton");
            var singletonObj = Singleton.GetInstance;
            singletonObj.ShowMessage("Hi Singleton");
            var singletonObj2 = Singleton.GetInstance;
            singletonObj2.ShowMessage($"{2} time called");*/

            /*AccessPoint _accessPoint = new AccessPoint();
            _accessPoint.Start();
            Console.ReadKey(true);*/

            FactoryMethodAccessPoint factoryMethodAccessPoint = new FactoryMethodAccessPoint();
            factoryMethodAccessPoint.Start();
        }
    }
}

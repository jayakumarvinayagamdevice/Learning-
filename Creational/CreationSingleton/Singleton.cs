using System;
namespace Creational.CreationSingleton
{
    public sealed class Singleton
    {
        private static int _counter = 1;
        private static volatile Singleton _singletonInstance = null;
        private Singleton()
        {
            Console.WriteLine($"Singleton {_counter} time allocated on memory");
        }
        public static Singleton GetInstance {
            get {
                if (_singletonInstance == null)
                    _singletonInstance = new Singleton();
                return _singletonInstance;
            }
        }
        public void ShowMessage(string message)
        {
            Console.WriteLine($"This from singleton: {message}");
        }
    }
}

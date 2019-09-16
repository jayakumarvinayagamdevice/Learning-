using System;

namespace BasicStartup.OOPs
{
    public class OldClass
    {
        public int x = 100;
        public void Test1() => Console.WriteLine($"Method1 {this.x}");
        public void Test2() => Console.WriteLine($"Method2 {this.x}");
    }

    public static class FutureClass
    {
        public static void Test3(this OldClass o) => Console.WriteLine($"Method3 {o.x}");
        public static void Test4(this OldClass o, int x) => Console.WriteLine($"Method4 {x}");
        public static void Test5(this OldClass o) => Console.WriteLine($"Method5");
    }

    public static class WordCount
    {
        public static int GetWordcount(this string value) =>
            value.Split(new char[] { ' ', '.', '?' },
                StringSplitOptions.RemoveEmptyEntries).Length;
    }
    public class ExtensionMethod
    {
        public void Execute()
        {
            Console.WriteLine("\t\tExtensionMethod");
            OldClass oldClass = new OldClass();
            oldClass.Test1();
            oldClass.Test2();
            oldClass.Test3();
            oldClass.Test4(55);
            oldClass.Test5();
            var exMethod = "The most common extension methods are the LINQ standard query operators that add query functionality to the existing";

            Console.WriteLine($"{exMethod}\nword count: {exMethod.GetWordcount()}");
        }
    }

    /**
     * Define the static class to contain the extension method
     * Class must visible to client(Public)
     * Implementation of Extension method as static method with at 
     *      least the same vissibility as the containing class
     * Firs parameter must be reperesent with this modifier
     * call the methods as if they were they instance of type
     * **/
}

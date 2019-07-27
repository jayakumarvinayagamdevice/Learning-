namespace Creational.DependencyInjection
{
    public static class Startup
    {
        public static void Start()
        {

            // Constructor
            IConstructorGetEmployeeBL constructorGetEmployeeBL = 
                new ConstructorGetEmployeeBL(new ConstructorGetEmployeeDL());
            System.Console.WriteLine("Constructor Injection");
            foreach (var item in constructorGetEmployeeBL.Get())
            {
                System.Console.WriteLine($"{item.Id} \t {item.Name} \t {item.Address}");
            }

            // Property
            IPropertyGetEmployeeBL propertyGetEmployeeBL = new PropertyGetEmployeeBL();
            propertyGetEmployeeBL.ConstructorGetEmployeeDL = new ConstructorGetEmployeeDL();
            System.Console.WriteLine("Property Injection");
            foreach (var item in propertyGetEmployeeBL.Get())
            {
                System.Console.WriteLine($"{item.Id} \t {item.Name} \t {item.Address}");
            }
        }
    }
}

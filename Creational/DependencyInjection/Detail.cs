

/*
 *
 * Dependency Injection:
Which allows us to develop loosely coupled software components.In other way we may say like
to reduce the tight coupling between software components.
 -> reduce complexity
 -> easy to adopt future change

Tight Coupling: Class is dependent on another class. similar objec are dependent on another object.
If we change dependent object, then we also need to change the classes where this dependent object is used.
Uf it small one then it is not that difficult to handle but if we have a big enterprise level application, then its really very difficult to
handle make the changes.

Loose Coupling:
    Two objects are indepentent pf each other, that means if we change one object then it will 
    not affect another object.
In C# is a process in which we are injecting the object of a class into a class which 
depends on that object

Type:
    * Consteructor: supply the dependent object through constructor
    * Property:  supply the dependent object through public property
    * Method:  supply the dependent object through public method
    
Constructor Dependency:
    # Make strong dependency contract

Property injection
    When we use Property injection
    I have a class which has serveral methods bt those methods doesn't depend on any other
    objects,. Now I like to add one more method and that method depends on another object. If we use construction
    dependency injection here , hwe need to go and change all constructor call where they created.
    so it better to go Property injection

Method Injection

Unity Container
    Unit
    StructureMap
    Spring.Net
    Castle windsor
*/

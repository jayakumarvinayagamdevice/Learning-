using System;
using System.Collections.Generic;
using System.Text;

namespace BasicStartup.OOPs
{
    /**
     * A class not possible to create a new class 
     * Sealed class doen't support abstract, virtual methods
     * mostly inheritance format
     * it never be used as a base class
     * It used to avoid further inheritance
     * Sealed: Class, Methods, Properties
     * When should a class be declared as sealed?
        If we don’t want to override all the methods of our class in sub-classes.
        And if we don’t want to extend our class functionality.
     * **/
    public abstract class Human
    {
        public abstract string GetDnaCode();
    }
    public sealed class Male : Human
    {
        public int Height { get; set; }
        public int Weight { get; set; }
        public sealed override string GetDnaCode() => $"erqweuioryu444234%$$@#$@%&$#&%kjlhghghkdfg";
    }

    public class SuperMan //: Male
    {
        public string Clothes() => "blue with red";
    }
}

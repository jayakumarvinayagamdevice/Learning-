using System;
using System.Collections.Generic;
using System.Text;

namespace LinqProcess
{
    // 1. make static classs
    // 2.
    public static class ExtensionMethod
    {
        public static int GetWordCount(this string value)
        {
            if(!string.IsNullOrWhiteSpace(value))
                return value.Split(' ').Length;
            return 0; 
        }
    }

    public class ExtensionMethodClient
    {
        public void Start()
        {
            var address = "No 16, 3rd cross street, kodampakkam, chennai";
            var words = address.GetWordCount();
        }
    }
}

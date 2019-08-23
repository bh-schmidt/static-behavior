using System;
using System.Collections.Generic;
using System.Text;

namespace StaticBehavior.Attributes.SimpleStaticAttributes
{
    public class ExampleClass
    {
        public static string MyStaticProperty;

        public void ShowStaticProperty()
        {
            Console.WriteLine(MyStaticProperty);
        }
    }
}

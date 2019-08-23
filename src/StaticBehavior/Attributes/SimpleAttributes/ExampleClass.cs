using System;

namespace StaticBehavior.Attributes.SimpleAttributes
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

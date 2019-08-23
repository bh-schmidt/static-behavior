﻿namespace StaticBehavior.Attributes.SimpleStaticAttributes
{
    public class SimpleStaticAttributes
    {
        public static void Start()
        {
            ExampleClass.MyStaticProperty = "Just a description.";
            System.Console.WriteLine("The static property received the value of \"Just a description.\"");

            var example1 = new ExampleClass();
            var example2 = new ExampleClass();

            example1.ShowStaticProperty();
            example2.ShowStaticProperty();
            System.Console.WriteLine("When calling the same method of two different objects they access the same property because the property belongs to the class and not to the object.");
        }
    }
}


using System;
using Decorator.Interfaces;
using Decorator.Classes;


namespace Decorator

{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a ConcreteComponent instance
            IComponent<string> component = new ConcreteComponent();

            // Create decorators
            var plainDecorator = new PlainDecorator(component);
            var upperCaseDecorator = new UpperCaseDecorator(component);
            var colorDecorator = new ColorDecorator(component);

            // Call GetText() method on each object and print the result
            Console.WriteLine("Plain Decorator: " + plainDecorator.GetText());
            Console.WriteLine("Upper Case Decorator: " + upperCaseDecorator.GetText());
            Console.WriteLine("Color Decorator: " + colorDecorator.GetText());
        }
    }
}

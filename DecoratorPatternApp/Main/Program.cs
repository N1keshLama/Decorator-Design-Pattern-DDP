using System;
using DecoratorPattern.Interfaces;
using DecoratorPattern.ConcreteClasses;

namespace DecoratorPattern.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create ConcreteComponent
            IComponent<string> component = new ConcreteComponent();

            // Create and use PlainDecorator
            IComponent<string> plainDecorator = new PlainDecorator(component);
            Console.WriteLine("PlainDecorator: " + plainDecorator.GetText());

            // Create and use UpperCaseDecorator
            IComponent<string> upperCaseDecorator = new UpperCaseDecorator(component);
            Console.WriteLine("UpperCaseDecorator: " + upperCaseDecorator.GetText());

            // Create and use ColorDecorator
            IComponent<string> colorDecorator = new ColorDecorator(component);
            Console.WriteLine("ColorDecorator: " + colorDecorator.GetText());
        }
    }
}

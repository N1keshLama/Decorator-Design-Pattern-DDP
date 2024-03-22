using DecoratorPattern.AbstractClasses;
using DecoratorPattern.Interfaces;
using System;

namespace DecoratorPattern.ConcreteClasses
{
    public class UpperCaseDecorator : Decorator<string>
    {
        public UpperCaseDecorator(IComponent<string> component) : base(component)
        {
        }

        public override string GetText()
        {
            return base.GetText().ToUpper();
        }
    }
}

using DecoratorPattern.AbstractClasses;
using DecoratorPattern.Interfaces;

namespace DecoratorPattern.ConcreteClasses
{
    public class PlainDecorator : Decorator<string>
    {
        public PlainDecorator(IComponent<string> component) : base(component)
        {
        }

        public override string GetText()
        {
            return "Plain Decorator: " + base.GetText();
        }
    }
}

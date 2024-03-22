using DecoratorPattern.Interfaces;

namespace DecoratorPattern.ConcreteClasses
{
    public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            return "Hi! we are testing the concrete components";
        }
    }
}

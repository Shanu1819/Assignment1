namespace Decorator.Classes
{
    public class PlainDecorator : Decorator<string>
    {
        public PlainDecorator(IComponent<string> component) : base(component)
        {
        }

        public override string GetText()
        {
            // Prefixing the text of the base class with some chosen text
            string baseText = base.GetText();
            return "Introduction:" + baseText;
        }
    }
}

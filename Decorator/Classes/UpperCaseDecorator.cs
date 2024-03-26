namespace Decorator.Classes
{
    public class UpperCaseDecorator : Decorator<string>
    {
        public UpperCaseDecorator(IComponent<string> component) : base(component)
        {
        }

        public override string GetText()
        {
            // Getting the text from the base class and converting it to upper case
            string baseText = base.GetText();
            return baseText.ToUpper();
        }
    }
}
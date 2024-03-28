using System;

namespace   Decorator.Classes
{
    public class ColorDecorator : Decorator<string>
    {
        public ColorDecorator(IComponent<string> component) : base(component)
        {
        }

        public override string GetText()
        {
            // Getting the text from the base class 
            string baseText = base.GetText();
            return $"\u001b[31m{baseText}\u001b[0m"; // Question requirements
            
        }
    }
}
namespace Decorator.Interfaces
{
    public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            
            return "Hi, This is Shanu Singh. I am a student of Cambrian College studying MAPD program.";
        }
    }
}

using Core.Elements.Interface;

namespace Core.Elements
{
    public class ConditionalStatement : IElement
    {
        public T Generate<T>()
        {
            Console.WriteLine("Você confirma o procedimento a seguir? (Y/n)");

            if (string.Equals(Console.ReadLine(), "Y", StringComparison.OrdinalIgnoreCase))
            {
                return (T)Convert.ChangeType(true, typeof(T));
            }

            return default;
        }

        public void Generate()
        {
            throw new NotImplementedException();
        }

        public bool HasReturn() => true;

        public bool IsValid(string input)
        {
            if (input == "Y" || input == "Yes")
            {
                return true;
            }

            return false;
        }
    }
}

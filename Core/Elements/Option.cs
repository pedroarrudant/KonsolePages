using Core.Elements.Interface;
using Extensions;

namespace Core.Elements
{
    public class Option : IElement
    {
        public Enum enumerator { get; set; }
        public Option(Enum enumerator)
        {
            this.enumerator = enumerator;
        }

        public void Generate()
        {
            throw new NotImplementedException();
        }

        public string? SelectOption<T>(int selectedOption) where T : Enum => Enum.GetName(typeof(T), selectedOption - 1);

        public bool HasReturn() => true;

        public bool IsValid(string input)
        {
            return Enum.IsDefined(enumerator.GetType(), input);
        }

        public T Generate<T>()
        {
            int count = 0;

            foreach (var option in Enum.GetNames(enumerator.GetType()))
            {
                Console.WriteLine($"{count}. {option}");
                count++;
            }

            return (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
        }
    }
}

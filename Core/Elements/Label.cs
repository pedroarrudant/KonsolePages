using Core.Elements.Interface;

namespace Core.Elements
{
    public class Label : IElement
    {
        public string label { get; set; }

        public Label(string label)
        {
            this.label = label;
        }

        public void Generate()
        {
            Console.WriteLine(label);
        }

        public bool HasReturn()
        {
            return false;
        }

        public bool IsValid(string input)
        {
            return true;
        }

        public T Generate<T>()
        {
            throw new NotImplementedException();
        }
    }
}

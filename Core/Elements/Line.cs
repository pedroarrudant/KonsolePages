using Core.Elements.Interface;

namespace Core.Elements
{
    public class Line : IElement
    {
        public T Generate<T>()
        {
            throw new NotImplementedException();
        }

        public void Generate()
        {
            //TODO: Investigar o padrao de colunas a ser usado tipo "bootstrap"
            Console.WriteLine("-----------------------------------");
        }

        public bool HasReturn()
        {
            return false;
        }

        public bool IsValid(string input)
        {
            return true;
        }
    }
}

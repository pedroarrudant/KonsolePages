namespace Core.Elements.Interface
{
    public interface IElement
    {
        public bool HasReturn();

        public T Generate<T>();
        public void Generate();

        public bool IsValid(string input);
    }
}

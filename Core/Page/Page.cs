using Core.Elements;
using Core.Elements.Interface;

namespace Core.Page
{
    public abstract class Page
    {
        public List<IElement> Elements = new List<IElement>();

        public void AddPageElement(Element pageElement, object? arg = null)
        {
            var element = ElementsFactory.Factory(pageElement, arg);

            if (element != null)
            {
                Elements.Add(element);
            }
        }

        public void RemovePageElement(IElement pageElement) { Elements.Remove(pageElement); }

        public void Clear() { Elements.Clear(); }

        public T GeneratePage<T>()
        {
            foreach (var element in Elements)
            {
                if (element.HasReturn())
                {
                    return element.Generate<T>();
                }

                element.Generate();
            }

            return default(T);
        }
    }
}
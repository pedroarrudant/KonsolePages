using Core.Elements;
using Core.Elements.Interface;

namespace Core.Page
{
    public abstract class Page
    {
        private readonly List<IElement> elements = new List<IElement>();
        public string output { get; set; }

        public void AddPageElement(Element pageElement, Enum optionArg = null, string? argString = null,int? argInt = null, bool? argBool= null)
        {
            var element = ElementsFactory.Factory(pageElement, optionArg, argString, argInt, argBool);

            if (element != null)
            {
                elements.Add(element);
            }
        }

        public void RemovePageElement(IElement pageElement) { elements.Remove(pageElement); }

        public void Clear() { elements.Clear(); }

        public T GeneratePage<T>()
        {
            foreach (var element in elements)
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
using Core.Elements.Interface;

namespace Core.Elements
{
    public static class ElementsFactory
    {
        //TODO: Arrumar esses parametros
        public static IElement? Factory(Element element, object? arg)
        {
            switch (element)
            {
                case Element.Option:
                    return new Option((Enum)arg);
                case Element.ConditionalStatement:
                    return new ConditionalStatement();
                case Element.Label:
                    return new Label((string)arg);
                case Element.ProgressBar:
                    return new ProgressBar();
                case Element.Line:
                    return new Line();
                default:
                    return null;
            }
        }
    }
}

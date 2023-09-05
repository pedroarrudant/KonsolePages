using Core.Elements.Interface;

namespace Core.Elements
{
    public static class ElementsFactory
    {
        //TODO: Arrumar esses parametros
        public static IElement? Factory(Element element, Enum argEnum = null, string? argString = null, int? argInt = null, bool? argBool = null)
        {
            switch (element)
            {
                case Element.Option:
                    return new Option(argEnum);
                case Element.ConditionalStatement:
                    return new ConditionalStatement();
                case Element.Label:
                    return new Label(argString);
                case Element.ProgressBar:
                    return new ProgressBar(argInt, argBool);
                case Element.Line:
                    return new Line();
                default:
                    return null;
            }
        }
    }
}

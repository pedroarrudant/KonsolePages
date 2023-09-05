using Core.Elements;
using Core.Elements.Interface;

namespace Core.Page
{
    public class Window
    {
        public int MyIntProperty { get; set; }
        public IElement Element { get; set; }

        public PageHeader Header { get; set; }
        public PageBody Body  { get; set; }
        public PageFooter Footer { get; set; }

        public Window()
        {
            Header = new PageHeader();
            Body = new PageBody();
            Footer = new PageFooter();
        }

        public void GenerateWindow(Action<Window> action)
        {
            action.Invoke(this);
        }

        public T Run<T>()
        {
            Header.GeneratePage<T>();
            var consoleReturn = Body.GeneratePage<T>();
            Footer.GeneratePage<T>();

            return consoleReturn;
        }
    }
}

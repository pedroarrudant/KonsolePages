using Core.Elements;
using Core.Page;
using ExecutionExample.Models;

namespace ConsoleApp
{
    static class ConsoleApp
    {
        public static void Main(string[] args)
        {
            //var mainMenu = new MainMenuOptions();

            //var console = new ConsolePage();
            //console.AddPageElement(Element.Option, mainMenu);
            //console.AddPageElement(Element.ProgressBar, argInt: 10, argBool: true);

            //console.GeneratePage();

            var window = new Window();
            var mainMenu = new MainMenuOptions();

            window.GenerateWindow(x => {
                x.Header.AddPageElement(Element.Line);
                x.Header.AddPageElement(Element.Label, argString: "Header");
                x.Header.AddPageElement(Element.Line);
                x.Body.AddPageElement(Element.Option, mainMenu);
                x.Footer.AddPageElement(Element.Line);
                x.Footer.AddPageElement(Element.Label, argString: "Footer");
                x.Footer.AddPageElement(Element.Line);
            });

            var @return = window.Run<int>();

            Console.ReadKey();
        }
    }
}
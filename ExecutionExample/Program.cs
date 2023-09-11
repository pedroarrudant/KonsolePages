using Core.Elements;
using Core.Page;
using ExecutionExample.Models;

namespace ConsoleApp
{
    static class ConsoleApp
    {
        public static void Main(string[] args)
        {

            var firstWindow = new Window();
            var secondWindow = new Window();
            var errorWindow = new Window();
            var mainMenu = new MainMenuOptions();

            firstWindow.GenerateWindow(x => {
                x.Header.AddPageElement(Element.Line);
                x.Header.AddPageElement(Element.Label, "Header");
                x.Header.AddPageElement(Element.Line);
                x.Body.AddPageElement(Element.Option, mainMenu);
                x.Footer.AddPageElement(Element.Line);
                x.Footer.AddPageElement(Element.Label, "Footer");
                x.Footer.AddPageElement(Element.Line);
            });

            secondWindow.GenerateWindow(x => {
                x.Header.AddPageElement(Element.Line);
                x.Header.AddPageElement(Element.Label, "Header");
                x.Header.AddPageElement(Element.Line);
                x.Body.AddPageElement(Element.ProgressBar);
                x.Footer.AddPageElement(Element.Line);
                x.Footer.AddPageElement(Element.Label, "Footer");
                x.Footer.AddPageElement(Element.Line);
            });

            errorWindow.GenerateWindow(x => {
                x.Header.AddPageElement(Element.Line);
                x.Header.AddPageElement(Element.Label, "Header");
                x.Header.AddPageElement(Element.Line);
                x.Body.AddPageElement(Element.Label, "Voce selecionou uma opcao invalida. Pressione qualquer tecla para continuar...");
                x.Footer.AddPageElement(Element.Line);
                x.Footer.AddPageElement(Element.Label, "Footer");
                x.Footer.AddPageElement(Element.Line);
            });

            while (true)
            {
                var @return = firstWindow.Run<int>();

                if (@return == 2)
                {
                    return;
                }

                secondWindow.Run<int>();

                secondWindow.Update();
                Thread.Sleep(1000);
                secondWindow.Update();
                Thread.Sleep(1000);
                secondWindow.Update();
                Thread.Sleep(1000);
                secondWindow.Update();
                Thread.Sleep(1000);
                secondWindow.Update();

                errorWindow.Run<int>();
                Console.ReadLine();
            }
        }
    }
}
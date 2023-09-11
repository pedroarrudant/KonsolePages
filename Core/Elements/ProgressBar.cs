using Core.Elements.Interface;
using System.Text;

namespace Core.Elements
{
    public class ProgressBar : IElement
    {
        const char _block = '■';
        const string _back = "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b";
        const string _twirl = "-\\|/";
        private int percentage = 0;

        public void Generate()
        {
            WriteProgressBar(percentage);
            Console.WriteLine();

            if (percentage < 100)
            {
                percentage = percentage + 25;
            }
        }

        public bool HasReturn()
        {
            return false;
        }

        public bool IsValid(string input)
        {
            return true;
        }
        private void WriteProgressBar(int percent, bool update = false)
        {
            if (update)
                Console.Write(_back);
            Console.Write("[");
            var p = (int)((percent / 10f) + .5f);
            for (var i = 0; i < 10; ++i)
            {
                if (i >= p)
                    Console.Write(' ');
                else
                    Console.Write(_block);
            }
            Console.Write("] {0,3:##0}%", percent);
        }
        private void WriteProgress(int progress, bool update = false)
        {
            if (update)
                Console.Write("\b");
            Console.Write(_twirl[progress % _twirl.Length]);
        }

        public T Generate<T>()
        {
            throw new NotImplementedException();
        }
    }
}

using DesignPatterns.Iterator;
using DesignPatterns.Memento;
using DesignPatterns.State;
using DesignPatterns.Strategy;

namespace DesignPatterns.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Memento();
            //State();
            //Iterator();
            Strategy();
        }

        private static void Memento()
        {
            Editor editor = new();
            History history = new();

            editor.Content = "a";
            history.Push(editor.CreateState());

            editor.Content = "b";
            history.Push(editor.CreateState());

            editor.Content = "c";
            editor.Restore(history.Pop()); // -> b
            editor.Restore(history.Pop()); // -> a

            Console.WriteLine(editor.Content);
        }

        private static void State()
        {
            Canvas canvas = new();
            canvas.Tool = new SelectionTool();
            canvas.MouseDown();
            canvas.MouseUp();

            canvas.Tool = new BrushTool();
            canvas.MouseDown();
            canvas.MouseUp();
        }

        private static void Iterator()
        {
            BrowseHistory history = new();
            history.Push("a");
            history.Push("b");
            history.Push("c");

            history.Pop();

            history.Urls.Add("d"); // TODO: how to prevent directly adding an item to Urls?

            //foreach (var url in history.Urls)
            //{
            //    Console.WriteLine(url);
            //}

            var iterator = history.CreateIterator();

            while (iterator.HasNext())
            { 
                Console.WriteLine(iterator.Current());
                iterator.Next();
            }
        }

        private static void Strategy()
        {
            ImageStorage imageStorage = new();
            imageStorage.Store("fileName", new JpegCompressor(), new BlackAndWhiteFilter());
            imageStorage.Store("fileName", new PngCompressor(), new BlackAndWhiteFilter());
            imageStorage.Store("fileName", new PngCompressor(), new ContrastFilter());
        }
    }
}
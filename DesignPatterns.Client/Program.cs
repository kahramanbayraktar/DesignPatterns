﻿using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.Observer.Ex2;
using DesignPatterns.Behavioral.Observer.Example1;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.Strategy.Ex1;
using DesignPatterns.Behavioral.Strategy.Ex2;
using DesignPatterns.Creational.Factory.Example1;
using DesignPatterns.Structural.Adapter.Ex1;

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
            //Observer();
            //Factory();
            Adapter();
        }

        private static void Memento()
        {
            Behavioral.Memento.Editor editor = new();
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

        private static void Strategy2()
        {
            Context context = new(new StrategyAdd());
            var result = context.ExecuteStrategy(1, 3); // 4

            context.Strategy = new StrategyMultiply();
            result = context.ExecuteStrategy(1, 3); // 3
        }

        private static void Observer()
        {
            DataSource dataSource = new();
            SpreadSheet sheet = new();
            SpreadSheet sheet2 = new();
            Chart chart = new();

            dataSource.AddObserver(sheet);
            dataSource.AddObserver(sheet2);
            dataSource.AddObserver(chart);

            dataSource.Value = 3;
        }

        private static void Observer2()
        {
            var path = "/path/to/log.txt";
            Behavioral.Observer.Ex2.Editor editor = new();
            editor.Events.Subscribe(new LoggingListener("path", "Someone has opened the file: " + path));
        }

        private static void Factory()
        {
            Creator creator1 = new ConcreteCreator1();
            IProduct product1 = creator1.CreateProduct();
            product1.SomeOperation();

            Creator creator2 = new ConcreteCreator2();
            var product2 = creator2.CreateProduct();
            product2.SomeOperation();
        }

        private static void Adapter()
        {
            RoundHole hole = new(5);
            RoundPeg roundPeg = new(5);
            var fits = hole.Fits(roundPeg);

            SquarePeg squarePeg = new(5);
            //hole.Fits(squarePeg); // compile time error

            SquarePegAdapter adapter = new(squarePeg.Width);
            hole.Fits(adapter);

            SquarePeg squarePeg2 = new(10);
            SquarePegAdapter adapter2 = new(squarePeg.Width);
            hole.Fits(adapter2);
        }
    }
}
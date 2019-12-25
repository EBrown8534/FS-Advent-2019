using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class Step2
    {
        private static void runCS()
        {
            var elementsList = new List<CSLibrary.Step2.Vector2>();

            for (var i = 0; i < 100; i++)
            {
                elementsList.Add(new CSLibrary.Step2.Vector2() { X = i % 50, Y = (i * 2) % 50 });
            }

            var elements = elementsList.ToArray();
        
            var find = new CSLibrary.Step2.Vector2() { X = 1, Y = 2 };
            var results = elements.Where(x => x.Equals(find));
        
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
        
        private static void runFS()
        {
            var elementsList = new List<FSLibrary.Step2.Vector2>();

            for (var i = 0; i < 100; i++)
            {
                elementsList.Add(new FSLibrary.Step2.Vector2(i % 50, (i * 2) % 50));
            }

            var elements = elementsList.ToArray();
        
            var find = new FSLibrary.Step2.Vector2(1, 2);
            var results = elements.Where(x => x.Equals(find));
        
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        public static void Run()
        {
            Console.WriteLine("C# Test");
            runCS();
            Console.WriteLine("F# Test");
            runFS();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class Step3
    {
        private static void runCS()
        {
            var elementsListA = new List<CSLibrary.Step3.Vector2>();
            var elementsListB = new List<CSLibrary.Step3.Vector2>();

            for (var i = 0; i < 100; i++)
            {
                elementsListA.Add(new CSLibrary.Step3.Vector2() { X = i % 50, Y = (i * 2) % 50 });
                elementsListB.Add(new CSLibrary.Step3.Vector2() { X = i % 75, Y = (i * 2) % 75 });
            }

            var elementsA = elementsListA.ToArray();
            var elementsB = elementsListB.ToArray();

            var results = elementsA.Intersect(elementsB).ToArray();
            Console.WriteLine(results.Length);
        }
        
        private static void runFS()
        {
            var elementsListA = new List<FSLibrary.Step3.Vector2>();
            var elementsListB = new List<FSLibrary.Step3.Vector2>();

            for (var i = 0; i < 100; i++)
            {
                elementsListA.Add(new FSLibrary.Step3.Vector2(i % 50, (i * 2) % 50));
                elementsListB.Add(new FSLibrary.Step3.Vector2(i % 75, (i * 2) % 75));
            }

            var elementsA = elementsListA.ToArray();
            var elementsB = elementsListB.ToArray();

            var results = elementsA.Intersect(elementsB).ToArray();
            Console.WriteLine(results.Length);
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

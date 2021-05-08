using System;

namespace Stealer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var spy = new Spy();
            var result = spy.AnalyzeAccessModifiers("Stealer.Hacker");
            Console.WriteLine(result);
        }
    }
}

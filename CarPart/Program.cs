using System;
using System.ComponentModel.Composition;

namespace CarSample
{
    [Export(typeof(ICarContract))]
    public class CarPart : ICarContract, IDisposable
    {
        public CarPart()
        {
            Console.WriteLine("Constructor");
        }
        public void DoSomething(string message)
        {
            Console.WriteLine(message);
        }
        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }
    }
}

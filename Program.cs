using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace CarSample
{
    class Program
    {
        [Import]
        private ExportFactory<ICarContract> carFactory = null;

        static void Main(string[] args)
        {
            new Program().Run();
        }
        void Run()
        {
            var catalog = new DirectoryCatalog(".");
            var container = new CompositionContainer(catalog);

            container.ComposeParts(this);

            ExportLifetimeContext<ICarContract> carA = carFactory.CreateExport();
            ExportLifetimeContext<ICarContract> carB = carFactory.CreateExport();

            carA.Value.DoSomething("carA");
            carB.Value.DoSomething("carB");

            carA.Dispose();
            carB.Dispose();
        }
    }
}

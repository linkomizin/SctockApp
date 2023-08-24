using ClassLibrary;
using ClassLibrary.GeneratorObject;
using ClassLibrary.Model;
using ClassLibrary.Services;
using ClassLibrary.Sorter;
using ClassLibrary.ViewHandler;
using ClassLibrary.Worker;
using System.Runtime.CompilerServices;

namespace ConsoleApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            WorkerStock workerStock = new WorkerStock(new MakerBox(), new MakerPallet(),
           new List<Box>(), new List<Pallet>(),
             new HandlerCanAddPallet(), new MainConsoleHandler(), new PalletWorker(), new SorterPallet());


            workerStock.GeneratePalletsAndBox(5, 50);

            workerStock.AddBoxesToPallets(8);

            workerStock.TakeCountPalletByMaxDate();
        }


    }
}
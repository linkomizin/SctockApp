using ClassLibrary.Model;
using System.Collections;

namespace ClassLibrary.ViewHandler
{
    public class MainConsoleHandler : IViewHandler
    {
        public void DisplayMenu()
        {
            throw new NotImplementedException();
        }

        public void DisplayPallet(List<Pallet> pallets)
        {
            pallets.ToList().ForEach(pallet =>
            {
                Console.WriteLine(pallet);
                Console.WriteLine();
            });
        }

        public void DisplayPallet(ICollection pallets)
        {
            if (pallets is List<Pallet> pal)
            {
                DisplayPallet(pal);
            }
            else if (pallets is Dictionary<DateOnly, List<Pallet>> palDict)
            {
                DisplayPalletDict(palDict);
            }
        }

        public void DisplayPalletDict(Dictionary<DateOnly, List<Pallet>> palDict)
        {
            foreach (KeyValuePair<DateOnly, List<Pallet>> set in palDict)
            {
                Console.WriteLine($"Expiration Date pallet: {set.Key}\n");
                DisplayPallet(set.Value);

            }

        }

    }
}

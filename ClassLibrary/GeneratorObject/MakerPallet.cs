using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.GeneratorObject
{
    public class MakerPallet
    {
        private Random _random;
        public MakerPallet()
        {
            _random = new Random();
        }

        public List<Pallet> MakePallets(int totalCount, double minimalNum, double maxH, double maxW, double maxL, double standartScale = 30)
        {
            List<Pallet> pallets = new List<Pallet>();

            for (int i = 0; i < totalCount; i++)
            {
                var item = MakePallet(minimalNum, maxH, maxW, maxL, standartScale);
                pallets.Add(item);
            }

            return pallets;
        }

        private Pallet MakePallet(double minimalNum, double maxH, double maxW, double maxL, double standartScale)
        {
            return new Pallet(
                id: Guid.NewGuid().ToString(),
                length: (_random.NextDouble() + minimalNum) * maxL,
                  height: (_random.NextDouble() + minimalNum) * maxH,
                  width: (_random.NextDouble() + minimalNum) * maxW,
                  scale: standartScale);
        }
    }
}

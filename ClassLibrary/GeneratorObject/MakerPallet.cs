using ClassLibrary.Model;

namespace ClassLibrary.GeneratorObject
{
    public class MakerPallet
    {
        private Random _random;
        public MakerPallet()
        {
            _random = new Random();
        }

        public List<Pallet> MakePallets(int totalCount, double minimalNum, double maxH, double maxW, double maxL, double standardScale = 30)
        {
            List<Pallet> pallets = new List<Pallet>();

            for (int i = 0; i < totalCount; i++)
            {
                var item = MakePallet(minimalNum, maxH, maxW, maxL, standardScale);
                pallets.Add(item);
            }

            return pallets;
        }

        private Pallet MakePallet(double minimalNum, double maxH, double maxW, double maxL, double standardScale)
        {
            return new Pallet(
                id: Guid.NewGuid().ToString(),
                length: (_random.NextDouble() + minimalNum) * maxL,
                  height: (_random.NextDouble() + minimalNum) * maxH,
                  width: (_random.NextDouble() + minimalNum) * maxW,
                  scale: standardScale);
        }
    }
}

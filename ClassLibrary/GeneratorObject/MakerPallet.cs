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

        public List<Pallet> MakePallets(int totalCount, double minimalNum, double maxH, double maxW, double maxL, double scale = 30)
        {
            List<Pallet> pallets = new List<Pallet>();


            return pallets;
        }

        private Pallet MakePallet(double minimalNum, double maxH, double maxW, double maxL, double scale)
        {
            return new Pallet(
                string id,
                double length,
                double height,
                double width,
                double scale);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.GeneratorObject;
using ClassLibrary.Model;
using ClassLibrary.Services;
using ClassLibrary.Sorter;
using ClassLibrary.ViewHandler;

namespace ClassLibrary.Worker
{
    public class WorkerStock
    {
        private MakerBox _makerBox;
        private MakerPallet _makerPallet;

        private List<Box> _boxList;
        private List<Pallet> _palletList;

        private IPalletWorker _palletWorker;
        private ICanAddpallet _canAddpallet;

        private IViewHandler _viewHandler;

        private ISorter<Pallet> _sorter;

        public WorkerStock(MakerBox makerBox, MakerPallet makerPallet,
            List<Box> boxList, List<Pallet> palletList,
            ICanAddpallet canAddpallet, IViewHandler viewHandler, IPalletWorker palletWorker, ISorter<Pallet> sorter)
        {
            _boxList = boxList;
            _palletList = palletList;
            _makerBox = makerBox;
            _makerPallet = makerPallet;
            _viewHandler = viewHandler;
            _canAddpallet = canAddpallet;
            _palletWorker = palletWorker;
            _sorter = sorter;
        }

        public void GeneratePalletsAndBox(int countPallet = 4, int countBox = 50)
        {
            _boxList = _makerBox.CreateBoxes(countBox, 200, 3.25, 4, 8, 10, 7, 100);
            _palletList = _makerPallet.MakePallets(countPallet, 3.5, 6, 8, 10, 30);
        }

        public void AddBoxesToPallets(int countBoxToPallet = 10)
        {
            for (int i = 0; i < _palletList.Count(); i++)
            {
                AddBoxToSelectedPallet(_palletList[i], countBoxToPallet);
            }
        }

        private void AddBoxToSelectedPallet(Pallet pallet, int countBoxToPallet)
        {

            for (int i = 0; i < countBoxToPallet; i++)
            {
                var canAddByGabarit = _canAddpallet.CanAddPallet(pallet, _boxList[i]);
                if (canAddByGabarit == true)
                {
                    _palletWorker.AddBox(_boxList[i]);
                }
            }
        }

        private void SortPalletSet()
        {
               _sorter.SortAB(_palletList);
            _palletList.OrderBy(el => el.ExpirationDate);
        }

        private void PrintConsoleListPallet()
        {
            _viewHandler.DisplayPallet(_palletList);
        }
    }
}

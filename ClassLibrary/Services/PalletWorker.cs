using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Model;

namespace ClassLibrary.Services
{
    public class PalletWorker : IPallet
    {


        private Pallet _pallet;

        private ICanAddpallet _canAddpallet;

        public Pallet SelectedPallet
        {
            get => _pallet;
            set => _pallet = value;
        }


        public bool AddBox(Box box)
        {

            if (_canAddpallet.CanAddPallet(_pallet, box) == true)
            {
                SelectedPallet.Boxes.Add(box);
                return true;
            }
            return false;
        }

        public void RemoveBox(Box box)
        {
            SelectedPallet.Boxes.Remove(box);
        }


        public double GetTotalScale()
        {
            return SelectedPallet.Scale;
        }

        public double GetTotalVolume()
        {
            return SelectedPallet.Volume;
        }

        public DateOnly GetExpirationDatePallet()
        {
            var expirationDate = SelectedPallet.Boxes
                .AsParallel()
                .Min(box => box.ExpirationDate);
            return expirationDate;
        }
    }
}

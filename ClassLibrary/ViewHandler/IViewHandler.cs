using ClassLibrary.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ViewHandler
{
    public interface IViewHandler
    {
        void DisplayMenu();
        //void DisplayPallet(List<Pallet> pallets);
        void DisplayPallet(ICollection pallets);

    }
}

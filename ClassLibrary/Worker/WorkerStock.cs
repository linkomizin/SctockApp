using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.GeneratorObject;
using ClassLibrary.Model;
using ClassLibrary.ViewHandler;

namespace ClassLibrary.Worker
{
    public class WorkerStock
    {
        private MakerBox _makerBox;
        private MakerPallet _makerPallet;

        private IEnumerable<Box> _boxList;
        private IEnumerable<Pallet> _palletList;

        private ICanAddpallet _canAddpallet;

        private IViewHandler _viewHandler;


    }
}

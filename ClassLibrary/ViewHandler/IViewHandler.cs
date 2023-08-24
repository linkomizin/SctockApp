using System.Collections;

namespace ClassLibrary.ViewHandler
{
    public interface IViewHandler
    {
        void DisplayMenu();
        //void DisplayPallet(List<Pallet> pallets);
        void DisplayPallet(ICollection pallets);

    }
}

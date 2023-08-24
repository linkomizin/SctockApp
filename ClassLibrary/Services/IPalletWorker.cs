using ClassLibrary.Model;

namespace ClassLibrary.Services
{
    public interface IPalletWorker
    {
        ICanAddpallet CanAddPallet { get; set; }
        Pallet SelectedPallet { get; set; }
        bool AddBox(Box box);
        void RemoveBox(Box box);
        double GetTotalScale();
        double GetTotalVolume();
        DateOnly GetExpirationDatePallet();

    }
}

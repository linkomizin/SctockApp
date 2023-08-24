using ClassLibrary.Model;

namespace ClassLibrary
{
    public interface ICanAddpallet
    {
        bool CanAddPallet(DimensionsBase pallete, DimensionsBase box);
    }
}

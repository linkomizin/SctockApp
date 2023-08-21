

using ClassLibrary.Services;

namespace ClassLibrary.Model
{
    public class Box : DimensionsBase , IBox
    {
        public Box(string id, double length, double height, double width, double scale) : base(length, height, width, scale)
        {
            Id = id;
        }

        public Box(string id, DateOnly? expirationDate, DateOnly? productionDate, int countDay, double length, double height, double width, double scale) : this(id, length, height, width, scale)
        {
            if (expirationDate!=null)
            {
                 ExpirationDate = expirationDate.Value;
            }
           
            ProductionDate = productionDate;
            CalcDayExpiration(countDay);
        }

        private void CalcDayExpiration(int countDay)
        {
            if (ProductionDate!= null)
            {
                var dateOnlyNow = DateOnly.FromDateTime( DateTime.Now);
                ExpirationDate = DateOnly.FromDayNumber(dateOnlyNow.DayNumber - ProductionDate.Value.DayNumber +countDay);
            }
        }

        #region Region fields


        private string _id;
        private DateOnly _expirationDate;
        private DateOnly? _productionDate;

        #endregion
        #region Region property

        public string Id
        {
            get => _id;
            set => _id = value;
        }

        public DateOnly ExpirationDate
        {
            get => _expirationDate;
            set => _expirationDate = value;
        }

        public DateOnly? ProductionDate
        {
            get => _productionDate;
            set => _productionDate = value;
        }

        #endregion

        #region Region IBox interface

        public string GetId()
        {
            return Id;
        }

        public int GetDayExpiration()
        {
            return ExpirationDate.DayNumber;
        }

        public double GetVolume()
        {
            return this.Volume;
        }

        public double GetScale()
        {
            return this.Scale;
        }
        #endregion
    }
}

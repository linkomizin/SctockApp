﻿namespace ClassLibrary.Model
{
    public class Box : DimensionsBase
    {
        public Box(string id, DateOnly? expirationDate, DateOnly? productionDate, int countDay,
                         double length, double height, double width, double scale)
                     : base(length, height, width, scale)
        {
            Id = id;
            if (expirationDate != null)
            {
                ExpirationDate = expirationDate.Value;
            }

            ProductionDate = productionDate;
            CalcDayExpiration(countDay);
        }

        private void CalcDayExpiration(int countDay)
        {
            if (ProductionDate != null)
            {
                var dateOnlyNow = DateOnly.FromDateTime(DateTime.Now);
                ExpirationDate = DateOnly.FromDayNumber(dateOnlyNow.DayNumber - ProductionDate.Value.DayNumber + countDay);
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
        public override DateOnly ExpirationDate
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

        public override string ToString()
        {
            return $"Box id {Id}, {base.ToString()},  Volume: {base.Volume}, Scale: {base.Scale}, ExpirationDate {ExpirationDate.ToString()}," +
                $"  ProductionDate: {ProductionDate?.ToString()}";
        }

    }
}

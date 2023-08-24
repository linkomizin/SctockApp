namespace ClassLibrary.Model
{
    public class Pallet : DimensionsBase
    {
        private string _id;
        private DateOnly _expirationDate;
        private DateOnly? _productionDate;
        private List<Box> _boxes;
        public Pallet(string id, double length, double height, double width, double scale) : base(length, height, width, scale)
        {
            Id = id;
            _boxes = new List<Box>();
        }

        public Pallet(string id, List<Box> boxes, double length, double height, double width, double scale) : this(id, length, height, width, scale)
        {
            Boxes = boxes;
        }


        public string Id
        {
            get => _id;
            set => _id = value;
        }

        public List<Box> Boxes
        {
            get { return _boxes; }
            set => _boxes = value;
        }

        public override double Scale
        {
            get
            {
                double result = Boxes
                        .AsParallel()
                        .Sum(box => box.Scale);
                return result + base.Scale;
            }
        }

        public override double Volume
        {
            get
            {
                double sumBoxes = Boxes
                    .AsParallel()
                    .Sum(box => box.Volume);
                return sumBoxes + base.Volume;
            }
        }

        public override DateOnly ExpirationDate
        {
            get
            {
                return _boxes
                    .AsParallel()
                    .Max(el => el.ExpirationDate);
            }
            set { _ = value; }
        }
        public override string ToString()
        {
            return $"Pallet id {Id}, {base.ToString()},Volume: {Volume}, Scale: {Scale}, Count boxes: {Boxes.Count}" +
                $" ExpirationDate {ExpirationDate.ToString()}";
        }

    }
}

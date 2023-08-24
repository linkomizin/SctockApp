namespace ClassLibrary.Model
{
    public abstract class DimensionsBase
    {
        private double _length;
        private double _width;
        private double _height;
        private double _scale;
        private double _volume;

        public DimensionsBase(double length, double height, double width, double scale)
        {
            Length = length;
            Width = width;
            Height = height;
            _scale = scale;
            Scale = scale;
            Volume = Width * Height * Length;
        }


        public double Length
        {
            get => _length;
            private set => _length = value;
        }

        public double Width
        {
            get => _width;
            private set => _width = value;
        }

        public double Height
        {
            get => _height;
            private set => _height = value;
        }

        public virtual double Scale
        {
            get => _scale;
            private set => _scale = value;
        }

        public virtual double Volume
        {
            get => _volume;
            private set => _volume = value;
        }

        public abstract DateOnly ExpirationDate { get; set; }


        public override string ToString()
        {
            return $"Length: {Length}, Width: {Width}, Height: {Height},";
        }
    }
}

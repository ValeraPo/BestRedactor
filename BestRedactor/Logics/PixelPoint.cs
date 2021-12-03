namespace BestRedactor.Logics
{
    public class PixelPoint
    {
        private int _r;
        private int _g;
        private int _b;
        
        public int R
        {
            get => _r;
            set =>
                _r = value switch
                {
                    > 255 => 255,
                    < 0   => 0,
                    _     => value
                };
        }
        public int G
        {
            get => _g;
            set =>
                _g = value switch
                {
                    > 255 => 255,
                    < 0   => 0,
                    _     => value
                };
        }
        public int B
        {
            get => _b;
            set =>
                _b = value switch
                {
                    > 255 => 255,
                    < 0   => 0,
                    _     => value
                };
        }
    }
}
namespace Programming.Models.Classes
{
    //поправлю еще класс Rectangle
    //для того чтобы понять почему выпадает NullReferenceException
    public class Rectangle
    {
        private int _id;
        private string _name;
        private double _width;
        private double _length;
        private string _color;

        private static int _allRectanglesCount;

        public static int AllRectanglesCount { get { return _allRectanglesCount; } }

        public int Id { get { return _id; } }
        public string Name { get; set; }

        public string Color { get; set; }

        public double Width
        {
            get { return _width; }
            set
            {
                if (value > 0.0d) //еще желательно писать буквы f и d в конце значений примитивов float, double
                {
                    _width = value;
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} не является подходящим числом", _width), "width");
                }
            }
        }

        public double Length
        {
            get { return _length; }
            set
            {
                if (value > 0.0d) //еще желательно писать буквы f и d в конце значений примитивов float, double
                {
                    _length = value;
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} не является подходящим числом", _length), "height");
                }
            }
        }

        public Point2D Center { get; private set; }


        public Rectangle()
        {
        }

        public Rectangle(double width, double height, string color)
        {
            Width = width;
            Length = height;
            Color = color;
            double centerX = width / 2.0;
            double centerY = height / 2.0;
            Center = new Point2D(centerX, centerY);
            _allRectanglesCount++;
            _id = AllRectanglesCount;
            
        }
        
        public string[] answRec()
        {
            string[] answ = { Name, Width.ToString(), Length.ToString(), Color };
            return answ;
        }
        
        public int FindRectangleWithMaxWidth()
        {
            return (int)Width;
        }
    }
}
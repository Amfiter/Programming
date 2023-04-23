namespace Programming.Models.Classes
{
    //поправлю еще класс Rectangle
    //для того чтобы понять почему выпадает NullReferenceException
    internal class Rectangle
    {
        private string _name;
        private double _width;
        private double _height;
        private string _color;

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

        public double Height
        {
            get { return _height; }
            set
            {
                if (value > 0.0d) //еще желательно писать буквы f и d в конце значений примитивов float, double
                {
                    _height = value;
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} не является подходящим числом", _height), "height");
                }
            }
        }


        public Rectangle()
        {
        }

        public Rectangle(double width, double height, string color)
        {
            Width = width;
            Height = height;
            Color = color;
        }


        /*private void Check(double width, double height)
        {
            if (width > 0.0 & height > 0.0)
            {
                Width = width;
                Height = height;
            }
            else
            {
                throw new ArgumentException(String.Format("{0} не является подходящим числом", width), "width");
            }
        }*/
        public string[] answRec()
        {
            string[] answ = { Name, Width.ToString(), Height.ToString(), Color };
            return answ;
        }

        /*public void Chenge(double width, double height, string color)//непонятно зачем этот метод
        {
            Check(width, height);
            Color = color;

        }*/
        public int FindRectangleWithMaxWidth()
        {
            return (int)Width;
        }
    }
}
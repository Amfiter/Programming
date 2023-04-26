using Programming.Models.Classes;
using Programming.Models.Enums;
using System.Windows.Forms;
using Rectangle = Programming.Models.Classes.Rectangle;

namespace Programming
{
    public partial class MainForm : Form
    {
        string[] enums = { "Colors", "EducationForm", "Genre", "Menufactures", "Season", "Weekday" };

        private Rectangle[] _rectangles; //ты тут создаешь пять объектов rectangle,все поля по умолчанию заполняются null значениями, пункт 12 нужно проинициализировать массив _rectangles в конструкторе главного окна

        private Movie[] _movie;
        private Rectangle _currentRectangle;
        private Movie _currentMovie = new Movie();
        private string[] _colors = { "Orange", "Black", "Red", "Green", "Blue" };
        private int max = 0;

        public MainForm()
        {
            _rectangles = new Rectangle[5];
            _movie = new Movie[5];
            InitializeComponent();
            InitRectanglesAndMovies();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SetSelected(0, true);
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueListBox.Items.Clear();
            ListBox listbox = (ListBox)sender;
            string elem = listbox.SelectedItem as string;
            switch (elem)
            {
                case "Colors":
                    ValueListBox.Items.AddRange(typeof(Colors).GetEnumNames());
                    break;
                case "EducationForm":
                    ValueListBox.Items.AddRange(typeof(EducationForm).GetEnumNames());
                    break;
                case "Genre":
                    ValueListBox.Items.AddRange(typeof(Genre).GetEnumNames());
                    break;
                case "Season":
                    ValueListBox.Items.AddRange(typeof(Season).GetEnumNames());
                    break;
                case "Menufactures":
                    ValueListBox.Items.AddRange(typeof(Menufactures).GetEnumNames());
                    break;
                case "Weekday":
                    ValueListBox.Items.AddRange(typeof(Weekday).GetEnumNames());
                    break;
            }
        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntTextBox.Text = ValueListBox.SelectedIndex.ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday week;
            if (Enum.TryParse<Weekday>(ParseTextBox.Text, out week))
                ParseLabel.Text = $"«Это день недели ({week} = {((int)week + 1)})»";
            else ParseLabel.Text = "Нет такого дня недели!";
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            string selectedSeason = SeasonComboBox.SelectedItem.ToString();
            switch (selectedSeason)
            {
                case "Winter":
                    MessageBox.Show("Брр, холодища!");
                    break;
                case "Summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Spring":
                    GroupBox.BackColor = Color.GreenYellow;
                    break;
                case "Autumn":
                    GroupBox.BackColor = Color.Orange;
                    break;
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            max = 0;
            int index = 0;
            for (int i = 0; i < _rectangles.Length; i++)
            {
                if (max < _rectangles[i].FindRectangleWithMaxWidth())
                {
                    max = _rectangles[i].FindRectangleWithMaxWidth();
                    index = i;
                }
            }

            MessageBox.Show($"Наибольший прямоугольник с индексом - {index}");
            RectListBox.SetSelected(index, true);
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LengthTextBox.Text != "" & WidthTextBox.Text != "" & ColorTextBox.Text != "")
            {
                try
                {
                    ColorTextBox.BackColor = Color.White;
                    //в коде ниже постоянно создается объект,из за чего вызывается конструктор и поле id меняется, это не нужно делать при валидации
                    /*_currentRectangle = new Models.Classes.Rectangle(
                        Convert.ToInt32(WidthTextBox.Text),
                        Convert.ToInt32(HeightTextBox.Text),
                        ColorTextBox.Text);
                    _rectangles[(int)RectListBox.SelectedIndex] = _currentRectangle;*/
                }
                catch
                {
                    ColorTextBox.BackColor = Color.LightPink;
                }
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LengthTextBox.Text != "" & WidthTextBox.Text != "" & ColorTextBox.Text != "")
            {
                try
                {
                    WidthTextBox.BackColor = Color.White;
                    //в коде ниже постоянно создается объект,из за чего вызывается конструктор и поле id меняется, это не нужно делать при валидации
                    /*_currentRectangle = new Models.Classes.Rectangle(
                        Convert.ToInt32(WidthTextBox.Text),
                        Convert.ToInt32(HeightTextBox.Text),
                        ColorTextBox.Text);
                    _rectangles[(int)RectListBox.SelectedIndex] = _currentRectangle;*/
                }
                catch
                {
                    WidthTextBox.BackColor = Color.LightPink;
                }
            }
        }

        private void RectListBox_SelectedIndexChanged(object sender, EventArgs e) // в этом методе баг, при выборе прямоугольника значения height и width меняются,
        {
            Rectangle answr = _rectangles[RectListBox.SelectedIndex];
            IdTextBox.Text = answr.Id.ToString();
            ColorTextBox.Text = answr.Color.ToString();
            LengthTextBox.Text = answr.Length.ToString();
            WidthTextBox.Text = answr.Width.ToString();
            XCoordinateTextBox.Text = answr.Center.X.ToString();
            YCoordinateTextBox.Text = answr.Center.Y.ToString();
            _currentRectangle = _rectangles[(int)RectListBox.SelectedIndex];
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            max = 0;
            int index = 0;
            for (int i = 0; i < _movie.Length; i++)
            {
                if (max < _movie[i].FindMovieWithMaxRating())
                {
                    max = _movie[i].FindMovieWithMaxRating();
                    index = i;
                }
            }

            MessageBox.Show($"Самый рейтинговый фильм с индексом - {index}");
            MovieListBox.SetSelected(index, true);
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] answr = _movie[MovieListBox.SelectedIndex].answRec();
            TitleTextBox.Text = answr[0];
            DurationTextBox.Text = answr[1];
            YearTextBox.Text = answr[2];
            GenreTextBox.Text = answr[3];
            RatingTextBox.Text = answr[4];
            _currentMovie = _movie[(int)MovieListBox.SelectedIndex];
        }

        /*private void ClassTabPage_Click(object sender, EventArgs e) // этот метод можно удалить, я закомментил в MainForm.designer.cs 
        { 
        }*/

        // пункт 12 инициализация должна происходить в главном окне нужно перенести вызов метода ClassTabPage_Click в MainForm, параметры в методе в данном случае не нужны
        // ну и заодно перенесем логику метода в отдельный метод InitRectanglesAndMovies
        // разбей инициализацию прямоугольников и фильмов на два метода, сейчас у тебя метод делает логику с объектами не связанную друг с другом по смыслу
        // почитай про Single Responsibility паттерн( один из парадигм SOLID )
        private void InitRectanglesAndMovies()
        {
            Random rd = new Random();
            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Rectangle(Convert.ToDouble(rd.Next(1, 244)),
                    Convert.ToDouble(rd.Next(1, 244)), _colors[rd.Next(0, 4)]);
                //RectListBox.Items.Add($"Rectangle {i + 1}");// это строка не нужна либо если ты хочешь переписывать объект который уже хранится в листе тебе нужно вызвать по индексу объект из массива
                //либо если ты хочешь добавлять прямоугольники не обновляя старые, тебе нужно для начала очистить старый лист от пустых объектов с помощью метода Clear
                RectListBox.Items[i] = ($"Rectangle {i + 1}");
                //ошибки NullReferenseException возникали потому что ты тут переписываешь поля объектов в массиве а потом зачем то добавляешь в RectListBox пустой объект с имененм Rectangle {i + 1} 
            }

            RectListBox.SetSelected(0, true);
            var Movie = new[]
            {
                new Movie("Дракула", 320, 1999, "Ужасы", 7),
                new Movie("Золушка", 170, 1989, "Мультфильм", 8),
                new Movie("Зебра", 620, 2013, "Научный", 5),
                new Movie("Аватар2", 330, 2023, "Фантастика", 9),
                new Movie("Пинокио", 120, 2013, "Мультфильм", 6)
            };
            _movie = Movie.ToArray();
            for (int j = 0; j < _movie.Length; j++)
            {
                // MovieListBox.Items.Add($"Фильм {j + 1}"); // тут так же как и с прямоугольниками
                MovieListBox.Items[j] = ($"Фильм {j + 1}");
            }

            MovieListBox.SetSelected(0, true);
        }
    }
}
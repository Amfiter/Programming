using Programming.Models.Classes;
using Programming.Models.Enums;
using System.Windows.Forms;
using Rectangle = Programming.Models.Classes.Rectangle;

namespace Programming
{
    public partial class MainForm : Form
    {
        string[] enums = { "Colors", "EducationForm", "Genre", "Menufactures", "Season", "Weekday" };

        private Rectangle[] _rectangles; //�� ��� �������� ���� �������� rectangle,��� ���� �� ��������� ����������� null ����������, ����� 12 ����� ������������������� ������ _rectangles � ������������ �������� ����

        private Movie[] _movie;
        private Rectangle _currentRectangle = new Rectangle();
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
                ParseLabel.Text = $"���� ���� ������ ({week} = {((int)week + 1)})�";
            else ParseLabel.Text = "��� ������ ��� ������!";
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            string selectedSeason = SeasonComboBox.SelectedItem.ToString();
            switch (selectedSeason)
            {
                case "Winter":
                    MessageBox.Show("���, ��������!");
                    break;
                case "Summer":
                    MessageBox.Show("���! ������!");
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

            MessageBox.Show($"���������� ������������� � �������� - {index}");
            RectListBox.SetSelected(index, true);
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (HeightTextBox.Text != "" & WidthTextBox.Text != "" & ColorTextBox.Text != "")
            {
                try
                {
                    ColorTextBox.BackColor = Color.White;
                    _currentRectangle = new Models.Classes.Rectangle(
                        Convert.ToInt32(WidthTextBox.Text), 
                        Convert.ToInt32(HeightTextBox.Text),
                        ColorTextBox.Text);
                    _rectangles[(int)RectListBox.SelectedIndex] = _currentRectangle;
                }
                catch
                {
                    ColorTextBox.BackColor = Color.LightPink;
                }
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (HeightTextBox.Text != "" & WidthTextBox.Text != "" & ColorTextBox.Text != "")
            {
                try
                {
                    WidthTextBox.BackColor = Color.White;
                    _currentRectangle = new Models.Classes.Rectangle(
                        Convert.ToInt32(WidthTextBox.Text),
                        Convert.ToInt32(HeightTextBox.Text),
                        ColorTextBox.Text);// ��� ���� ������ ��-�� ���� �������� height � width �������� ������� ��� ������ �������������� �� ������
                                           // �������� ������������ � ����������� ����������� (��� ������������ Rectangle(height,width,color) => ��� ���� Rectangle(width,height,color)
                    _rectangles[(int)RectListBox.SelectedIndex] = _currentRectangle;
                }
                catch
                {
                    WidthTextBox.BackColor = Color.LightPink;
                }
            }
        }

        private void RectListBox_SelectedIndexChanged(object sender, EventArgs e) // � ���� ������ ���, ��� ������ �������������� �������� height � width ��������,
        {
            //string[] answr = _rectangles[RectListBox.SelectedIndex].answRec(); // ����� answRec �������� �����������, �������� ������� �������� ������� �������� �� ������� �� �����������, ������� width � height �������� �������
            //LenghtTextBox.Text = answr[2];
            //WidthTextBox.Text = answr[1];
            //ColorTextBox.Text = answr[3];
            //_currentRectangle = _rectangles[(int)RectListBox.SelectedIndex];

            //���������� ����������� ����� ���� �������, � �� ����� �������, ������ ���:
            //1. ��� ��������������� � �������
            //2. ���� ����������� ����� �������, ����� ���������� � ���������
            Rectangle answr = _rectangles[RectListBox.SelectedIndex];
            ColorTextBox.Text = answr.Color.ToString();
            HeightTextBox.Text =answr.Height.ToString();
            WidthTextBox.Text = answr.Width.ToString();
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

            MessageBox.Show($"����� ����������� ����� � �������� - {index}");
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

        /*private void ClassTabPage_Click(object sender, EventArgs e) // ���� ����� ����� �������, � ����������� � MainForm.designer.cs 
        { 
        }*/

        // ����� 12 ������������� ������ ����������� � ������� ���� ����� ��������� ����� ������ ClassTabPage_Click � MainForm, ��������� � ������ � ������ ������ �� �����
        // �� � ������ ��������� ������ ������ � ��������� ����� InitRectanglesAndMovies
        // ������ ������������� ��������������� � ������� �� ��� ������, ������ � ���� ����� ������ ������ � ��������� �� ��������� ���� � ������ �� ������
        // ������� ��� Single Responsibility �������( ���� �� �������� SOLID )
        private void InitRectanglesAndMovies() 
        {
            Random rd = new Random();
            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Rectangle(Convert.ToDouble(rd.Next(1, 244)),
                    Convert.ToDouble(rd.Next(1, 244)), _colors[rd.Next(0, 4)]);
                    //RectListBox.Items.Add($"Rectangle {i + 1}");// ��� ������ �� ����� ���� ���� �� ������ ������������ ������ ������� ��� �������� � ����� ���� ����� ������� �� ������� ������ �� �������
                    //���� ���� �� ������ ��������� �������������� �� �������� ������, ���� ����� ��� ������ �������� ������ ���� �� ������ �������� � ������� ������ Clear
                    RectListBox.Items[i] = ($"Rectangle {i + 1}");
                    //������ NullReferenseException ��������� ������ ��� �� ��� ������������� ���� �������� � ������� � ����� ����� �� ���������� � RectListBox ������ ������ � ������� Rectangle {i + 1} 
            }

            RectListBox.SetSelected(0, true);
            var Movie = new[]
            {
                new Movie("�������", 320, 1999, "�����", 7),
                new Movie("�������", 170, 1989, "����������", 8),
                new Movie("�����", 620, 2013, "�������", 5),
                new Movie("������2", 330, 2023, "����������", 9),
                new Movie("�������", 120, 2013, "����������", 6)
            };
            _movie = Movie.ToArray();
            for (int j = 0; j < _movie.Length; j++)
            {
                // MovieListBox.Items.Add($"����� {j + 1}"); // ��� ��� �� ��� � � ����������������
                MovieListBox.Items[j] = ($"����� {j + 1}");
            }

            MovieListBox.SetSelected(0, true);
        }
    }
}
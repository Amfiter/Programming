namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ClassTabPage = new TabPage();
            groupBox4 = new GroupBox();
            FindMovieButton = new Button();
            label13 = new Label();
            label12 = new Label();
            RatingTextBox = new TextBox();
            GenreTextBox = new TextBox();
            YearTextBox = new TextBox();
            DurationTextBox = new TextBox();
            label11 = new Label();
            label10 = new Label();
            TitleTextBox = new TextBox();
            label9 = new Label();
            MovieListBox = new ListBox();
            groupBox2 = new GroupBox();
            label14 = new Label();
            IdTextBox = new TextBox();
            CoordinateY = new Label();
            YCoordinateTextBox = new TextBox();
            XCoordinateTextBox = new TextBox();
            XCoordinate = new Label();
            FindButton = new Button();
            ColorTextBox = new TextBox();
            label8 = new Label();
            WidthTextBox = new TextBox();
            label7 = new Label();
            LengthTextBox = new TextBox();
            label6 = new Label();
            RectListBox = new ListBox();
            tabPage1 = new TabPage();
            groupBox3 = new GroupBox();
            ParseLabel = new Label();
            ParseButton = new Button();
            ParseTextBox = new TextBox();
            label5 = new Label();
            GroupBox = new GroupBox();
            GoButton = new Button();
            SeasonComboBox = new ComboBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            IntTextBox = new TextBox();
            label3 = new Label();
            ValueListBox = new ListBox();
            label2 = new Label();
            EnumsListBox = new ListBox();
            label1 = new Label();
            TabControl = new TabControl();
            ClassTabPage.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            GroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            TabControl.SuspendLayout();
            SuspendLayout();
            // 
            // ClassTabPage
            // 
            ClassTabPage.Controls.Add(groupBox4);
            ClassTabPage.Controls.Add(groupBox2);
            ClassTabPage.Location = new Point(4, 24);
            ClassTabPage.Margin = new Padding(3, 2, 3, 2);
            ClassTabPage.Name = "ClassTabPage";
            ClassTabPage.Padding = new Padding(3, 2, 3, 2);
            ClassTabPage.Size = new Size(1055, 462);
            ClassTabPage.TabIndex = 1;
            ClassTabPage.Text = "Classes";
            ClassTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(FindMovieButton);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(RatingTextBox);
            groupBox4.Controls.Add(GenreTextBox);
            groupBox4.Controls.Add(YearTextBox);
            groupBox4.Controls.Add(DurationTextBox);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(TitleTextBox);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(MovieListBox);
            groupBox4.Location = new Point(428, 15);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(423, 371);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Movie";
            // 
            // FindMovieButton
            // 
            FindMovieButton.Location = new Point(249, 292);
            FindMovieButton.Margin = new Padding(3, 2, 3, 2);
            FindMovieButton.Name = "FindMovieButton";
            FindMovieButton.Size = new Size(82, 22);
            FindMovieButton.TabIndex = 11;
            FindMovieButton.Text = "Find";
            FindMovieButton.UseVisualStyleBackColor = true;
            FindMovieButton.Click += FindMovieButton_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(213, 241);
            label13.Name = "label13";
            label13.Size = new Size(44, 15);
            label13.TabIndex = 10;
            label13.Text = "Rating:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(213, 189);
            label12.Name = "label12";
            label12.Size = new Size(41, 15);
            label12.TabIndex = 9;
            label12.Text = "Genre:";
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new Point(213, 258);
            RatingTextBox.Margin = new Padding(3, 2, 3, 2);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new Size(164, 23);
            RatingTextBox.TabIndex = 8;
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(213, 206);
            GenreTextBox.Margin = new Padding(3, 2, 3, 2);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(164, 23);
            GenreTextBox.TabIndex = 7;
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(213, 154);
            YearTextBox.Margin = new Padding(3, 2, 3, 2);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(164, 23);
            YearTextBox.TabIndex = 6;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(213, 98);
            DurationTextBox.Margin = new Padding(3, 2, 3, 2);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(164, 23);
            DurationTextBox.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(213, 131);
            label11.Name = "label11";
            label11.Size = new Size(89, 15);
            label11.TabIndex = 4;
            label11.Text = "Year_of_release:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(213, 80);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 3;
            label10.Text = "Duration:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(213, 44);
            TitleTextBox.Margin = new Padding(3, 2, 3, 2);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(164, 23);
            TitleTextBox.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(213, 26);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 1;
            label9.Text = "Title:";
            // 
            // MovieListBox
            // 
            MovieListBox.FormattingEnabled = true;
            MovieListBox.ItemHeight = 15;
            MovieListBox.Items.AddRange(new object[] { "Movie1", "Movie2", "Movie3", "Movie4", "Movie5" });
            MovieListBox.Location = new Point(5, 26);
            MovieListBox.Margin = new Padding(3, 2, 3, 2);
            MovieListBox.Name = "MovieListBox";
            MovieListBox.Size = new Size(185, 289);
            MovieListBox.TabIndex = 0;
            MovieListBox.SelectedIndexChanged += MovieListBox_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(IdTextBox);
            groupBox2.Controls.Add(CoordinateY);
            groupBox2.Controls.Add(YCoordinateTextBox);
            groupBox2.Controls.Add(XCoordinateTextBox);
            groupBox2.Controls.Add(XCoordinate);
            groupBox2.Controls.Add(FindButton);
            groupBox2.Controls.Add(ColorTextBox);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(WidthTextBox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(LengthTextBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(RectListBox);
            groupBox2.Location = new Point(8, 15);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(415, 371);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rectangles";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(219, 21);
            label14.Name = "label14";
            label14.Size = new Size(17, 15);
            label14.TabIndex = 13;
            label14.Text = "Id";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(214, 39);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(166, 23);
            IdTextBox.TabIndex = 12;
            // 
            // CoordinateY
            // 
            CoordinateY.AutoSize = true;
            CoordinateY.Location = new Point(219, 233);
            CoordinateY.Name = "CoordinateY";
            CoordinateY.Size = new Size(74, 15);
            CoordinateY.TabIndex = 11;
            CoordinateY.Text = "Y coordinate";
            // 
            // YCoordinateTextBox
            // 
            YCoordinateTextBox.Location = new Point(214, 251);
            YCoordinateTextBox.Name = "YCoordinateTextBox";
            YCoordinateTextBox.ReadOnly = true;
            YCoordinateTextBox.Size = new Size(163, 23);
            YCoordinateTextBox.TabIndex = 10;
            // 
            // XCoordinateTextBox
            // 
            XCoordinateTextBox.Location = new Point(214, 207);
            XCoordinateTextBox.Name = "XCoordinateTextBox";
            XCoordinateTextBox.ReadOnly = true;
            XCoordinateTextBox.Size = new Size(163, 23);
            XCoordinateTextBox.TabIndex = 9;
            // 
            // XCoordinate
            // 
            XCoordinate.AutoSize = true;
            XCoordinate.Location = new Point(217, 189);
            XCoordinate.Name = "XCoordinate";
            XCoordinate.Size = new Size(76, 15);
            XCoordinate.TabIndex = 8;
            XCoordinate.Text = "X Coordinate";
            // 
            // FindButton
            // 
            FindButton.Location = new Point(249, 292);
            FindButton.Margin = new Padding(3, 2, 3, 2);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(82, 22);
            FindButton.TabIndex = 7;
            FindButton.Text = "Find";
            FindButton.UseVisualStyleBackColor = true;
            FindButton.Click += FindButton_Click;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(215, 164);
            ColorTextBox.Margin = new Padding(3, 2, 3, 2);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(165, 23);
            ColorTextBox.TabIndex = 6;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(217, 147);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 5;
            label8.Text = "Color:";
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(215, 122);
            WidthTextBox.Margin = new Padding(3, 2, 3, 2);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(165, 23);
            WidthTextBox.TabIndex = 4;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(214, 105);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 3;
            label7.Text = "Width:";
            // 
            // LengthTextBox
            // 
            LengthTextBox.Location = new Point(215, 80);
            LengthTextBox.Margin = new Padding(3, 2, 3, 2);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(165, 23);
            LengthTextBox.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(215, 63);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 1;
            label6.Text = "Length:";
            // 
            // RectListBox
            // 
            RectListBox.FormattingEnabled = true;
            RectListBox.ItemHeight = 15;
            RectListBox.Items.AddRange(new object[] { "Rectangle1", "Rectangle2", "Rectangle3", "Rectangle4", "Rectangle5" });
            RectListBox.Location = new Point(5, 26);
            RectListBox.Margin = new Padding(3, 2, 3, 2);
            RectListBox.Name = "RectListBox";
            RectListBox.Size = new Size(181, 289);
            RectListBox.TabIndex = 0;
            RectListBox.SelectedIndexChanged += RectListBox_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(GroupBox);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(1055, 462);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ParseLabel);
            groupBox3.Controls.Add(ParseButton);
            groupBox3.Controls.Add(ParseTextBox);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(8, 279);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(336, 128);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Weekday Parsing";
            // 
            // ParseLabel
            // 
            ParseLabel.AutoSize = true;
            ParseLabel.Location = new Point(17, 92);
            ParseLabel.Name = "ParseLabel";
            ParseLabel.Size = new Size(0, 15);
            ParseLabel.TabIndex = 3;
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(230, 57);
            ParseButton.Margin = new Padding(3, 2, 3, 2);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(82, 22);
            ParseButton.TabIndex = 2;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // ParseTextBox
            // 
            ParseTextBox.Location = new Point(17, 57);
            ParseTextBox.Margin = new Padding(3, 2, 3, 2);
            ParseTextBox.Name = "ParseTextBox";
            ParseTextBox.Size = new Size(190, 23);
            ParseTextBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 38);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 0;
            label5.Text = "Type value for parsing:";
            // 
            // GroupBox
            // 
            GroupBox.Controls.Add(GoButton);
            GroupBox.Controls.Add(SeasonComboBox);
            GroupBox.Controls.Add(label4);
            GroupBox.Location = new Point(349, 279);
            GroupBox.Margin = new Padding(3, 2, 3, 2);
            GroupBox.Name = "GroupBox";
            GroupBox.Padding = new Padding(3, 2, 3, 2);
            GroupBox.Size = new Size(326, 128);
            GroupBox.TabIndex = 1;
            GroupBox.TabStop = false;
            GroupBox.Text = "Season Handle";
            // 
            // GoButton
            // 
            GoButton.Location = new Point(222, 56);
            GoButton.Margin = new Padding(3, 2, 3, 2);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(82, 22);
            GoButton.TabIndex = 2;
            GoButton.Text = "Go!";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += GoButton_Click;
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Items.AddRange(new object[] { "Winter", "Summer", "Spring", "Autumn" });
            SeasonComboBox.Location = new Point(19, 56);
            SeasonComboBox.Margin = new Padding(3, 2, 3, 2);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(176, 23);
            SeasonComboBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 38);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 0;
            label4.Text = "Choose season:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(IntTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ValueListBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(EnumsListBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(8, 16);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(667, 248);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enumerations";
            // 
            // IntTextBox
            // 
            IntTextBox.Location = new Point(476, 49);
            IntTextBox.Margin = new Padding(3, 2, 3, 2);
            IntTextBox.Name = "IntTextBox";
            IntTextBox.Size = new Size(148, 23);
            IntTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(476, 24);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "Int value:";
            // 
            // ValueListBox
            // 
            ValueListBox.FormattingEnabled = true;
            ValueListBox.ItemHeight = 15;
            ValueListBox.Location = new Point(248, 49);
            ValueListBox.Margin = new Padding(3, 2, 3, 2);
            ValueListBox.Name = "ValueListBox";
            ValueListBox.Size = new Size(180, 184);
            ValueListBox.TabIndex = 3;
            ValueListBox.SelectedIndexChanged += ValueListBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 24);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 2;
            label2.Text = "Choose value:";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Location = new Point(17, 49);
            EnumsListBox.Margin = new Padding(3, 2, 3, 2);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(181, 184);
            EnumsListBox.TabIndex = 1;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 24);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 0;
            label1.Text = "Choose enumeration:";
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabPage1);
            TabControl.Controls.Add(ClassTabPage);
            TabControl.Location = new Point(-1, 2);
            TabControl.Margin = new Padding(3, 2, 3, 2);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1063, 490);
            TabControl.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 511);
            Controls.Add(TabControl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Programming Demo";
            Load += MainForm_Load;
            ClassTabPage.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            GroupBox.ResumeLayout(false);
            GroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            TabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage ClassTabPage;
        private GroupBox groupBox4;
        private Button FindMovieButton;
        private Label label13;
        private Label label12;
        private TextBox RatingTextBox;
        private TextBox GenreTextBox;
        private TextBox YearTextBox;
        private TextBox DurationTextBox;
        private Label label11;
        private Label label10;
        private TextBox TitleTextBox;
        private Label label9;
        private ListBox MovieListBox;
        private GroupBox groupBox2;
        private Button FindButton;
        private TextBox ColorTextBox;
        private Label label8;
        private TextBox WidthTextBox;
        private Label label7;
        private TextBox LengthTextBox;
        private Label label6;
        private ListBox RectListBox;
        private TabPage tabPage1;
        private GroupBox groupBox3;
        private Label ParseLabel;
        private Button ParseButton;
        private TextBox ParseTextBox;
        private Label label5;
        private GroupBox GroupBox;
        private Button GoButton;
        private ComboBox SeasonComboBox;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox IntTextBox;
        private Label label3;
        private ListBox ValueListBox;
        private Label label2;
        private ListBox EnumsListBox;
        private Label label1;
        private TabControl TabControl;
        private Label XCoordinate;
        private TextBox XCoordinateTextBox;
        private TextBox YCoordinateTextBox;
        private Label CoordinateY;
        private TextBox IdTextBox;
        private Label label14;
    }
}
namespace Programming.Models.Classes
{
    internal class Discipline
    {
        private string _title;
        private int _numberOfHours;
        private int _scores;

        public string Title { get; set; }

        public int NumberOfHours
        {
            get { return _numberOfHours; }
            set { _numberOfHours = Validator.AssertOnPositiveValue(value); }
        }

        public int Scores
        {
            get { return _scores; }
            set { _scores = Validator.AssertOnPositiveValue(value); }
        }

        public Discipline(string title, int number, int scores)
        {
            Title = title;
            NumberOfHours = number;
            Scores = scores;
        }
    }
}
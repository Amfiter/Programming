namespace Programming.Models.Classes
{
    internal class Movie
    {
        private string Title { get; set; }
        private int Duration { get; set; }

        private int Year_of_release { get; set; }

        private string Genre { get; set; }
        private double Rating { get; set; }

        public Movie(string title, int duration, int year, string genre, double rating)
        {
            Check(title, duration, year, genre, rating);
        }

        public Movie()
        {
        }

        private void Check(string title, int deration, int year, string genre, double rating)
        {
            Title = title;
            Duration = deration;
            Year_of_release = year;
            if (year >= 1900 & year <= DateTime.Now.Year) //тут добавил условие от 1900 года до текущего
            {
                Year_of_release = year;
            }

            Genre = genre;
            if (rating >= 0.0 & rating <= 10.0) //тут больше равно нуля, т.к 0 скорее всего включительно
            {
                Rating = rating;
            }
            else
            {
                throw new ArgumentException(String.Format("{0} не является подходящим числом", rating), "rating");
            }
        }

        public string[] answRec()
        {
            string[] answ = { Title, Duration.ToString(), Year_of_release.ToString(), Genre, Rating.ToString() };
            return answ;
        }

        public int FindMovieWithMaxRating()
        {
            return (int)Rating;
        }
    }
}
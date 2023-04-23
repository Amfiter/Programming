namespace Programming.Models.Classes
{
    internal class Music
    {
        private string Group { get; set; }
        private string Genre { get; set; }
        private string Song { get; set; }
        private int Count { get; set; }

        public Music(string group, string genre, string song, int count)
        {
            Group = group;
            Genre = genre;
            Song = song;
            Check(count);
        }

        private void Check(int count)
        {
            if (count > 0)
            {
                Count = count;
            }
            else
            {
                throw new ArgumentException(String.Format("{0} не является подходящим числом", count), "count");
            }
        }
    }
}
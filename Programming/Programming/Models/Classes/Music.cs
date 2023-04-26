using System.Diagnostics;
using System.Reflection;

namespace Programming.Models.Classes
{
    internal class Music
    {
        private string _group;
        private string _genre;
        private string _song;
        private int _count;
        public string Group { get; set; }
        public string Genre { get; set; }
        public string Song { get; set; }
        public int Count
        {
            get { return _count;}
            set
            {
                _count = Validator.AssertOnPositiveValue(value);
            } 
        }

        public Music(string group, string genre, string song, int count)
        {
            Group = group;
            Genre = genre;
            Song = song;
            Count = count;
        }
    }
}
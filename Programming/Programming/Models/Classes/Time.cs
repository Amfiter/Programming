namespace Programming.Models.Classes
{
    internal class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;
        
        public int Hours //переименовал watch => hours (watch = физические часы)
        {
            
            get { return _hours; }
            set
            {
                _hours = Validator.AssertOnPositiveValue(value, 0, 23);
            }
        }

        public int Minutes
        {
            get { return _minutes; }
            set
            {
                _minutes = Validator.AssertOnPositiveValue(value, 0, 60);
            }
        }


        public int Seconds
        {
            get { return _seconds; }
            set
            {
                _seconds = Validator.AssertOnPositiveValue(value, 0, 60);
            }
        }

        public Time()
        {
        } // пункт 8 нужно добавить конструктор без аргументов который позволяет создать объект без инициализации полей

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds; 
        }
        
    }
}
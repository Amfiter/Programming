namespace Programming.Models.Classes
{
    internal class Time
    {
        //1. { get; set; } => авто свойства
        // под капотом автосвойства выглядят так
        /*
         private string hours;
         public string Hours
         {
            get { return this.hours; }
            set { this.hours = value; }
         }
         */

        //2. ты создала private свойства, по заданию нужно написать private поля и public свойства
        // т.е нужно писать так
        private int _hours;
        private int _minutes;
        private int _seconds;


        // пункт 7, по заданию нужно реализовать проверки в сеттере
        // тут ничего криминального нет то что ты сделала отдельный метод валидации Check
        // тут прикол в переиспользовании, вдруг тебе понадобится присвоить новое значение полю Minutes у созданного экземпляра класса Time
        // а валидация не пройдет т.к у тебя валидация только при инициализации объекта, поэтому нужно перенести метод Check в сеттер
        // cделаю на примере этого класса
        // по образу и подобию переделаешь все другие классы в которых нужна валидация
        public int Hours //переименовал watch => hours (watch = физические часы)
        {
            
            get { return _hours; }
            set
            {
                if (value >= 0 & value <= 23)
                {
                    _hours = value;
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} не является подходящим числом"));
                }
            }
        }

        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (value >= 0 & value <= 60)
                {
                    _minutes = value;
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} не является подходящим числом"));
                }
            }
        }


        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if (value >= 0 & value <= 60)
                {
                    _seconds = value;
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} не является подходящим числом"));
                }
            }
        }

        public Time()
        {
        } // пункт 8 нужно добавить конструктор без аргументов который позволяет создать объект без инициализации полей

        public Time(int hours, int minutes, int seconds)
        {
            Seconds = seconds; // после того как мы сделали валидацию в сеттерах метод Check нам не нужен, я закомментирую его вызов в конструкторе, его реализацию можно удалить
            //Check(hours, minutes); 
        }

        // ссылка на конвенцию написания кода на C# 
        // https://learn.microsoft.com/ru-ru/dotnet/csharp/fundamentals/coding-style/coding-conventions
        // проверь все поля в классах после того как исправишь все классы
        // private поля начинаются с нижнего  подчеркивания с маленькой буквы в стиле _сamelCase
        // public поля пишутся c маленькой буквы в camelCase
        // static поля пишутся в стиле snake_case
        // public и private свойства с большой буквы в стиле CamelCase
        // локальные переменные и без свойств пишутся с маленькой буквы в стиле camelCase

        private void Check(int hour, int min)
        {
            if (hour >= 0 & hour <= 23 & min >= 0 & min <= 60)
            {
                Hours = hour;
                Minutes = min;
            }
            else
            {
                throw new ArgumentException(String.Format("{0} не является подходящим числом"));
            }
        }
    }
}
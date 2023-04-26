namespace Programming.Models.Classes
{
    internal class Trip
    {
        private string _departurePoint;
        private int _flightTime;
        private string _destination;

        public string DeparturePoint { get; set; }

        public int FlightTime
        {
            get { return _flightTime; }
            set { _flightTime = Validator.AssertOnPositiveValue(value); }
        }

        public string Destination { get; set; }

        public Trip(string dp, string ds, int time)
        {
            DeparturePoint = dp;
            Destination = ds;
            FlightTime = time;
        }

        private void Check(int time)
        {
            if (time <= 0.0)
            {
                FlightTime = time;
            }
            else
            {
                throw new ArgumentException(String.Format("{0} не является подходящим числом", time), "time");
            }
        }
    }
}
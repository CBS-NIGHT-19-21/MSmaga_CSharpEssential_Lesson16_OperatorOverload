namespace Task4_DateOperators.Classes
{
    public struct Date 
    {
        private int _day;
        private int _month;
        private int _year;

        public Date(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
           
        }

        public int Day { get { return _day; } set { _day = value; } }
        public int Month { get { return _month; } set { _month = value; } }
        public int Year { get { return _year; } set { _year = value; } }
        public int Days { get { return GetDays(); } }

        public int GetDays() => GetDaysOfYears(this.Year) + GetDaysOfYear(this.Month, this.Day);

        private static int GetDaysOfYears(int year)
        {
            int numDay = 0;
            for (int i = 1; i < year; i++)
            {
                if (i != 0 && i % 4 == 0)
                    numDay += 366;
                else
                    numDay += 365;
            }
            return numDay;
        }
        private int GetDaysOfYear(int months, int days)
        {
            int numDay = 0;
            for (int i = 0; i < months; i++)
            {
                numDay += GetDayMonth(i);
            }
            return numDay += days;
        }
        private int GetDayMonth(int numMonth)
        {
            switch (numMonth)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;

                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;

                case 2:
                    if (this._year % 4 == 0 && this._year != 0) return 29;
                    else return 28;
                default: return 0;
            }
        }
       
        public static Date operator +(Date date1, int numDays)
        {
            int years = 1;
            int months = 1;

            int days = date1.GetDays() + numDays;
 
            while (days >= 365)
            {

                if (years != 0 && years % 4 == 0)
                {
                    days -= 366;
                }
                else
                {
                    days -= 365;
                }
                years++;
            }

            while (days >= 28)
            {
                days -= date1.GetDayMonth(months);

                if (months == 12)
                {
                    months = 0;
                    years++;
                }
                months++;
            }
            return new Date(days, months, years);
        }

        public void Show() =>
                    Console.WriteLine($"Day = {this.Day}, \tMonth = {this.Month}," +
                                      $" \tYear = {this.Year}: " +
                                      $"\t{this.Days} days from BC.");
        public static int operator -(Date d1, Date d2) => d1.GetDays() - d2.GetDays();
    }
}
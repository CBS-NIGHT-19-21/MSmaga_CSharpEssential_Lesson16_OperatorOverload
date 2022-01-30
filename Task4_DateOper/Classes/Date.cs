namespace Task4_DateOper.Classes
{
    public class Date
    {
        private int _day;
        private int _month;
        private int _year;

        public Date(int date, int month, int year)
        {
            _day = date;
            _month = month;
            _year = year;
        }
        public int Day { get { return _day; } set { _day = value; } }
        public int Month { get { return _month; } set { _month = value; } }
        public int Year { get { return _year; } set { _year = value; } }
    }

    public int GetDayMonth(int month, int year)
    {
        switch (month)
        {
            case 1:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                return 31;

            case 2:
            case 4:
            case 6:
            case 9:
            case 11:
                return 30;

            case 3:
                if (year % 4 == 0) return 29;
                else return 28;
            default: return 100;
        }
    }

}


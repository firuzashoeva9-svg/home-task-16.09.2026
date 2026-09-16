public class Date
{
    private int day;
    private int month;
    private int year;
    public int Day
    {
        get { return day; }
        set { day = value; }
    }

    public int Month
    {
        get { return month; }
        set { month = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }
    public Date()
    {
        day = 1;
        month = 1;
        year = 2000;
    }
    public Date(int day)
    {
        this.day = day;
        month = 1;
        year = 2000;
    }
    public Date(int day, int month)
    {
        this.day = day;
        this.month = month;
        year = 2000;
    }
    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }
    public void SetDate(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }
    public int GetDay()
    {
        return day;
    }

    public int GetMonth()
    {
        return month;
    }

    public int GetYear()
    {
        return year;
    }
    public override string ToString()
    {
        return $"{day:D2}/{month:D2}/{year:D4}";
    }
}
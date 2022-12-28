namespace MathTaskClassLibrary
{
    public class Work3
    {
        public int DaysCountByYear(int year)
        {
            if ((year % 100 == 0 && year % 400 != 0) || year % 4 != 0)
            {
                return 365;
            }
            return 366;
        }
    }
}
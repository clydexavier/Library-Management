internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // define the two dates
        DateTime date1 = DateTime.Now;
        DateTime date2 = DateTime.Now.AddDays(1);

        // calculate the time interval between the two dates
        TimeSpan interval = date2.Subtract(date1);

        // extract the number of days from the time interval
        double daysElapsed = interval.Days;

        // print the result
        Console.WriteLine("Days elapsed: " + daysElapsed);

    }
}
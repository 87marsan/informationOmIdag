namespace informationOmIdag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DagensInfo();
        }

        public static void DagensInfo()
        {
            var dagensDatum = DateTime.Now;
            var dayOfYear = dagensDatum.DayOfYear;
            var dayOfWeek = dagensDatum.DayOfWeek;
            var årstid = dagensDatum.IsDaylightSavingTime();
            var skottår = DateTime.IsLeapYear(DateTime.Now.Year);
            
            
            
            
            
            Console.WriteLine($"Datum     : {dagensDatum.ToString("dd MMM yyyy")}");
            Console.WriteLine($"Nummer    : {dayOfYear}");
            Console.WriteLine($"Veckodag  : {dayOfWeek}");
            Console.WriteLine($"Sommartid : {årstid}");
            Console.WriteLine($"Skottår   : {skottår}");
        }
    }
}
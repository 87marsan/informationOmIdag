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
            var nummer = dagensDatum.DayOfYear;
            var veckodag = dagensDatum.DayOfWeek;
            var sommartid = dagensDatum.IsDaylightSavingTime();
            var skottår = DateTime.IsLeapYear(DateTime.Now.Year);
            
            
            
            
            
            Console.WriteLine($"Datum     : {dagensDatum.ToString("dd MMM yyyy")}");
            Console.WriteLine($"Nummer    : {nummer}");
            Console.WriteLine($"Veckodag  : {veckodag}");
            Console.WriteLine($"Sommartid : {sommartid}");
            Console.WriteLine($"Skottår   : {skottår}");
        }
    }
}
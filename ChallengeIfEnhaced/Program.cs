namespace ChallengeIfEnhaced
{
    internal class Program
    {
        public static bool isInteger;
        public static int numberInt;
        public static string result = "";
        static void CheckTemperature(string number)
        {
            isInteger = Int32.TryParse(number, out numberInt);
            if (!isInteger)
            {
                result = "Not a valid Temperature.";
            }
            else
            {
                result = numberInt <= 15 ? "it is too cold here" : numberInt >= 16 && numberInt <= 28 ? "it is ok" : "it is hot here";
            }
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            CheckTemperature("15");
        }
    }
}
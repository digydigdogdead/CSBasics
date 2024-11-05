namespace CSBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            bool isLearningCs = true;
            string favouriteFilm = "Fight Club";
            favouriteFilm = "High School Musical";
            string firstName = "Finn";

            printGreeting(firstName);

            Console.WriteLine(subtractNumbers(2, 3));

            bool isFinnLongerThan3 = isStringLonger(firstName, 3);
            Console.WriteLine(isFinnLongerThan3);
        }

        private static void printGreeting(string name)
        {
            Console.WriteLine("Hello, " + name);
        }

        private static int subtractNumbers(int num1, int num2)
        {
            return num1 - num2;
        }

        private static bool isStringLonger(string str, int len)
        {
            if (str.Length > len) { return true; }
            else { return false; }
        }
    }
}

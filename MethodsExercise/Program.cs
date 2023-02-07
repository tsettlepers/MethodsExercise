namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which exercise do you wish to run? (1-2)");
            string exerciseCode = Console.ReadLine();
            if (exerciseCode == "1")
            {
                string userNm = takeString("Enter your name:");
                string faveColor = takeString("What is your favorite color?");
                string faveAnimal = takeString("What's your favorite animal?");
                string faveBand = takeString("Finally, enter your favorite band:");

                Console.WriteLine("");
                Console.WriteLine("---");
                Console.WriteLine($"Once upon a time, {userNm} decided to buy tickets to see {faveBand}");
                Console.WriteLine($"So he tossed his pet {faveAnimal} into his {faveColor} car, and off they went.");
                Console.WriteLine($"{userNm} thought the concert was amazing, but his {faveAnimal} was unimpressed.");
                Console.WriteLine("The End.");
            }
            else if (exerciseCode == "2") 
            {
                Console.WriteLine("");
                Console.WriteLine("---");
                Console.WriteLine($"Our addition method of AddNums(2,3) returns {AddNums(2, 3)}");
                Console.WriteLine($"Our addition method of AddNums(2,3,4) returns {AddNums(2,3,4)}");
                Console.WriteLine($"Our multiplication method of MultNums(2,3) returns {MultNums(2, 3)}");
                Console.WriteLine($"Our multiplication method of MultNums(2,3,4) returns {MultNums(2, 3, 4)}");
                Console.WriteLine($"Our subtraction method of DiffNums(2,3) returns {DiffNums(2, 3)}");
                Console.WriteLine($"Our subtraction method of DiffNums(2,3,4) returns {DiffNums(2, 3, 4)}");
            }
            else 
            {
                Console.WriteLine("Nice try. Yes, I checked for invalid entry.");
            }
        }

        private static string takeString(string str) 
        { 
            Console.WriteLine(str);
            string newVal = Console.ReadLine();
            return newVal;
        }

        private static int AddNums(params int[] v)
        {
            int tot = 0;

            foreach (int i in v)
            {
                tot += i;
            }
            return tot;
        }

        private static int MultNums(params int[] v)
        {
            int tot = 1;

            foreach (int i in v)
            {
                tot = tot*i;
            }
            return tot;
        }

        private static int DiffNums(params int[] v)
        {
            // This one is a little tricky... just have to make an assumption or else it'll turn out just as the negative sum
            int tot = 2 * v[0];

            foreach (int i in v)
            {
                tot -= i;
            }
            return tot;
        }
    }
}

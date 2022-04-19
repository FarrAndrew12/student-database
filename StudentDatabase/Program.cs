public class Program
{
    int studentnumber;
    int convertednumber;
    public static void Main()
    {
        //bool runAgain = true;
        //while runAgain = true
        while (true)
        { 
            string[] names = { "John", "Jack", "Jill", "Jane", "Joe" };
            string[] homeTowns = { "San Andreas", "Vice City", "Liberty City", "Los Santos", "Chinatown" };
            string[] favFood = { "Alfredo", "Pizza", "Popcorn", "Sphagetti", "Chicken Shwarma" };
            int input = 0;
            while (true)
            {
                Console.WriteLine("Welcome! Which student would you like to learn about? Enter a number between 1 and 5:");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                if (userChoice <= 0 || userChoice > names.Length + 1)
                {
                    Console.WriteLine("Please enter a valid number");
                    continue;
                }
                else
                {
                    input = userChoice - 1;
                    Console.WriteLine($"Student {userChoice} is { names[input]}");
                    break;
                }
            }
            //Console.WriteLine($"{names[input]}'s hometown is {homeTowns[input]}");
            //Console.WriteLine($"{names[input]}'s favorite food is {favFood[input]}");
            while (true)
            {
                Console.WriteLine("Would you like to learn about this student's Hometown or Favorite Food?");
                string UserInput = Console.ReadLine().ToLower();
                if (UserInput.Contains("town"))
                {
                    Console.WriteLine($"{names[input]}'s hometown is {homeTowns[input]}");
                    break;
                }
                else if (UserInput.Contains("food"))
                {
                    Console.WriteLine($"{names[input]}'s favorite food is {favFood[input]}");
                    break;
                }
                else
                {
                    Console.WriteLine("I am sorry, can you please try again?");
                    continue;
                }
              
            }
            Console.WriteLine("would you like to learn about another student? Enter Y for yes, and N for no:");
            string YesOrNo = Console.ReadLine().ToLower();

            if (YesOrNo == "y")
            {
                continue;
            }
            else if (YesOrNo == "n")
            {
                Console.WriteLine("Have a nice day");
                break;
            }
            else
            {
                break;
            }
                
        }
       
        
     }
}
using System;

namespace challengeone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            

           
            
                var Name=TryAnswer();
               
          

            Console.WriteLine("How old are you?");
           

           
                var Age=TryAnswer();
            

            Console.WriteLine("What month were you born in?");
            

           
                var BirthMonth=TryAnswer();
                
           

            Console.WriteLine($"Your Name is: {Name}." );

            Console.WriteLine($"You are {Age} years old.");

            Console.WriteLine($"You were born in {BirthMonth}.");

            if (BirthMonth=="September")
            {
                Console.WriteLine($"You are a Virgo.");
            }


            else if (BirthMonth == "March")
            {
                Console.WriteLine($"You are an Aries.");
            }

            else if (BirthMonth == "April")
            {
                Console.WriteLine($"You are a Taurus.");
            }
        }

        static string TryAnswer()
        {
            var Answer = Console.ReadLine();
            if (Answer == "")
            {
                Console.WriteLine("You didn't type anything, please try again?");
                return Console.ReadLine();
            }
            return Answer;

        }

            


        
    }
}

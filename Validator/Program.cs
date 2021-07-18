using System;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            //pin code validation
            Console.WriteLine("Please create your pin code between 4 and 8 digits");
            var pinCode = Console.ReadLine();

            int num = -1;
            if (!int.TryParse(pinCode, out num))
            {
                Console.WriteLine("Why are you using alphabets?");
            } else if (pinCode.Length < 4 || pinCode.Length > 8)
            {
                Console.WriteLine("Your pincode cannot be accepted. Please type between 4 and 8 digits.");
            } else
            {
                Console.WriteLine("Your pin is valid.");
            }

            //phone number validation
            Console.WriteLine("Please type your phone number.");
            var phoneNumber = Console.ReadLine();
            var removeExtra = string.Join("", phoneNumber.Split('-', '(', ')', ' '));
            if (removeExtra.Length != 10)
            {
                Console.WriteLine("Phone number invalid");
            }
            else if (removeExtra.StartsWith("555"))
            {
                Console.WriteLine("No area code starts with 555");
            } else
            {
                Console.WriteLine("Thank you for your personal information!");
            }

            //email address validation
            Console.WriteLine("Please enter your email address");
            var email = Console.ReadLine();
            var dot = 0;
            var at = 0;
            for (var i = 0; i < email.Length; i++)
            {
                if (email[i] == '.')
                {
                    dot += 1;
                } else if (email[i] == '@')
                {
                    at += 1;
                };
            }

            if (email[0] =='@')
            {
                Console.WriteLine("You are forgetting something before @");
            } 
            else if (at > 1)
            {
                Console.WriteLine("@ can be only one");
            } 
            else if (dot < 1)
            {
                Console.WriteLine("Are you forgetting dot?");
            } 
            else
            {
                Console.WriteLine("Your email address is valid");
            }

            //Sentence validation
            Console.WriteLine("Please enter your sentense");
            var sentence = Console.ReadLine();
            var correctSentence = "mOcKiNg SoMeOnE lIkE sPoNgEbOb!";
            if (sentence == correctSentence)
            {
                Console.WriteLine("Congrats! You got this right!");
            } 
            else
            {
                Console.WriteLine($"So close? Correct sentence is {correctSentence}");
            }

            //palindrome confirmation
            Console.WriteLine("I want you to type something and I can confirm if it is a palindrome");
            var palindrome = Console.ReadLine();
            string reverse = "";
            for (var i = (palindrome.Length - 1); i >= 0; i--)
            {
                reverse += palindrome[i];
            }
            
            if (palindrome == reverse)
            {
                Console.WriteLine("Congrats! You got it!");
            } 
            else
            {
                Console.WriteLine("You need more practice");            }

        }
    }
}

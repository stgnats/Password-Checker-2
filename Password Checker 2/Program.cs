using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool isLong = false;
            bool hasLower = false;
            bool hasUpper = false; 
            bool hasNumb = false;
            bool hasSymb = false;
            string symb = @"@'#~:;!£$%^&*()\|/?><.,*-+=`¬"; //using this instead of char.isSymbol() as the function doesnt recognise all the symbols people would use
            Console.Write("Please enter your password: ");
            string password = Console.ReadLine();
            if (password.Length >= 8) //checks if the password length is 8 or more
            {
                isLong = true;
            }
            for (int i = 0; i < password.Length; i++) //checks every character in password
            {
                char c = password[i]; //makes c whatever character of password the for loop is on
                for (int j = 0; j < symb.Length; j++) //checks every character in symb against the current character
                {
                    if (c == symb[j])
                    {
                        hasSymb = true;
                    }
                }
                if (char.IsUpper(c) == true) //checks for the other qualifiers
                {
                    hasUpper = true;
                } 
                if (char.IsLower(c) == true)
                {
                    hasLower = true;
                }
                if (char.IsNumber(c) == true)
                {
                    hasNumb = true;
                }
                if (hasUpper && hasLower && hasNumb && hasSymb && isLong) //ends the loop when all conditions are met
                {
                    break;
                }
            }
            if (hasUpper && hasLower && hasNumb && hasSymb && isLong)
            {
                Console.WriteLine("This password is strong");
            }
            else
            {
                Console.WriteLine("This password is not strong enough");
            }

        }
    }
}

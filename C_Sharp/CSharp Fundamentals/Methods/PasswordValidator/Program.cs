using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isValid = CheckIfValid(password);


            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }


        }

        static bool CheckIfValid(string password)
        {
            bool passwordIsValid = false;

            bool lengthisValid = false;

            if (password.Length >= 6 && password.Length <= 10)
            {
                lengthisValid = true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            //
            bool charsAreValid = false;

            for (int i = 0; i < password.Length; i++)
            {

                if ((password[i] >= 48 && password[i] <= 57)
                    || (password[i] >= 65 && password[i] <= 90)
                    || (password[i] >= 97 && password[i] <= 122))
                {
                    charsAreValid = true;

                }
                else
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    break;
                }
            }

            //

            bool digitsAreValid = false;

            int digitsCounter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    digitsCounter++;
                }
            }

            if (digitsCounter >= 2)
            {
                digitsAreValid = true;
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (lengthisValid && charsAreValid && digitsAreValid)
            {
                passwordIsValid = true;
            }

            return passwordIsValid;








        }





    }
}

using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Services
{
    public class UserService
    {
        // Log in
        public static User? UserLogIn()
        {
            Console.Clear();
            bool threeChancesLogIn = false;
            int i = 0;

            User loggedUsser = null;

            while (!threeChancesLogIn)
            {
                Console.WriteLine("=========================");

                Console.WriteLine("Please enter your username:");
                string userName = Console.ReadLine();
                Console.WriteLine("Please enter your password:");
                string password = Console.ReadLine();

                loggedUsser = UsersDB.Users.SingleOrDefault(x => x.UserName == userName && x.Password == password);

                i++;

                Console.Clear();

                if (!ValidateLogIn(userName, password))
                {
                    Console.WriteLine($"Username should contain more than 5 characters and password more than 6 characters. Your username contains {userName.Count()} characters and your password contains {password.Count()} characters. \n");
                    threeChancesLogIn = false;
                }

                if (loggedUsser == null)
                {
                    Console.WriteLine("The username and password doesn't match! \n");
                    threeChancesLogIn = false;
                }                

                if (loggedUsser != null)
                {
                    Console.WriteLine("You logged in succesfully!");
                    return loggedUsser;
                }

                if (i == 3)
                {
                    Console.WriteLine("You tried 3 trimes. Please try again with the log in process.");
                    return null;
                }
            }
            return loggedUsser;

        }


        public static bool ValidateLogIn (string userName, string password)
        {
            Console.WriteLine("=========================");

            if (userName.Count() < 5 || password.Count() < 6)
            {
                // Console.WriteLine($"Username should contain more than 5 characters and password more thatn 6 characters. Your username contains {userName.Count()} characters and your password contains {password.Count()} characters.");
                return false;
            }
            return true;
        }

        public static bool ValidateRegister ()
        {
            Console.WriteLine("=========================");

            Console.WriteLine("Please enter your username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();
 

            int age = 0;

            if (userName.Count() < 5 || password.Count() < 6)
            {
                Console.WriteLine($"Username should contain more than 5 characters and password more thatn 6 characters. Your username contains {userName.Count()} characters and your password contains {password.Count()} characters.");
                return false;
            }

            if (!(password.Any(char.IsUpper)))
            {
                Console.WriteLine("The password should contain at least one upper character!");
                return false;
            }

            if (!(password.Any(c => char.IsDigit(c))))
            {
                Console.WriteLine("In the password should be at least one number!");
                return false;
            }

            Console.WriteLine("Please enter your First name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your Last name:");
            string lastName = Console.ReadLine();


            if ((firstName.Any(c => char.IsDigit(c))) || (lastName.Any(c => char.IsDigit(c))))
            {
                Console.WriteLine("In the First name and Last name should not contain numbers!");
                return false;
            }

            Console.WriteLine("Please enter your age:");
            string ageString = Console.ReadLine();

            bool ageIsNum = int.TryParse(ageString, out age);
            if (!ageIsNum)
            {
                Console.WriteLine("You did not enterred a number, please try again.");
                return false;
            }

            if (age < 18 || age > 120)
            {
                Console.WriteLine("You are not in the allowed range of age. Please leave the app.");
                return false;
            }

            Console.WriteLine("Succesfully entered paramters!");
            Console.WriteLine("========================");
            UsersDB.Users.Add(new User { UserName = userName, Password = password, FirstName = firstName, LastName = lastName, Age = age });

            return true;
        }

        public static void RegisterInput()
        {
            int i = 0;
            bool isOkParametars = false;
            while(!isOkParametars)
            {
                i++;

                isOkParametars = ValidateRegister();

                if(!isOkParametars && i == 3)
                {
                    Console.WriteLine("You entered a wrong parametres for register 3 times. Please try again later!");
                    isOkParametars = true;
                }

            }
        }

        public static void ChooseOption()
        {
            bool option = false;
            while (!option)
            {
                Console.WriteLine("Hello from Time tracking App");
                Console.WriteLine("Please select a option you want to choose:");
                Console.WriteLine("1) Log In \n2) Register");
                bool isNum = int.TryParse(Console.ReadLine(), out int input);

                if (isNum)
                {
                    switch (input)
                    {
                        case 1:
                            option = true;

                            User loggedUSer = UserLogIn();
                            MainMenu(loggedUSer);
                            break;
                        case 2:
                            option = true;

                            RegisterInput();

                            User registerredUser = UserLogIn();
                            MainMenu(registerredUser);

                            break;
                        default:
                            Console.Clear();

                            Console.WriteLine("You did not enterred number between 1 and 2! \nPlease try again.");

                            break;
                    }
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("You did not enterred number. Try again");
                }
            }


        }
        
        public static void MainMenu(User user)
        {
            Console.Clear();

            Console.WriteLine($"Welcome dear user {user.UserName}");
            Console.WriteLine("Please choose the option you want to perform: \n1) Start/stop time, \n2) User statistics, \n3) Log out, \n4) Back to main menu, \n5) Account management");
        }
    }
}

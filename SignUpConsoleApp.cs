using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SignUpConsoleApp
{
    public class Program
    {
        public static string fn;
        public static string ln;
        public static string em;
        public static string bd;

        public static void restartProgram()
        {

            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();
            Console.WriteLine($"Hello, {fn} {ln}");
            Thread.Sleep(500);
            Console.WriteLine($"What do you want to do?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Type in 1 to visit your settings.");
            Console.WriteLine($"Type in 2 to visit commands.");
            Console.WriteLine($"Type in 3 to exit the program.");
            var response1 = Convert.ToInt32(Console.ReadLine());
            if (response1 == 1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                if (fn != null && allCharsWhiteSpace(fn) == false)
                {
                    Console.WriteLine("First name: " + fn);
                }
                else
                {
                    Console.WriteLine("First name: None");
                }

                if (ln != null && allCharsWhiteSpace(ln) == false)
                {
                    Console.WriteLine("Last name: " + ln);
                }
                else
                {
                    Console.WriteLine("Last name: None");
                }

                if (em != null && allCharsWhiteSpace(em) == false)
                {
                    Console.WriteLine("E-mail: " + em);
                }
                else
                {
                    Console.WriteLine("E-mail: None");
                }

                if (bd != null && allCharsWhiteSpace(bd) == false)
                {
                    Console.WriteLine("Birthdate: " + bd);
                }
                else
                {
                    Console.WriteLine("Birthdate: None");
                }

                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("What do you want to change (f for first name), (l for last name), (e for e-mail), (and b for birthdate)? "
                                  + "Or, if you want to exit the settings, type in (h): ");
                Console.ForegroundColor = ConsoleColor.White;
                char exitOrMove = Convert.ToChar(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Blue;
                if (exitOrMove == 'f')
                {
                    Console.WriteLine("New first name: ");
                    fn = Console.ReadLine();
                    Console.WriteLine("Press h to save changes and restart program.");
                    var goBack = Console.ReadLine();
                    if (goBack == "h")
                    {
                        restartProgram();
                    }
                }
                else if (exitOrMove == 'l')
                {
                    Console.WriteLine("New last name: ");
                    ln = Console.ReadLine();
                    Console.WriteLine("Press h to save changes and restart program.");
                    var goBack = Console.ReadLine();
                    if (goBack == "h")
                    {
                        restartProgram();
                    }
                }
                else if (exitOrMove == 'e')
                {
                    Console.WriteLine("New e-mail: ");
                    em = Console.ReadLine();
                    Console.WriteLine("Press h to save changes and restart program.");
                    var goBack = Console.ReadLine();
                    if (goBack == "h")
                    {
                        restartProgram();
                    }
                }
                else if (exitOrMove == 'b')
                {
                    Console.WriteLine("Update Birth Date: ");
                    bd = Console.ReadLine();
                    Console.WriteLine("Press h to save changes and restart program.");
                    var goBack = Console.ReadLine();
                    if (goBack == "h")
                    {
                        restartProgram();
                    }
                }
                else
                {
                    restartProgram();
                }
            }
            else if (response1 == 2)
            {
                Console.Clear();
                Console.WriteLine("Enter command (use /help to see the commands, and use h to exit): ");
                var command = Console.ReadLine();

                if (command == "/help")
                {
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("/getfirstname: Gets the first name of your account.");
                    Console.WriteLine("/getlastname: Gets the last name of your account.");
                    Console.WriteLine("/getbirthdate: Gets the birth date of your account.");
                    Console.WriteLine("/getemail: Gets the email of your account.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Press h, and then type in 2 again to do another command.");
                    var goToHome = Console.ReadLine();

                    if (goToHome == "h")
                    {
                        restartProgram();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                else if (command == "/getfirstname")
                {
                    Console.WriteLine("First name: " + fn);
                    Console.WriteLine("Type in h to restart program.");
                    var returnToHome = Console.ReadLine();
                    if (returnToHome == "h")
                    {
                        restartProgram();
                    }
                }
                else if (command == "/getlastname")
                {
                    Console.WriteLine("Last name: " + ln);
                    Console.WriteLine("Type in h to restart program.");
                    var returnToHome = Console.ReadLine();
                    if (returnToHome == "h")
                    {
                        restartProgram();
                    }
                }
                else if (command == "/getbirthdate")
                {
                    Console.WriteLine("Birth date: " + bd);
                    Console.WriteLine("Type in h to restart program.");
                    var returnToHome = Console.ReadLine();
                    if (returnToHome == "h")
                    {
                        restartProgram();
                    }
                }
                else if (command == "/getemail")
                {
                    Console.WriteLine("Email: " + em);
                    Console.WriteLine("Type in h to restart program.");
                    var returnToHome = Console.ReadLine();
                    if (returnToHome == "h")
                    {
                        restartProgram();
                    }
                }
                else if (command == "h")
                {
                    restartProgram();
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }
                
        public static bool allCharsWhiteSpace(string str)
        {
            str.ToCharArray();

            for(var i = 0; i < str.Length; i++)
                if(str[i] == ' ')
                    return true;
            return false;
        }

        static void Main()
        {
            Console.Clear();
            Console.WriteLine("First Name:");
            fn = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            ln = Console.ReadLine();
            Console.WriteLine("Email: ");
            em = Console.ReadLine();
            Console.WriteLine("Birthdate: ");
            bd = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Hello, {fn} {ln}");
            Thread.Sleep(500);
            Console.WriteLine($"What do you want to do?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Type in 1 to visit your settings.");
            Console.WriteLine($"Type in 2 to visit commands.");
            Console.WriteLine($"Type in 3 to exit the program.");
            var response1 = Convert.ToInt32(Console.ReadLine());
            if (response1 == 1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                if (fn != null && allCharsWhiteSpace(fn) == false)
                {
                    Console.WriteLine("First name: " + fn);
                }
                else
                {
                    Console.WriteLine("First name: None");
                }

                if (ln != null && allCharsWhiteSpace(ln) == false)
                {
                    Console.WriteLine("Last name: " + ln);
                }
                else
                {
                    Console.WriteLine("Last name: None");
                }

                if (em != null && allCharsWhiteSpace(em) == false)
                {
                    Console.WriteLine("E-mail: " + em);
                }
                else
                {
                    Console.WriteLine("E-mail: None");
                }

                if (bd != null && allCharsWhiteSpace(bd) == false)
                {
                    Console.WriteLine("Birthdate: " + bd);
                }
                else
                {
                    Console.WriteLine("Birthdate: None");
                }

                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("What do you want to change (f for first name), (l for last name), (e for e-mail), (and b for birthdate)? "
                                  + "Or, if you want to exit the settings, type in (h): ");
                Console.ForegroundColor = ConsoleColor.White;
                char exitOrMove = Convert.ToChar(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Blue;
                if(exitOrMove == 'f')
                {
                    Console.WriteLine("New first name: ");
                    fn = Console.ReadLine();
                    Console.WriteLine("Press h to save changes and restart program.");
                    var goBack = Console.ReadLine();
                    if(goBack == "h")
                    {
                        restartProgram();
                    }
                } else if(exitOrMove == 'l')
                {
                    Console.WriteLine("New last name: ");
                    ln = Console.ReadLine();
                    Console.WriteLine("Press h to save changes and restart program.");
                    var goBack = Console.ReadLine();
                    if (goBack == "h")
                    {
                        restartProgram();
                    }
                } else if(exitOrMove == 'e')
                {
                    Console.WriteLine("New e-mail: ");
                    em = Console.ReadLine();
                    Console.WriteLine("Press h to save changes and restart program.");
                    var goBack = Console.ReadLine();
                    if(goBack == "h")
                    {
                        restartProgram();
                    }
                } else if(exitOrMove == 'b')
                {
                    Console.WriteLine("Update Birth Date: ");
                    bd = Console.ReadLine();
                    Console.WriteLine("Press h to save changes and restart program.");
                    var goBack = Console.ReadLine();
                    if(goBack == "h")
                    {
                        restartProgram();
                    }
                }
                else
                {
                    restartProgram();
                }
            } else if(response1 == 2)
            {
                Console.Clear();
                Console.WriteLine("Enter command (use /help to see the commands, and use h to exit): ");
                var command = Console.ReadLine();

                if(command == "/help")
                {
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("/getfirstname: Gets the first name of your account.");
                    Console.WriteLine("/getlastname: Gets the last name of your account.");
                    Console.WriteLine("/getbirthdate: Gets the birth date of your account.");
                    Console.WriteLine("/getemail: Gets the email of your account.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Press h, and then type in 2 again to do another command.");
                    var goToHome = Console.ReadLine();
                    
                    if(goToHome == "h")
                    {
                        restartProgram();
                    } else
                    {
                        Environment.Exit(0);
                    }
                }
                else if(command == "/getfirstname")
                {
                    Console.WriteLine("First name: " + fn);
                    Console.WriteLine("Type in h to restart program.");
                    var returnToHome = Console.ReadLine();
                    if(returnToHome == "h")
                    {
                        restartProgram();
                    }
                }
                else if(command == "/getlastname")
                {
                    Console.WriteLine("Last name: " + ln);
                    Console.WriteLine("Type in h to restart program.");
                    var returnToHome = Console.ReadLine();
                    if (returnToHome == "h")
                    {
                        restartProgram();
                    }
                }
                else if(command == "/getbirthdate")
                {
                    Console.WriteLine("Birth date: " + bd);
                    Console.WriteLine("Type in h to restart program.");
                    var returnToHome = Console.ReadLine();
                    if (returnToHome == "h")
                    {
                        restartProgram();
                    }
                }
                else if(command == "/getemail")
                {
                    Console.WriteLine("Email: " + em);
                    Console.WriteLine("Type in h to restart program.");
                    var returnToHome = Console.ReadLine();
                    if (returnToHome == "h")
                    {
                        restartProgram();
                    }
                }
                else if(command == "h")
                {
                    restartProgram();
                }
            } else
            {
                Environment.Exit(0);
            }
        } 
    }
}

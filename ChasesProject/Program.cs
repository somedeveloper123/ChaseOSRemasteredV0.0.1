using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChasesProject
{
    static class Program
    {

        static void Main()
        {
            try
            {







                Console.Write("ChaseOS>");
                string cmd = Console.ReadLine();



                if (cmd == "help")
                {
                    Console.WriteLine("cmds: version, calc, readfile, ls, createfile, editfile, deletefile, help, createdirectory, removedirectory, cd, cdfullpath, time, settings, pwd");
                }

                if (cmd == "version")
                {
                    Console.WriteLine("Version: 6.0.0, ChaseOS is an Operating system which is a small project, there is no gui design.");
                    Console.WriteLine("Credits to Reese or chickendad#3076 for being a developer. Owner: Chase or dff#1307");
                }
                if (cmd == "time")
                {
                    Console.WriteLine(DateTime.Now.ToString());

                }
                //Do modifications here
                // if statement syntax: if (a statement) {cool code}
                if (cmd == "settings")
                {
                    // ASK THEM FOR STUPID COLOR
                    Console.WriteLine("What color for text color?");
                    //WAIT FOR ANSWER
                    string color = Console.ReadLine();
                    //new if statement color.ToLower(0) = color lowercase
                    if (color.ToLower() == "blue")
                    {
                        // change color
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    // DO IT FOR ALL THE COLORS OK
                    // yes mam

                    if (color.ToLower() == "red")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if (color.ToLower() == "yellow")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    if (color.ToLower() == "green")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    if (color.ToLower() == "black")
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    if (color.ToLower() == "white")
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                if (cmd == "calc")
                {
                    // Declare variables and then initialize to zero.
                    int num1 = 0; int num2 = 0;

                    // Display title as the C# console calculator app.
                    Console.WriteLine("Console Calculator in C#\r");
                    Console.WriteLine("------------------------\n");

                    // Ask the user to type the first number.
                    Console.WriteLine("Type a number, and then press Enter");


                    // Ask the user to choose an option.
                    Console.WriteLine("Choose an option from the following list:");
                    Console.WriteLine("\ta - Add");
                    Console.WriteLine("\ts - Subtract");
                    Console.WriteLine("\tm - Multiply");
                    Console.WriteLine("\td - Divide");
                    Console.WriteLine("\tsq - Square");
                    Console.Write("Which option do you want to do? ");

                    // Use a switch statement to do the math.
                    switch (Console.ReadLine())
                    {
                        case "a":
                            Console.WriteLine("Enter a number");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            // Ask the user to type the second number.
                            Console.WriteLine("Type another number, and then press Enter");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                            break;
                        case "s":
                            Console.WriteLine("Enter a number");
                            num1 = Convert.ToInt32(Console.ReadLine());

                            // Ask the user to type the second number.
                            Console.WriteLine("Type another number, and then press Enter");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                            break;
                        case "m":
                            Console.WriteLine("Enter a number");
                            num1 = Convert.ToInt32(Console.ReadLine());

                            // Ask the user to type the second number.
                            Console.WriteLine("Type another number, and then press Enter");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                            break;
                        case "d":
                            Console.WriteLine("Enter a number");
                            num1 = Convert.ToInt32(Console.ReadLine());

                            // Ask the user to type the second number.
                            Console.WriteLine("Type another number, and then press Enter");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                            break;
                        case "sq":
                            Console.WriteLine("What number to square?");
                            num1 = Convert.ToInt32(Console.ReadLine());

                            // Ask the user to type the second number.
                            Console.WriteLine($"Your result: " + num1 + " * " + num1 + " = " + (num1 * num1));
                            break;
                    }
                    // Wait for the user to respond before closing.
                    Console.Write("Press any key to close the Calculator console app...");
                    Console.ReadKey();
                }
                

            }
            catch (Exception e)
            {
                Console.WriteLine("oh no your code just got downed");
                Console.WriteLine("how to revive: fix " + e.ToString());
               
            }

        }
    }
}

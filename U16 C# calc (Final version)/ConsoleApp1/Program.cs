using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is what declares input one as a variable
            double inputOne = 0;
            //this is what declares input two as a variable
            double inputTwo = 0;
            //this is what declares opChoice as a variable
            string opChoice = "";
            int opChoice1 = 0;
            //this is the code that displays the title on the interface
            Console.WriteLine("###################################");
            Console.WriteLine("######## C# Calculator ############");
            Console.WriteLine("###################################");

            //this is what creates the loop
            bool calcLoop = true;
            while (calcLoop == true)
            {

                //this is displayed on screen
                Console.WriteLine("\nMenu");
                //this is displayed on screen
                Console.WriteLine("Enter 1 for area of a square");
                //this is displayed on screen
                Console.WriteLine("Enter 2 for area of triangle");
                //this is displayed on screen
                Console.WriteLine("Enter 3 for area of circle");
                //this is displayed on screen
                Console.WriteLine("Enter 4 for Support");
                //this creates a space displayed on screen
                Console.WriteLine("");
                //this is what gives opChoice a value that can be inputted
                opChoice = Console.ReadLine();
                //this is an error checking method
                bool parse = int.TryParse(opChoice, out opChoice1);
                //this is a if statement that is used for error checking
                if (!parse)
                {
                    //this is displayed on screen
                    Console.WriteLine("error!");

                }
                //this is an else statement 
                else
                {
                    //this makes calc loop value false
                    calcLoop = false;
                }

                //this is the if statement for choice 1
                if (opChoice1 == 1)
                {
                    //this is what creates the loop
                    bool error = false;
                    while (error == false)
                    {
                        //this is displayed on screen
                        Console.Write("\nEnter your first number:  ");

                        string inputString = Console.ReadLine();

                        bool parsed1 = double.TryParse(inputString, out inputOne);

                        if (!parsed1)
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            error = true;
                        }


                    }

                    bool error2 = false;
                    while (error2 == false)
                    {


                        Console.Write("\nEnter your second number:  ");
                        string inputString2 = Console.ReadLine();

                        bool parsed2 = double.TryParse(inputString2, out inputTwo);





                        if (!parsed2)
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            error2 = true;

                        }
                    }
                }
                if (opChoice1 == 2)
                {
                    bool error = false;
                    while (error == false)
                    {

                        Console.Write("\nEnter your first number:  ");
                        string inputString = Console.ReadLine();

                        bool parsed1 = double.TryParse(inputString, out inputOne);

                        if (!parsed1)
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            error = true;
                        }


                    }

                    bool error2 = false;
                    while (error2 == false)
                    {


                        Console.Write("\nEnter your second number:  ");
                        string inputString2 = Console.ReadLine();

                        bool parsed2 = double.TryParse(inputString2, out inputTwo);





                        if (!parsed2)
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            error2 = true;

                        }
                    }
                }


                if (opChoice1 == 3)
                {


                    bool error5 = false;
                    while (error5 == false)
                    {

                        Console.Write("\nEnter your radius :  ");
                        string inputString5 = Console.ReadLine();

                        bool parsed4 = double.TryParse(inputString5, out inputTwo);

                        if (!parsed4)
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            error5 = true;

                        }
                    }


                }




                //if the choice is option 4 then the support message is displayed
                if (opChoice1 == 4)
                {
                    //this is displayed on screen
                    Console.WriteLine("Welcome to our support page");
                    //this is displayed on screen
                    Console.WriteLine("Step 1 - Enter the shape you want to calculate with the corresponding Number  ");
                    //this is displayed on screen
                    Console.WriteLine("Step 2a - if you have choesen option 1 or 2, Enter your first number");
                    //this is displayed on screen
                    Console.WriteLine("Step 3 - Then enter your second number");
                    //this is displayed on screen
                    Console.WriteLine("Step 2b - Enter only the radius");
                    //this is displayed on screen
                    Console.WriteLine("Step 4 - your answer should be given to 2 decimals if neccessary and will be displayed in the correct units");

                }



                //this is an else statement
                else
                {
                    //this is displayed on screen
                    Console.Write("\nEnter a number from the list");
                }

                //this creates a switch for choice 1
                switch (opChoice1)
                {
                    //this stores data
                    case 1:
                        //this is displayed on screen
                        Console.WriteLine("You answer is " + inputOne * inputTwo);
                        //this breaks the loop
                        break;
                    //this stores data 
                    case 2:
                        //this is displayed on screen
                        Console.WriteLine("You answer is " + (inputOne * inputTwo) / 2);
                        //this braeks the loop
                        break;

                    //this stores data
                    case 3:
                        //this is displayed on screen
                        Console.WriteLine("You answer is " + 3.14 * inputOne * inputOne);
                        //this breaks the loop
                        break;



                }

                //this is displayed on screen
                Console.Write("\nDo you want to try another sum? Y/N: ");
                string restartChoice = Console.ReadLine().ToUpper();
                //this is an IF statement that restarts the code 
                if (restartChoice == "Y")
                {
                    //this loops the code 
                    calcLoop = true;
                }
                else
                {
                    //this breaks the loop and stops the code
                    calcLoop = false;
                }

            }


        }

    }
}
        
    


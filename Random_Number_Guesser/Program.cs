// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//name space
namespace RandomNumberGuesser
{
    //main class
    class program
    {
        //entry point methods
        static void Main(string[] args)
        {
            //String name = "prabod pubudu";
            //int age = 23;

            //start here//
            //Console.WriteLine("hello world "+ name);
            //Console.WriteLine("{0} is {1}",name,age);


            GetAppinfo();



            Greetuser();


            while (true)
            {
                        
                    

                    //set correct number 
                    //int correctnumber = 7;

                    //create new random number
                    Random random= new Random();
                    int correctnumber = random.Next(1, 10);


                    //init guess number

                    int guess = 0;

                    //ask user for number
                    Console.WriteLine("Guess number between 1 to 10 ");

                    //while guess is not correct 
                    while (guess != correctnumber)
                    {
                        //get user input
                        string input = Console.ReadLine();

                        //make sure input is the nmuber
                        if (!int.TryParse(input,out guess))
                        {
                            //print error massage
                            printMassage(ConsoleColor.Red,"please enter the actual number");

                            //to run programm continuevly

                            continue;
                        }

                        //cast to int and put in guess;

                        guess = int.Parse(input);

                        //match guess to correct number

                        if (guess != correctnumber)
                        {

                            printMassage(ConsoleColor.DarkYellow,"wrong number.., please try again");

                        }
                        else
                        {

                            printMassage(ConsoleColor.Cyan,"your number is correct..!");
                        }

                      

                    }

                //ask to play again;

                Console.WriteLine("want to play again..? [Y or N ]");

                //get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer.Equals("Y"))
                {
                    continue;
                }
                else if (answer.Equals("N")) ;
                {
                    return;
                }

            }





        }

        static void GetAppinfo()
        {
            // set app vars
            String appname = "Number Guesser";
            String appversion = "1.0.0";
            String appAuthor = "pubudu";

            //str color for app name and version well
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            //print app info
            Console.WriteLine($"{appname}: version{appversion} by {appAuthor} ");

            //reset app color
            Console.ResetColor();


        }


        static void Greetuser()
        {
            //ask user name;
            Console.WriteLine("What is your name: ?");

            //get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("hello {0} let's play a game...", inputName);
        }


        //

        static void printMassage(ConsoleColor color,string masssage)
        {
            //str color for app name and version well
            Console.ForegroundColor = color;

            //print app info
            Console.WriteLine(masssage);

            //reset app color
            Console.ResetColor();
        }
    }
}


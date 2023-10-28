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


            // set app vars
            String appname = "Number Guesser";
            String appversion = "1.0.0";
            String appAuthor = "pubudu";

            //str color for app name and version well
            Console.ForegroundColor= ConsoleColor.DarkRed;

            //print app info
            Console.WriteLine($"{appname}: version{appversion} by {appAuthor} ");

            //reset app color
            Console.ResetColor();






        }
    }
}


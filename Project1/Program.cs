/// Homework 6		Project1 1
/// File Name: Program.cs
/// @author: Stephanie Zacharias
/// Date:  October 12, 2020
///
/// Problem Statement: Define a class called Counter whose objects count things.
/// Write a driver program that includes a menu to interactively test each
/// method in the program.
/// 
/// 
/// Overall Plan:
/// 1) Create the Counter class with methods to set the counter to 0,
///    increment/decrement the counter, a toString method, and an equals method.
/// 2) Test out each method.
///

using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create the new counter objects to run the tests on
            Counter count1 = new Counter();
            Counter count2 = new Counter();

            // now to create interactive menu
            String whichCounter = Console.ReadLine();
            String whichMethod = Console.ReadLine();

            Console.WriteLine("Hello! Let's test your Counter class!" +
                "We'll begin with 2 counters, counter1 and counter2." +
                "Which counter do you want to manipulate?" + whichCounter);
            

            if (whichCounter == "counter1" && whichMethod == "set to 0")
            {
                count1.setCounter();
                count1.displayCountToScreen();
                Console.WriteLine("Would you like to try another test?");
                Console.WriteLine("Please enter which counter you would like " +
                    "to manipulate:" + whichCounter);
                Console.WriteLine("Which method: " + "\nset to 0 " +
                "\nincrement\n decrement\ntoString\nequals" + whichMethod);

            } else if (whichCounter == "counter1" && whichMethod == "increment")
            {
                count1.incrementCounter();
                count1.displayCountToScreen();
                Console.WriteLine("Would you like to try another test?");
                Console.WriteLine("Please enter which counter you would like " +
                    "to manipulate:" + whichCounter);
                Console.WriteLine("Which method: " + "\nset to 0 " +
                "\nincrement\n decrement\ntoString\nequals" + whichMethod);
            } else if (whichCounter == "counter1" && whichMethod == "decrement")
            {
                count1.decrementCounter();
                count1.displayCountToScreen();
                Console.WriteLine("Would you like to try another test?");
                Console.WriteLine("Please enter which counter you would like " +
                    "to manipulate:" + whichCounter);
                Console.WriteLine("Which method: " + "\nset to 0 " +
                "\nincrement\n decrement\ntoString\nequals" + whichMethod);
            } else if (whichCounter == "counter1" && whichMethod == "toString")
            {
                Console.WriteLine(count1.toString());
                Console.WriteLine("Would you like to try another test?");
                Console.WriteLine("Please enter which counter you would like " +
                    "to manipulate:" + whichCounter);
                Console.WriteLine("Which method: " + "\nset to 0 " +
                "\nincrement\n decrement\ntoString\nequals" + whichMethod);
            } else if (whichCounter == "counter1" && whichMethod == "Equals")
            {
                Console.WriteLine(count1.Equals(count2));
                Console.WriteLine("Would you like to try another test?");
                Console.WriteLine("Please enter which counter you would like " +
                    "to manipulate:" + whichCounter);
                Console.WriteLine("Which method: " + "\nset to 0 " +
                "\nincrement\n decrement\ntoString\nequals" + whichMethod);
            }

            if (whichCounter == "counter2" && whichMethod == "set to 0")
            {
                count2.setCounter();
                count2.displayCountToScreen();
                Console.WriteLine("Would you like to try another test?");
                Console.WriteLine("Please enter which counter you would like " +
                    "to manipulate:" + whichCounter);
                Console.WriteLine("Which method: " + "\nset to 0 " +
                "\nincrement\n decrement\ntoString\nequals" + whichMethod);

            }
            else if (whichCounter == "counter2" && whichMethod == "increment")
            {
                count2.incrementCounter();
                count2.displayCountToScreen();
                Console.WriteLine("Would you like to try another test?");
                Console.WriteLine("Please enter which counter you would like " +
                    "to manipulate:" + whichCounter);
                Console.WriteLine("Which method: " + "\nset to 0 " +
                "\nincrement\n decrement\ntoString\nequals" + whichMethod);
            }
            else if (whichCounter == "counter2" && whichMethod == "decrement")
            {
                count2.decrementCounter();
                count2.displayCountToScreen();
                Console.WriteLine("Would you like to try another test?");
                Console.WriteLine("Please enter which counter you would like " +
                    "to manipulate:" + whichCounter);
                Console.WriteLine("Which method: " + "\nset to 0 " +
                "\nincrement\n decrement\ntoString\nequals" + whichMethod);
            }
            else if (whichCounter == "counter2" && whichMethod == "toString")
            {
                Console.WriteLine(count2.toString());
                Console.WriteLine("Would you like to try another test?");
                Console.WriteLine("Please enter which counter you would like " +
                    "to manipulate:" + whichCounter);
                Console.WriteLine("Which method: " + "\nset to 0 " +
                "\nincrement\n decrement\ntoString\nequals" + whichMethod);
            }
            else if (whichCounter == "counter2" && whichMethod == "Equals")
            {
                Console.WriteLine(count2.Equals(count1));
                Console.WriteLine("Would you like to try another test?");
                Console.WriteLine("Please enter which counter you would like " +
                    "to manipulate:" + whichCounter);
                Console.WriteLine("Which method: " + "\nset to 0 " +
                "\nincrement\n decrement\ntoString\nequals" + whichMethod);
            }


        }
    }
}

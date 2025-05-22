using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("do you have a breakfast today?");// prints the  output in new line
            Console.Beep();// makes the beep sound at once
            Console.Write("yes, at 10am ");//does not print the output in new line

            //escape sequence
            Console.WriteLine("\tArib chishty");
            Console.WriteLine("Arib\b chishty");
            Console.WriteLine("\nArib chishty");



            //data types in C# 
            Console.WriteLine("\nData types in C#: ");

            int x; //declaration
            x = 43;//initialization
            int y = 22; //declaration + initialization
            double z = 5.767;
            float amer = 3.55634555f;

            int age = 20;//stores only whole numbers
            double height = 5.8; //stores the decimal point numbers
            bool alive = false; // give's only true or false 
            char sign = '$'; // stores only one character
            string name = "SideEffect"; // store's the name(number of char)
            string username = sign + name; //some useful stuff

            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your Height is " + height + "ft");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine(sign + " -this is the dollar sign ");
            Console.WriteLine("your name is " + name);
            Console.WriteLine("Your username is " + username);


            //Constants - constants are immutable values which are
            //know at compile time and do do not change for the life of the program
            Console.WriteLine("\nConstants in C#: ");

            const string password = "Ninefive";
            const double pi = 3.14159;
            //pi= 244; // we cannot change the const value later
            Console.WriteLine("your password is- " + password + pi);



            // Typecasting - Converting a value to a different data type
            //               Useful when we accept user input(string)
            //               Different data types can do different things
            Console.WriteLine("\nTypeCasting in C#: ");

            double a = 85.43232;
            int b = Convert.ToInt32(a);

            Console.WriteLine("this is converted from double to int " + b);
            Console.WriteLine("to get data type " + a.GetType());
            Console.WriteLine(b.GetType());

            int c = 99;
            double d = Convert.ToDouble(c) + 0.96;

            Console.WriteLine("THIS IS THE PERCENTAGE KILLED BY DETOL " + d);
            Console.WriteLine(d.GetType());

            string e = "@";
            char f = Convert.ToChar(e);

            Console.WriteLine(f);
            Console.WriteLine(" the data type " + f.GetType());

            string g = "false";
            bool h = Convert.ToBoolean(g);

            Console.WriteLine(h);
            Console.WriteLine(" the data type " + h);



            ////User Input in C#
            //Console.WriteLine("\nInput's from User: ");

            //Console.WriteLine("what's your name?");
            //string name1 = Console.ReadLine();


            //Console.WriteLine("What's your age? ");
            //int age1 = Convert.ToInt32(Console.ReadLine()); //as we can only use string datatype to take user input, but also by converting the string to int

            //Console.WriteLine("hello " + name1);
            //Console.WriteLine("You are " + age1 + " year's old");



            //Arithmetics in C# (Basic operations) 
            //Try to do calculations line by line 
            Console.WriteLine("\nThere we Go with the arithmetics in C#: ");

            int aadmi = 5;
            //double aadmi = 5;

            aadmi = aadmi + 1;
            Console.WriteLine("5+1 = " + aadmi); // prints 5+1=6
            //aadmi += 1;  //this is the shortcut of the above line
            //aadmi++;  // this line is mainly used in loops as it only increment the value by 1

            aadmi = aadmi - 1;  //Subtraction
            Console.WriteLine("6-1 = " + aadmi); // Prints 6-1=5 because in above line of code we have done addition to our variable
                                                 //aadmi += 1;
                                                 //aadmi--; // mainly used in loops to decrement the value by 1

            aadmi = aadmi / 2; //This will print 2 because the data type is int,But if we convert it to double then it will print 2.5
            Console.WriteLine("this is in integer format 5/2 = " + aadmi);
            //aadmi /= 2;

            aadmi = aadmi * 2; //multiplication
            Console.WriteLine("2x2 = " + aadmi); // This will print 4 because in above statement we have divided 4 and now we are again multiplying the divided 4 that is 2 to 2 
            //aadmi *= 2;

            int aadmi1 = 10;
            int remainder = aadmi1 % 3; // this is use to get the remainder
            Console.WriteLine("(Here we have declared another variable)This is the remainder when 10/3 " + remainder);


            //Math class
            Console.WriteLine("\nMath Class");

            double x1 = 3;

            double a2 = Math.Pow(x1, 2); // find the power of the variable/integer which display as (base , power needed)
            double b2 = Math.Sqrt(a2);// Finds the square root of the following integer/variable passed within parentheses

            double y1 = -3;
            double c2 = Math.Abs(y1); //finds the absolute value
           
            double round = 3.14;
            double d2 = Math.Round(round); // use to round off numbers 
            double e2 = Math.Ceiling(round); // Used to round off the number to upper value
            
            double floor = 3.99;
            double f2 = Math.Floor(floor); // used to round off to the lower number
            
            double m1 = 8.14;
            double m2 = 7;
            double maximum = Math.Max(m1, m2);  // Finds the maximum value between two

            double minimum = Math.Min(m1, m2); // Finds the minimum value between two no's

            Console.WriteLine("2 power of 3 is : "+a2);
            Console.WriteLine("the square root of " + a2 + " is: " + b2);
            Console.WriteLine("the absolute value " + c2); 
            Console.WriteLine("The round off is : "+d2);
            Console.WriteLine("The round off to the upper integer is: " + e2);
            Console.WriteLine("The roundoff to the lower number: " + f2);
            Console.WriteLine("The Maximum value between two no's is: " +maximum);
            Console.WriteLine("The Minimum value between 2 no's is: "+minimum);
            Console.WriteLine("now you will vitness the most powerful and underground method that haven't talked openly yet");

          
            //Some random numbers(pseudo-random numbers)
            Console.WriteLine("\n Let's generate some random numbers in  C#");

            Random random_name = new Random(); //To generate some random numbers

            int random_num = random_name.Next(1, 7); //within the parentheses first willl be the minimum number and second will be the maximum-1 number
            int random_num_pluse = random_num + 100;
          
            double double_num = random_name.NextDouble();// This will generate some random number between  0 to 1 in decimal format

            Console.WriteLine("The random number between 1 to 6 is:" +random_num);
            Console.WriteLine("The random number after addition is:" +random_num_pluse);
            Console.WriteLine("double random number is: "+double_num);


            ////Find the hypotenuse of the right angle triangle
            //Console.WriteLine("\nLet's find the hypotenuse of right angle trianlge");

            //Console.WriteLine("Enter the side A: ");
            //double side_a = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the side B:");
            //double side_b = Convert.ToDouble(Console.ReadLine());

            //double side_c = Math.Sqrt((side_a * side_a) +  (side_b * side_b));

            //Console.WriteLine("The Hypotenuse of right angle triangle is: " +side_c);


            //Some Useful string methods in C#
            Console.WriteLine("\nSome useful String methods in C#");

            string FullName1 = "Code Learner";
            FullName1 = FullName1.ToUpper();// it will print all the input in uppper case

            string FullName = "Code Learner";
            FullName = FullName.ToLower(); //it will print all input to the lower case

            string Date = "01 - 01 - 1990";
            Date = Date.Replace("-", "/"); // it will replace the first one with the second on from the input

            string PhoneNumber = "123-456-7890";
            PhoneNumber = PhoneNumber.Replace("-", "");

            string UserName = "arib_Chishty";
            UserName = UserName.Insert(0, "Mr.");// Insert's the given subject to the data provided (0- is the index provided of at which position you need


            Console.WriteLine(" your name in upper case is: "+FullName1);
            Console.WriteLine(" your name in lower case is: " + FullName);
            Console.WriteLine("this is the replace method "+Date+ " and " +PhoneNumber);
            Console.WriteLine("this insert method: " +UserName);

            Console.WriteLine("This showcase the lenght of your fullname: " +FullName.Length);//This also count one space as one character length 
            
            string FirstName = FullName.Substring(0,4); // 0  represents the starting index from where we want to start printing the numbers and
                                                        // 4 represents the ending index, till which index we want to print
            string LastName =  FullName.Substring(5,7); // 5  represents the starting index from where we want to start printing the numbers and
                                                        // 7 represents the ending index, till which index we want to print
            // It is that till 5th index we want to skip and then from 5 we need 1,2,3,4,5,6,7 to be printed means it is 7 index ahead from 5.
             

            Console.WriteLine("This is the substring method: " +FirstName);
            Console.WriteLine(LastName);

          
            Console.ReadKey();
        }
    }
}
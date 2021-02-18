using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] myArray = new string[] { "lundi", "mardi", "mercredi","jedi","vendredi","samedi" };



            Console.WriteLine(myArray[1] +"\n"+ myArray[4]);
            Console.WriteLine(myArray[0] + "\n" + myArray[3]);

            myArray [3] ="jeudi";

            Console.WriteLine(myArray[3]);
            

            Array.Resize<string>(ref myArray, 7); 
            myArray[6] = "Dimanche";
            Console.WriteLine(myArray[6]);

            for (int i = 0; i < myArray.Length; i++) 
            Console.WriteLine(myArray[i]);


        }
    }
    }


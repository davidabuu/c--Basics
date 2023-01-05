using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //         sbyte mySbyte  = 127; //Accepts negative value
            //         byte myByte = 255; //Do not accept negative value
            //         short myShort  = -327;
            //         ushort myUshort = 6553;
            //         int myInt = 2147483647;
            //         long longNumber = 5;
            //         Console.WriteLine(longNumber);
            //         float myFloat = 0.34f;
            //         double myDouble = 0.766d;
            //         decimal myDecimal = 0.777m;
            //         string myString = "new string";
            //          string[] myGroceryArray = new string[2];
            //         myGroceryArray[0] ="David";
            //         string[ ] myArray = {"1", "2", "Apples"};

            //         //List
            //         List<string> myList = new List<string>() {"Milk", "Cheese"}
            //         ;
            //         myList.Add("Hello world");

            //         // I enumerable
            //         IEnumerable<string> myLoop = myList;
            //         Console.WriteLine(myLoop.First());
            //         string[,] myTwoDimensionalArray =  {{"1", "2", "Apples"}, {"1", "2", "Apples"}};
            //         Console.WriteLine(myTwoDimensionalArray[0,0]);
            //         //Dictionary
            //         Dictionary<string, string> myDic = new Dictionary<string, string>() {
            //             {"Age", "Value"}
            //         };   
            //         Console.WriteLine(myDic["Age"]);  

            int myInt = 5;
            int mySecondInt = 10;
            myInt++;
            Console.WriteLine(myInt);
            myInt += 7;
            Console.WriteLine(myInt);
            Console.WriteLine(myInt * mySecondInt);
            Console.WriteLine(Math.Pow(5, 6));
            string myString = "test";
            Console.WriteLine(myString);
            string[] myStr = myString.Split(' ');
            Console.WriteLine(myInt.Equals(mySecondInt));
            if (myInt > mySecondInt)
            {
                myInt += 10;
            }
            Console.WriteLine(myInt);
            string myCow = "cow";
            string myCapitalizeCow = "COW";
            if (myCow == myCapitalizeCow)
            {
                Console.WriteLine("Equal");
            }
            switch (myCow)
            {
                case "cow":
                Console.WriteLine("LowerCase");
                    break;
                default:
                Console.WriteLine("Hola");
                break;
            }
        }
    }
}
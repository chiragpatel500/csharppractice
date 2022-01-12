using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$ //Project Name
{
    class Program // Class container
    {
        /*static void Main(string[] args) // put the code here which needs to be executed.// method
        {


            Chef myChef = new Chef();
            myChef.MakeChicken();

            ItalianChef myItalianChef = new ItalianChef();
            myItalianChef.MakeChicken();

            Console.ReadLine(); // To keep the console window open.

        }*/

    }
}




//--P1:Writeline and readline... basic starting point.--
// method//static void Main(string[] args)//{ // put the code here which needs to be executed.

//Console.WriteLine("hello there");// write the output here. 
//Console.WriteLine(" /|");
//Console.WriteLine("  /|");
//Console.WriteLine("  /|");
//Console.WriteLine(" /|");
//Console.WriteLine("/_|");

//Console.ReadLine(); // To keep the console window open.
//} //Method ends

//--P2:variables--
// method//static void Main(string[] args){ // put the code here which needs to be executed.

//string characterName = "chirag"; //created string variavble to be used
//int characterAge = 25; //created integer varaible to changed

//Console.WriteLine("There once a man named " + characterName);
//Console.WriteLine("he was " + characterAge + " yrs old");

//characterName = "jeff"; // update the value of the variable.

//Console.WriteLine("he really like the name " + characterName);
//Console.WriteLine("but didn't like being " + characterAge + "");


//Console.ReadLine(); // To keep the console window open.
//} //Method ends

//--P3:DATA types--

// method//static void Main(string[] args){ // put the code here which needs to be executed.
//string phrase = "patel academy"; // STRING
//char grade = "A"; // characters
//int age = 30; // integer 
//float, double, decimal // types of numbers.
//bool isMale = true; //Boolean: true or false.


//Console.ReadLine(); // To keep the console window open.
//} //Method ends

//--P4:strings--

// method//static void Main(string[] args){ // put the code here which needs to be executed.
//string phrase = "patel academy";
//string phrase = "patel academy" + "is cool"; //contcatnation
//Console.WriteLine(phrase);
//Console.WriteLine(phrase.Length); // to count the length
//Console.WriteLine(phrase.ToUpper());// convert string to upper case
//Console.WriteLine(phrase.ToLower());// convert string to lower case
//Console.WriteLine(phrase.Contains("academy"));// check if this word exist //true or false.
//Console.WriteLine(phrase[1]); //print the character as per index. 
//Console.WriteLine(phrase.IndexOf("academy")); //check the index position.
//Console.Writeline(phrase.Substring(8));//print the characters from this index position.
//Console.ReadLine(); // To keep the console window open.

//} //Method ends


//--P5:numbers--

// method//static void Main(string[] args){ // put the code here which needs to be executed.
//int num = 0; // store number in varaible.
//Console.WriteLine(num + 1);
//Console.WriteLine(5 + 8);
//Console.WriteLine(10 - 8);
//Console.WriteLine(20 * 8);
//Console.WriteLine(64 / 8);
//Console.WriteLine(40 % 4); //modules opertor gives remainder
//Console.WriteLine((4 + 2) * 4);
//Console.WriteLine(5 + 8.1);
//Console.WriteLine(Math.Abs(-40));
//Console.WriteLine(Math.Pow(3,2));//power
//Console.WriteLine(Math.Sqrt(35));//suqre root
//Console.WriteLine(Math.Max(40,90));//get the biggest number

//} //Method ends

//--P6:Getting user input--

// method//static void Main(string[] args){ // put the code here which needs to be executed.


//Console.Write("Enter your name:"); // Prompt// asks you for the value //console.Write to take input.//
//string name = Console.ReadLine(); // Read the input and assign it to string. 
//Console.WriteLine("Hello" + name); // print the string and the inputted value.

//Console.Write("Enter your Age:");
//string age = Console.ReadLine();
//Console.WriteLine("Hello" + name + " you are " + age);




//Console.ReadLine(); // To keep the console window open.
//} //Method ends

//--P7:Calculator--


// method//static void Main(string[] args){ // put the code here which needs to be executed.

//Console.Write("enter a number:"); //prompt // ask for number // console.write
//double num1 = Convert.ToDouble(Console.ReadLine()); // read number and convert it to Double(decimal) and assign to a double(string)
//Console.Write("enter another number:");//prompt // ask for number
//double num2 = Convert.ToDouble(Console.ReadLine());/ read number and convert it to Double(decimal) and assign to a double(string)

//Console.WriteLine(num1 + num2);// print num1 + num2;


//int num = Convert.ToInt32("45"); // convert string into intger
//Console.WriteLine(num + 5);


//Console.ReadLine(); // To keep the console window open.

//} //Method ends
//--P7:Madlibgame--

// method//static void Main(string[] args){ // put the code here which needs to be executed.

//Console.Write("Enter color: ");//Prompt : ask for color
//string color = Console.ReadLine(); //read value and assign it to string.



//Console.Write("Enter plural noun: ");
//string pluralNoun = Console.ReadLine();


//Console.Write("Enter celebrity: ");
//string celebrity = Console.ReadLine();


//Console.WriteLine("Roses are " + color); //print text with input values. 
//Console.WriteLine(pluralNoun + " are blue");
//Console.WriteLine("I love " + celebrity);

//Console.ReadLine(); // To keep the console window open.
//} //Method ends


//--P8:ARRAYS--

//method // static void Main(string[] args){ // put the code here which needs to be executed.
//int[] luckyNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }; //Create and array of int and gives values.
//luckyNumbers[1] = 25;// change the value of mentioned index position

//Console.WriteLine(luckyNumbers[1]); // print the value of mentioned index position.


//string[] friends = new string[4]; // create an arrauy of strings and assign total indexs.
//friends[0] = "jim"; // assign value to mentioned index number.
//friends[1] = "kelly";


//Console.ReadLine(); // To keep the console window open.

//} //Method ends


//--P9:Methods--

//1st main method
//static void Main(string[] args) // put the code here which needs to be executed.// Main-method(function)
//{

//    sayHi("chirag", 25); call the another method as pass values to display.
//    sayHi("jeff", 20);

//    Console.ReadLine(); // To keep the console window open.
//}

//2nd method to be called from 1st.

//static void sayHi(string name, int age) // another method(function)
//{
//    Console.WriteLine("hello " + name + "you are " + age);
//}

//--P10:return statment--
//static void Main(string[] args) // put the code here which needs to be executed.// method
//{

//int cubedNumber = cube(5); //acces the result value of 2nd method by sending a parameter & assign to new variable. 
//Console.WriteLine(cubedNumber); // printout out the new vraible.

// Console.ReadLine(); // To keep the console window open.
//}

//static int cube(int num)
//{
//  int result = num * num * num;
// return result; // return means end of the statment.
//}

//--P11--if-statements--
//static void Main(string[] args) // put the code here which needs to be executed.// method
//{
//bool isStudent = false;
//bool isSmart = false;

//if (isStudent && isSmart) //  || = OR operator // ! = Negation opertor.
//{
//  Console.WriteLine("You are a student");
//}
//else if (isStudent && !isSmart)
//{
// Console.WriteLine("You are not a smart student");
//}
//else
//{
//  Console.WriteLine("You are not a student and not smart");
//}

// >, <, >=, <=, !=, ==
//if (1 < 3)
//{
//  Console.WriteLine("number comparison was true");
// }

//Console.ReadLine(); // To keep the console window open.
//}

//--P12:if-statemenst comparisons--
//static void Main(string[] args) // put the code here which needs to be executed.// method
//{
//   Console.WriteLine(GetMax(20, 10, 2500)); //call the second method giving values.
//    Console.ReadLine();
//}

//static int GetMax(int num1, int num2, int num3)
//{
//  int result;
// if (num1 > num2)
//{
//  result = num1;
//}
//else if (num1 < num2)
// {
//   return result = num2;
//}
//else
//{
//  return result = num3;
//}


//return result;
//}

//--P13:4 function calculator--  +,-,*,/  
//static void Main(string[] args) // put the code here which needs to be executed.// method
//{

//  Console.Write("Enter num1: ");
//double num1 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter operator: ");
//string op = Console.ReadLine();

//Console.Write("Enter num2: ");
//double num2 = Convert.ToDouble(Console.ReadLine());

// if (op == "+")
//{
//  Console.WriteLine(num1 + num2);
//}
//else if (op == "-")
//{
//  Console.WriteLine(num1 - num2);
//}
//else if (op == "/")
//{
//  Console.WriteLine(num1 / num2);
//}
//else if (op == "*")
//{
//  Console.WriteLine(num1 * num2);
//}
//else
//{
//  Console.WriteLine("Invalid Operator");
//}


//Console.ReadLine();
//}

//--p14:Switch statments// it is an alternative to if-statments//
//
//
//static void Main(string[] args) // put the code here which needs to be executed.// method
//{
//    Console.WriteLine(GetDay(2)); // call the second method passing a paramter. 

//    Console.ReadLine(); // To keep the console window open.
//}

//switch statements

//static string GetDay(int dayNum)
//{
//    string dayName; // create a string 

//   switch (dayNum) // create switch stamemnts
//   {
//       case 0: 
//           dayName = "Sunday"; //assign diffrenent values  to string in the method;
//           break;
//       case 1:
//           dayName = "Monday";
//           break;

//     case 2:
//          dayName = "Tuesday";
//           break;
//       case 3:
//           dayName = "Wednesday";
//           break;

//        case 4:
//            dayName = "Thursday";
//            break;
//        case 5:
//            dayName = "Friday";
//            break;
//       case 6:
//            dayName = "Saturday";
//            break;
//        default:
//           dayName = "Invalid day number";
//            break;
//    }

//    return dayName;
//}

//--p15:while loop--
//static void Main(string[] args) // put the code here which needs to be executed.// method
//{

//while loop
//    int index = 1; // define a data type and give value.

//    while (index <= 25) // inside while loop define the condition to be met.
//    {
//        Console.WriteLine(index);// print the value of the data type.
//        index++; // keep adding until certain condition is met.
//    }

//    Console.ReadLine(); // To keep the console window open.
//}

//--P16:Build a guessing game--
// static void Main(string[] args) // put the code here which needs to be executed.// method
//{

//string secretWord = "patel";
//string guess = "";
//int guessCount = 0;
//int guessLimit = 3;
// bool outOfGuesses = false;

// while (guess != secretWord && !outOfGuesses)
// {
//   if (guessCount < guessLimit)
//   {
//       Console.Write("Enter guess:  "); //Prompt 
//       guess = Console.ReadLine();
//       guessCount++;

//     }
///   else
//   {
//       outOfGuesses = true;
//    }
// }

//if (outOfGuesses)
// {
//     Console.Write(" you lose");
// }
// else { Console.Write("you win"); }

// Console.ReadLine(); // To keep the console window open.
//}

//--P17:For loops--

// static void Main(string[] args) // put the code here which needs to be executed.// method
//{  
//Simple For Loop Example
//for (int i = 1; i <= 25; i++) // Define For loop provding data type and value, condition to be met, value to be added or subtracted.
//{
//  Console.WriteLine(i);// call the data types to used in the loop;
//}        
//For Loop  to loop through an array
// int[] luckyNumbers = { 1, 235, 66, 33, 99 }; //Define and array and pass values.
//for (int i = 0; i < luckyNumbers.Length; i++) // Define loop and pass array to be used and condition to be met.
// {
//     Console.WriteLine(luckyNumbers[i]); // print the output using of arrays index number.

//  }
//  Console.ReadLine(); // To keep the console window open.
// }

//--p17:Exponent Method--
//static void Main(string[] args) // put the code here which needs to be executed.// method
//{
//  Console.WriteLine(GetPow(4, 3)); // call the second method by passing paramerts to get certian value.

//      Console.ReadLine(); // To keep the console window open.

//}

//static int GetPow(int baseNuM, int powNum) //Define 2nd method & data type and give parametes.
//{
// int result = 1; Define a data type and provide value
//for (int i = 0; i < powNum; i++) // write the for loop an define the condition and output.
//{
// result = result * baseNuM; //take the data type and use it to metcertian condition.
// }
//return result; // return the final result by endig the class.
//}

//--p18:2d arrays--
//static void Main(string[] args) // put the code here which needs to be executed.// method
//{
// int[,] numberGrid =  { // create an 2d array define  imp: all the values must be 2d which means all passed values must an array itself.
//  {1, 2},
//  {3, 4},
//  {5, 6}
//};

//Console.WriteLine(numberGrid[1, 1]); // access the array row index and value index. e.g this will output 4.

//Console.ReadLine(); // To keep the console window open.
//}

//--p19:Exception handling--
/* static void Main(string[] args) // put the code here which needs to be executed.// method
        {
            try // Try this block of code and if all runs smooth than its okay else display erroe in the ctach block. 
            {
                Console.Write("Enter a number:  "); //prompt
                int num1 = Convert.ToInt32(Console.ReadLine()); // define data type and convert it to a number read it out.
                Console.Write("Enter another Number: ");//prompt
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            //Try to catch error invidividalyy .//google excpetion erros to find more.
            catch (DivideByZeroException e)//For e.g this error catches divison by zero and assign a character "e"  to it which will used to fetch the message.
            {
                Console.WriteLine(e.Message);// outputting messgaes from the console.

            }

            catch (FormatException e)//For e.g this error catches Format Eror and assign a character "e"  to it which will used to fetch the message.
            {
                Console.WriteLine(e.Message);// outputting messgaes from the console.
            }
          


            Console.ReadLine(); // To keep the console window open.

        }*/

//--P20:classes and objects.
//see BOOK.cs for the class as Blue Print.
//Objects are created on the basis of classes.
//e.g here we are creating and 2 book objects using the class book from Book.cs and giving values to it.

/*static void Main(string[] args) // put the code here which needs to be executed.// method
{

    Book book1 = new Book(); //Create a object called book1 using Book class from Book.cs as blueprint and give values. 
    book1.title = "Harry potter";
    book1.author = "jk rowling";
    book1.pages = 400;


    Book book2 = new Book();//Create a object called book2 using Book class from Book.cs as blueprint and give values. 
    book2.title = "rings";
    book2.author = "tokien";
    book2.pages = 700;

    Console.WriteLine(book2.title);//Print the given values.
    Console.WriteLine(book2.author);
    Console.WriteLine(book2.pages);

    Console.ReadLine(); // To keep the console window open.

}*/

//--p21:Constructor--
//Book.cs class to created from new in the sol explorer.

//--Book.cs-- 
/*class Book
{
    //Define data types public are accdeisble though all app and private are not.
    public string title;
    public string author;
    public int pages;

    public Book(string aTitle, string aAuthor, int aPages) //create a  constructor
    {
        title = aTitle; //assign  value to datatypes  as parameters.
        author = aAuthor;
        pages = aPages;
    }
}*/

//--program.cs--
/*class Program // Class container
   {
       static void Main(string[] args) // put the code here which needs to be executed.// method
       {

           Book book1 = new Book("Harry potter", "jk rowling", 400); // create a new object by passing all data as parameters.

           Book book2 = new Book("rings", "tokien", 700);
           book2.title = "the hobbit"; // chnage a particular value


           Console.WriteLine(book2.title); //print out a particular value.
           Console.WriteLine(book2.author);
           Console.WriteLine(book2.pages);

           Console.ReadLine(); // To keep the console window open.

       }

   }*/

//--P22:objects methods--
//--create new student.cs(class) from solution explorer.
/* public class Student
    {
        public string name;
        public string major;
        public double gpa;


        public Student(string aName, string aMajor, double aGpa) // assign  datatype to objectt parametsr.
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public bool HasHonors() //Create  a method(function) to check a particular condition.
        {
            if(gpa >= 2.5)
            {
                return true;
            } 

            return false;
        }*/
//--Program.cs--
/*public class Program // Class container
 {
     static void Main(string[] args) // put the code here which needs to be executed.// method
     {

         Student student1 = new Student("jim", "business", 2.8);
         Student student2 = new Student("jim", "Art", 3.6);

         Console.WriteLine(student1.HasHonors());
         Console.WriteLine(student2.HasHonors());


         Console.ReadLine(); // To keep the console window open.

     }

 }*/
//--P23:Get and set--
// Kindly refer--mike dane giraffe academy c# get and set video. 

//--p24:Static class attributes.
//--Program.cs--
/* static void Main(string[] args) // put the code here which needs to be executed.// method
      {

          Song holiday = new Song("Holiday", "Green Day", 200); //Create constructor and  give values as paarmetrs.

          Song kashmir = new Song("Kashmir", "Led zeppelin", 150);

          Console.WriteLine(kashmir.getSongCount());
          Console.WriteLine(Song.songCount);
          Console.ReadLine(); // To keep the console window open.

      }*/

//--Song.cs--

/*public class Song
{
    public string title; //define dataypes
    public string artist;
    public int duration;
    public static int songCount = 0; //you can create a static dataype and give value which will be accasible everythweere in the app.



    public Song(string aTitle, string aArtist, int aDuration) //create constructor and asign datatypes to parameters.
    {
        title = aTitle;
        artist = aArtist;
        duration = aDuration;
        songCount++;
    }

    public int getSongCount() //create song count method to get song count..
    {
        return songCount;
    }
}*/

//--p25:static methods in classes.--
//--Program.cs--
/*class Program // Class container
 {
     static void Main(string[] args) // put the code here which needs to be executed.// method
     {

         UsefoolTools.SayHi("chirag");// acsses another class with it's method and run with a value to get expected output.
         Console.ReadLine(); // To keep the console window open.

     }

 }*/
//--usefooltools.cs--
/* public class UsefoolTools // create a class
    {

     public static void SayHi(string name) // create a static - method.//accessible to all the apps.
        {
            Console.WriteLine("Hello" + name);// expected output.
        }
    }*/

//--p26:Inheritance--


/* public class Chef
{

    public void MakeChicken()
    {
        Console.WriteLine("The chef makes chicken");
    }

    public void MakeSalad()
    {
        Console.WriteLine("The chef makes salad");
    }

    public virtual void MakeSpecialDish()
    {
        Console.WriteLine("The chef makes a special dish");
    }
}

public class ItalianChef : Chef
{
    public void MakePasta()
    {
        Console.WriteLine("The Chef make's past");
    }

    public override void MakeSpecialDish()
    {
        Console.WriteLine("The chef makes chicken parm");
    }
}

public class App
{
    public static void Main(string[] args)
    {

        Chef myChef = new Chef();
        myChef.MakeChicken();

        ItalianChef myItalianChef = new ItalianChef();
        myItalianChef.MakeChicken();
    }
}
*/

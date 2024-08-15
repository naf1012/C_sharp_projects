using System;
using System.ComponentModel;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uncomment the method calls below to see their output

            // printTriangle();          // Simple output of a triangle
            // storyWithStringsAndInt(); // Story using strings and integers
            // dataTypes();              // Demonstrates various data types
            // workingWithStrings();     // Methods to work with strings
            // workingWithNumbers();     // Methods to work with numbers
            // gettingUserInput();       // Get user input and display it
            // basicCalc();              // Basic calculator functionality
            // madLibs();                // Mad Libs game
            // workingWithArrays();      // Working with arrays
            // sayHi("Mike", 22);        // Example method with parameters
            // sayHi("Tom", 55);
            // sayHi("Timmy", 12);

            // Demonstrate the cube function
            //int cubedNum = cube(5);
            //Console.WriteLine(cubedNum); // Output: 125
            //Console.WriteLine(cube(5));  // Output: 125

            //ifStatement();
            //continued
            //Console.WriteLine(getMax(101,102,100)); //Output: 102

            //betterCalc();

            //switch                            0    1   2   3   4   5   6
            // Console.WriteLine(getDay(5));//Monday,Tue,Wed,Thu,Fri,Sat, Sun

            //whileLoop();
            //continued
            //guessingGame();

            //for loop
            //forLoop();

            //Own Math.pow function
            //Console.WriteLine(getPow(3,2));
            //Console.WriteLine(getPow(5, 3));

            //twoDimensionalArray();

            //exceptionHandling();

            //classesAndObjects();

            //constructors();

            //objectMethods();

            //gettersAndSetters();

            //staticClassAttribute();

            //staticMethod();

            //inheritance();

            //arrays();

            //lists();

            //stacks();

            //queues();

            //linkedLists();
            
        }

        // Method to print a simple triangle
        static void printTriangle()
        {
            Console.WriteLine("     /|");
            Console.WriteLine("    / |");
            Console.WriteLine("   /  |");
            Console.WriteLine("  /   |");
            Console.WriteLine(" /    |");
            Console.WriteLine("/_____|");
            Console.WriteLine();
        }

        // Method to tell a story using strings and integers
        static void storyWithStringsAndInt()
        {
            string storyName = "John";
            int storyAge = 35;
            Console.WriteLine("There once was a man named " + storyName);
            Console.WriteLine("He was " + storyAge + " years old");
            Console.WriteLine("He really liked the name " + storyName);
            Console.WriteLine("But didn't like being " + storyAge);
            Console.WriteLine();
        }

        // Method to demonstrate various data types
        static void dataTypes()
        {
            string phrase = "Hello World";
            char grade = 'A';
            int age = 22;
            float myFloat = 2424.214F;
            double gpa = 3.2D;
            decimal myMoney = 1213.12141221312412312M;
            bool isMale = true;

            Console.WriteLine(phrase);
            Console.WriteLine(grade);
            Console.WriteLine(age);
            Console.WriteLine(myFloat);
            Console.WriteLine(gpa);
            Console.WriteLine(myMoney);
            Console.WriteLine(isMale);
            Console.WriteLine();
        }

        // Method to demonstrate various string operations
        static void workingWithStrings()
        {
            string phrase = "Hi World" + "!!";
            string phrase2 = "Hi";
            Console.WriteLine("Hi\nWorld");
            Console.WriteLine("Hi\"World");
            Console.WriteLine(phrase);
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase2.Length);
            Console.WriteLine(phrase2.ToUpper());
            Console.WriteLine(phrase2.ToLower());
            Console.WriteLine(phrase2.Contains("Hi"));
            Console.WriteLine(phrase2.Contains("hi"));
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase[1]);
            Console.WriteLine(phrase.IndexOf("World"));
            Console.WriteLine(phrase.IndexOf('W'));
            Console.WriteLine(phrase.Substring(3));
            Console.WriteLine(phrase.Substring(3, 5));
            Console.WriteLine();
        }

        // Method to demonstrate various number operations
        static void workingWithNumbers()
        {
            Console.WriteLine(-5.783);
            Console.WriteLine(50);
            Console.WriteLine(5 + 8);
            Console.WriteLine(8 - 3);
            Console.WriteLine(5 * 8);
            Console.WriteLine(8 / 8);
            Console.WriteLine(8 % 2);

            Console.WriteLine(4 + 2 * 3);    // 10
            Console.WriteLine((4 + 2) * 3);  // 18

            Console.WriteLine(5.0 + 8.1);
            Console.WriteLine(5 + 8.1);

            Console.WriteLine(5 / 2);       // 2
            Console.WriteLine(5 / 2.0);     // 2.5

            int num = 6;
            num++;
            int num2 = 6;
            num2--;

            Console.WriteLine(num);         // 7
            Console.WriteLine(num2);        // 5

            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3, 2));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(4, 90));
            Console.WriteLine(Math.Min(4, 90));
            Console.WriteLine(Math.Round(4.3));
            Console.WriteLine(Math.Round(4.6));
            Console.WriteLine();
        }

        // Method to get user input and display it
        static void gettingUserInput()
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age + " years old");
            Console.WriteLine();

        }

        // Basic calculator method
        static void basicCalc()
        {

            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 % num2);

        }

        // Mad Libs game method
        static void madLibs()
        {

            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity name: ");
            celebrity = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);

        }

        // Method to demonstrate working with arrays
        static void workingWithArrays()
        {

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "Kelly";
            friends[2] = "Andy";
            friends[3] = "Rachel";

            luckyNumbers[1] = 900;

            Console.WriteLine(luckyNumbers[0]);
            Console.WriteLine(luckyNumbers[2]);
            Console.WriteLine(luckyNumbers[1]);
            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);
            Console.WriteLine(friends[2]);
            Console.WriteLine(friends[3]);

        }

        // Method to greet a user with a name and age

        static void sayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }


        // Method to calculate the cube of a number
        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }

        static void ifStatement()
        {
            bool isMale = true;
            bool isTall = false;

            if (isMale && isTall)//|| or condition if male or tall is true that will continue into the if statement
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are a tall women");
            }
            else
            {
                Console.WriteLine("You are a short women");
            }
        }

        static int getMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }


            return result;
        }

        static void betterCalc()
        {
            double answer = 0;
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Operator(+,-,*,/): ");
            string op = Console.ReadLine();
            Console.Write("Enter a second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
        }

        static string getDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Monday";
                    break;
                case 1:
                    dayName = "Tuesday";
                    break;
                case 2:
                    dayName = "Wednesday";
                    break;
                case 3:
                    dayName = "Thursday";
                    break;
                case 4:
                    dayName = "Friday";
                    break;
                case 5:
                    dayName = "Saturday";
                    break;
                case 6:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;

            }

            return dayName;
        }

        static void whileLoop()
        {
            int index = 1;

            //while loop
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
            Console.WriteLine();

            //do while loop
            int index1 = 1;
            do
            {
                Console.WriteLine(index1);
                index1++;
            }
            while (index1 <= 5);
        }

        static void guessingGame()
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;


            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }

            }
            if (outOfGuesses == true)
            {
                Console.WriteLine("You lose!!");
            }
            else
            {
                Console.WriteLine("You Win");

            }


            /*do
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
            } while (guess != secretWord);*/

        }

        static void forLoop()
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };


            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            for (int j = 0; j < luckyNumbers.Length; j++)
            {
                Console.WriteLine(luckyNumbers[j]);
            }
        }

        static int getPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }

        static void twoDimensionalArray()
        {
            int[,] numberGrid = {
                {1,2},
                {3,4},
                {5,6}
            };


            int[,] myArray = new int[2, 3]; //2 elements with 3 inside of each element


            for (int i = 0; i < numberGrid.GetLength(0); i++)
            {
                for (int j = 0; j < numberGrid.GetLength(1); j++)
                {
                    Console.Write(numberGrid[i, j]);
                    //0,0..0,1..1,0..1,1..2,0..2,1
                }
            }
        }

        static void exceptionHandling()
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally//optional
            {
                Console.WriteLine("End Code");
            }
        }

        static void classesAndObjects()
        {
            //created a book object which is a instance of the book class and define the books attributes
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "J.K. Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord of the Rings";
            book2.author = "Tolkein";
            book2.pages = 700;

            Console.WriteLine(book1.title + " " + book1.author + " " + book1.pages);
            Console.WriteLine(book2.title + " " + book2.author + " " + book2.pages);
        }

        static void constructors()
        {
            //created a book object which is a instance of the book class and define the books attributes
            Book book1 = new Book("Harry Potter", "J.K. Rowling", 400);
            Book book2 = new Book("Lord of the Rings", "Tolkein", 700);
            Console.WriteLine(book2.title);
        }

        static void objectMethods()
        {
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
        }

        static void gettersAndSetters()
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "Dog"); // Invalid rating defaults to "NR"

            Console.WriteLine($"Avengers Rating: {avengers.Rating}"); // Output: PG-13
            Console.WriteLine($"Shrek Rating: {shrek.Rating}");       // Output: NR
        }

        static void staticClassAttribute()
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);//1

            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);//2

            Console.WriteLine(holiday.artist);
            Console.WriteLine(kashmir.artist);
            Console.WriteLine(kashmir.getSongCount());
        }

        static void staticMethod()
        {
            //static class cant make a instance of usefultools can only call functions that have parameters or not
            UsefulTools.SayHi("Nolan");
        }

        static void inheritance()
        {
            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecialDish();
            chef.MakeSalad();


            ItalianChef chef2 = new ItalianChef();
            chef2.MakeChicken();
            chef2.MakeSpecialDish();
            chef2.MakeSalad();
            chef2.MakePasta();
        }


        static void arrays()
        {
            int[] numbers = new int[5];

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            // Print each element in the array
            Console.WriteLine("Array:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        static void lists()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            numbers.Add(6);
            numbers.Remove(3);

            // Print each element in the list
            Console.WriteLine("List:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        static void stacks()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            int top = stack.Pop();

            // Print the top element that was popped
            Console.WriteLine("Stack:");
            Console.WriteLine("Top element: " + top);

            // Print remaining elements in the stack
            Console.WriteLine("Remaining elements:");
            foreach (int number in stack)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        static void queues()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            int front = queue.Dequeue();

            // Print the front element that was dequeued
            Console.WriteLine("Queue:");
            Console.WriteLine("Front element: " + front);

            // Print remaining elements in the queue
            Console.WriteLine("Remaining elements:");
            foreach (int number in queue)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        static void linkedLists()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(0);

            // Print each element in the linked list
            Console.WriteLine("LinkedList:");
            foreach (int number in list)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        static void bubbleSort(int[] arr)
        {
            for(int i = 0;i< arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[i + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int number in arr)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}

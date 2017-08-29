using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Declaring an array
            ////DataType[] nameOfArray = { elements};
            //int[] myArray = { 1, 2, 3, 4, 5, 6 }; //initialize the array 
            //string[] students = { "Brad", "Amy", "Jackie", "Rick", "Mike" };
            //Console.WriteLine(students[4]);
            //Console.WriteLine(students[0]);
            ////if forget that index starts at 0 and look for something bigger than your array, you will get a runtime error
            ////an unhandled exception, index out of bounds

            ////top 10 vacation spots
            ////print out first and last
            //string[] vacationSpots = { "Ohio", "London", "Put-in-Bay", "Niagara Falls", "Disney", "Rome", "Phoenix", "Chicago", "Raleigh", "Maine" };
            //Console.WriteLine("first spot: " + vacationSpots[0] + " last spot: " + vacationSpots[vacationSpots.Length-1]);

            ////ages of three children
            ////print out each child's age
            //int[] kidsAge = {3,7,9};
            //Console.WriteLine(kidsAge[0] + " " + kidsAge[1] + " " + kidsAge[2]);


            ////gpa on a 4.0 scale of 8 students
            ////when you DONT know the elements of your array up front
            ////dataType[] nameOfArray = new dataType[number of elements]; keyword 'new' is reference type, points to something
            //float[] studentGpa = new float[8];//creates an empty array of length 8 (declared but not initialized)

            ////first letter of your peers names who are sitting next to you
            //string[] peerLetters = {"c","i"};
            //char[] firstLetters = { 'c', 'i' }; //char type uses single quote marks
            //Console.WriteLine(firstLetters); //will print them all in a row - this only works with type char

            ////declare and initialize an array for the days of the week
            //string[] daysOfWeek = new string[7];
            //daysOfWeek[0] = "Sunday";
            //daysOfWeek[1] = "Monday";
            //daysOfWeek[2] = "Tuesday";
            //daysOfWeek[3] = "Wednesday";
            //daysOfWeek[4] = "Thursday";
            //daysOfWeek[5] = "Friday";
            //daysOfWeek[6] = "Saturday";
            //Console.WriteLine(daysOfWeek.Length);
            //Console.WriteLine(daysOfWeek[0]);
            //daysOfWeek.SetValue("Funday",0); //setvalue changes the value at specific array point
            //Console.WriteLine(daysOfWeek[0]);

            ////declare and initialize an array of student ages using the NEW keyword
            //int[] studentAges = new int[5];
            //studentAges[0] = 20;
            //studentAges[1] = 25;
            //studentAges[2] = 30;
            //studentAges[3] = 35;
            //studentAges[4] = 40;


            ////Another Method of arrays

            //string[] birthMonths = { "December", "July", "May", "July" };
            //Console.WriteLine(Array.IndexOf(birthMonths,"July")); //indexOf returns the first instance only in the array
            //Console.WriteLine(Array.LastIndexOf(birthMonths,"July"));//lastIndexOf returns the last instance

            //reverse the order of our array
            //int[] numbers = { 2, 3, 5, 7, 10, -2, 4, 897, 0 };
            //Console.WriteLine(numbers[0]);
            //Array.Reverse(numbers); 
            //Console.WriteLine(numbers[0]);

            //sort the array in c# (some other languages don't do this)
            //can use for strings, too, but lowercase comes before uppercase
            //Array.Sort(numbers);
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[numbers.Length-1]);



            ////Declare and initialize a string array of first names. Choose a name to find and print the IndexOf.
            //string[] firstNames2 = { "bob", "tom", "hal", "joe" };
            //Console.WriteLine(Array.IndexOf(firstNames2, "joe"));

            //Create an array of lucky numbers. Each number should repeat at least once. 
            //Choose a lucky number, find and print the last index of it.
            int[] luckyNumbers = { 3, 4, 7, 4, 7, 3, 7, 4, 4, 3, 7 };
            Console.WriteLine(Array.LastIndexOf(luckyNumbers,3));


            //Create an array of alphabet characters. Print the first index of the array. 
            //Now reverse the array and print the first index.
            char[] letters = { 'a', 'h', 'a', 'h' };
            Console.WriteLine(letters[0]);
            Array.Reverse(letters);
            Console.WriteLine(letters[0]);


            //Create an array of student names in random order. Order the students’ names using the sort method. 
            //Print the first and last students’ names.
            string[] studentsNames = { "joey","bob", "tom", "hal", "joe" };
            Array.Sort(studentsNames);
            Console.WriteLine(studentsNames[0]);
            Console.WriteLine(studentsNames[studentsNames.Length-1]);


            //Ask 10 people for their favorite numbers and create an array of those numbers. 
            //Order the numbers using the sort method. Print the first and last numbers.

            int[] luckyNumbers2 = { 3, 4, 7, 4, 7, 3, 7, 4, 4, 3, 7 };
            Array.Sort(luckyNumbers2);
            Console.WriteLine(luckyNumbers2[0]);
            Console.WriteLine(luckyNumbers2[luckyNumbers.Length-1]);





        }
    }
}

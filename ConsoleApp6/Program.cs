using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string to chacke whether it is a palindrome");
            Palindrome(Console.ReadLine());
        }
        static void Palindrome(string word) {
            //evaluate the length of the string


            
                  //get the forward half of the word
                  string substrForwards = word.Substring(0, ((word.Length) / 2));
                  Console.WriteLine($"This is the forwards substring, {substrForwards}");

            //get the backward half of the word
               //reverse the string
                 //convert the string to an array
                    char[] wordArr = word.ToCharArray();
                     //reverse the array
                     Array.Reverse(wordArr);
                    //this will modify the array, and not return a new one
                    //join this array into a string
                    string backWord =  String.Join("", wordArr);
                    //get the substring 
                    string substrBackwards = backWord.Substring(0, ((word.Length) / 2));
                    Console.WriteLine($"This is the backwards substring, {substrBackwards}");



                    //finally, compare the substrings
                    if(substrForwards == substrBackwards)
                    {
                      Console.WriteLine("This is a palindrome");
                    }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_auto
{
    public class Exercise
    {
        public string Cloth { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }
        private string Name { get; set; }


        public Exercise(string cloth, int size, string color, string name)
        {
            Cloth = cloth;
            Size = size;
            Color = color;
            Name = name;
        }

        public Exercise(string cloth, int size, string name)
        {
            Cloth = cloth;
            Size = size;
            Color = "Blue";
            Name = name;
        }

        public string GetName ()
        {
            return Name;
        }


    
        public Exercise()
        {

        }


        public void CheckForPalindrome(string firstWord, string secondWord)
        {
            firstWord = firstWord.ToLower();
            int lenghtWord1 = firstWord.Length;

            char[] arrayFirstWord = new char[lenghtWord1];
            char[] arraySecondWord = new char[lenghtWord1];

            for (int i = 0; i <= lenghtWord1-1; i++ )
            {
                arrayFirstWord[i] = firstWord.ElementAt(i);
            }

            int n = 0; 
            for (int i = lenghtWord1 - 1; i >= 0; i-- )
            {
                arraySecondWord[n] = firstWord.ElementAt(i);
                n++;
            }

            secondWord = new string(arraySecondWord);

            if (firstWord.Equals(secondWord))
                Console.WriteLine("Is Palindrome");
            else
                Console.WriteLine("Is not a Palindrome");
        }
    }
}

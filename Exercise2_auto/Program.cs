using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_auto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Exercise FistValue = new Exercise("Skirt", 9, "Red", "Ana");
            Exercise SecondValue = new Exercise("Dress", 13, "Montse");
            Diagonal Diag = new Diagonal();

            Console.WriteLine("FistValue:" + FistValue.Cloth + ".:." + FistValue.Size.ToString() + ".:." + FistValue.Color);
            Console.WriteLine("FistValue:" + SecondValue.Cloth + ".:." + SecondValue.Size.ToString() + ".:." + SecondValue.Color);

            Console.WriteLine("First Name:" + FistValue.GetName());
            Console.WriteLine("Second Name:" + SecondValue.GetName());

            string reverse= "";
            FistValue.CheckForPalindrome(FistValue.GetName(), reverse);
            
            Console.WriteLine("Lenght of the diagonal:");
            string lenght = "0";
            int number = 0;
            lenght = Console.ReadLine();
            number = Convert.ToInt16(lenght);
            Diag.DiagonalPrint(number);
            Console.ReadLine();
            Console.ReadLine();

        }
    }
}


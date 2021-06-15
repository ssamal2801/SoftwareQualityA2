using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareQualityA2
{
    class Program
    {
        static public int Operations()
        {
            Console.WriteLine("Please select a correct option from the menu: ");
            Console.WriteLine("Menu");
            Console.WriteLine("1) Get Rectangle Length");
            Console.WriteLine("2) Change Rectangle Width");
            Console.WriteLine("3) Get Rectangle Width");
            Console.WriteLine("4) Change Rectangle Length");
            Console.WriteLine("5) Get Rectangle Perimeter");
            Console.WriteLine("6) Get Rectangle Area");
            Console.WriteLine("7) Exit \n");

            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }

        static public Rectangle ValidateInput()
        {
            int length = 0, width = 0;
            Rectangle rect;

            do
            {
                try
                {
                    Console.WriteLine("Please type in the length of rectangle");
                    length = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please type in the width of rectangle");
                    width = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.Message);
                }
                rect = new Rectangle(length, width);

                if (length <= 0 || width <= 0)
                {
                    Console.WriteLine("Dimensions of a rectangle should be more than 0. " +
                        "Please try again!.\n");
                }

            } while (length <= 0 || width <= 0);

            return rect;
        }

        static void Main(string[] args)
        {
            Rectangle rectangle = ValidateInput();
            int optionSelected;
            do
            {
                optionSelected = Operations();
                switch (optionSelected)
                {
                    case 1:
                        Console.WriteLine("Length: {0}", rectangle.GetLength());
                        break;

                    case 2:
                        Console.WriteLine("Enter the new Length for rectangle");
                        rectangle.SetLength(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Your new length is: {0}", rectangle.GetLength());
                        break;

                    case 3:
                        Console.WriteLine("The width of rectangle is: {0}", rectangle.GetWidth());
                        break;

                    case 4:
                        Console.WriteLine("Enter the new Width for rectangle");
                        rectangle.SetWidth(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Your new width is: {0}", rectangle.GetWidth());
                        break;
                    case 5:
                        Console.WriteLine("The Perimeter of rectangle is: {0}", rectangle.GetPerimeter());
                        break;

                    case 6:
                        Console.WriteLine("The Area of rectangle is: {0}", rectangle.GetArea());
                        break;

                    case 7:
                        Console.WriteLine("Bye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option selected. Please try again. \n");
                        break;
                }

            } while (optionSelected != 7);

            Console.Read();

        }
    }
}

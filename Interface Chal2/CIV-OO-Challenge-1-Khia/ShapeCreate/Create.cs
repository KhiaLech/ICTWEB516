using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape_Library;


namespace ShapeCreate
{
    public class Create
    {
        public class InvalidInputException : Exception
        {


            public InvalidInputException(string message) : base(message)
            {

            }
        }

        static string[] colours = { "blue", "green", "yellow", "red", "white", "black" };


        static void Main(string[] args)
        {

            do
            {

                Console.WriteLine("Would you like to: ");
                Console.WriteLine("(1) Create a Square");
                Console.WriteLine("(2) Create a Rectangle");
                Console.WriteLine("(3) Create a Equilateral Triangle");
                Console.WriteLine("(4) Create a Right Angle Triangle");
                Console.WriteLine("(5) Create a Circle");
                Console.Write("Enter selection: ");
                var choice = int.Parse(Console.ReadLine());


                if (choice == 1)
                {
                    List<Square> s = new List<Square>();

                    try
                    {

                        Console.Write("Enter a colour: ");
                        var i1 = Console.ReadLine();
                        if (Array.IndexOf(colours, i1) == -1)
                        {
                            throw new InvalidInputException("Invalid Input, Please enter a colour");
                        }



                        Console.Write("Enter a side length: ");
                        var i2 = int.Parse(Console.ReadLine());
                        if (i2 < 1)
                        {
                            throw new InvalidInputException("Invalid input, less than 1 entered. Try Again.");
                        }



                        s.Add(new Square(i1, i2));
                    }

                    catch (Exception message)
                    {
                        Console.WriteLine(message);

                    }




                    foreach (Square i in s)
                        Console.WriteLine("Sqaure: " + i.ToString());
                }

                else if (choice == 2)
                {
                    List<Rectangle> r = new List<Rectangle>();

                    try
                    {
                        Console.Write("Enter a colour: ");
                        var i1 = Console.ReadLine();
                        if (Array.IndexOf(colours, i1) == -1)
                        {
                            throw new InvalidInputException("Invalid Input, Please enter a colour");
                        }



                        Console.Write("Enter a side length: ");
                        var i2 = int.Parse(Console.ReadLine());
                        if (i2 < 1)
                        {
                            throw new InvalidInputException("Invalid input, less than 1 entered. Try Again.");
                        }



                        Console.Write("Enter a side length: ");
                        var i3 = int.Parse(Console.ReadLine());
                        if (i3 < 1)
                        {
                            throw new InvalidInputException("Invalid input, less than 1 entered. Try Again.");
                        }



                        r.Add(new Rectangle(i1, i2, i3));
                    }
                    catch (Exception message)
                    {
                        Console.WriteLine(message);
                    }

                    foreach (Rectangle i in r)
                        Console.WriteLine("Rectangle: " + i.ToString());
                }


                /*  if (choice == 5)
                  {
                      List<Circle> c = new List<Circle>();

                      try
                      {

                          Console.Write("Enter a colour: ");
                          var i1 = Console.ReadLine();
                          if (Array.IndexOf(colours, i1) == -1)
                          {
                              throw new InvalidInputException("Invalid Input, Please enter a colour");
                          }

                          Console.WriteLine("Pi = 3.14");



                          Console.Write("Enter a Radius: ");
                          var i2 = int.Parse(Console.ReadLine());
                          if (i2 < 1)
                          {
                              throw new InvalidInputException("Invalid input, less than 1 entered. Try Again.");
                          }



                          s.Add(new Circle(i1, i2, i3));
                      }

                      catch (Exception message)
                      {
                          Console.WriteLine(message);

                      }




                      foreach (Circle i in s)
                          Console.WriteLine("Circle: " + i.ToString());
                  }



                  */

                else
                {
                    Console.WriteLine("invalid option");
                }


                Console.WriteLine("Create another? y/n ");



            } while (Console.ReadLine() == "y");

            Console.ReadKey();


        }
    }
}




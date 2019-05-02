using System;
using System.Collections.Generic;

namespace Lab10
{
    class Program
    {
            public static void Main(string[] args)
            {
            //Circle c = new Circle(5.5);
            //Console.WriteLine("Circumference: " + c.GetCircumference());
            //Console.WriteLine("Area: " + c.GetArea());
            //Circle c2 = new Circle(120.16);


            

            CircleApp app = new CircleApp();

            app.Run();
            }
    }

    class Circle
    {
        private double radius;

        public Circle(double r)
        {

            //this.radius = radius;
            radius = r;
            //Console.WriteLine("Radius: " + radius);

        }

        public double GetCircumference()
        {
            double output = Math.Floor(2 * Math.PI * radius);
            return output;
        }

        public double GetArea()
        {
            double area = Math.Floor(Math.PI * Math.Pow(radius, 2));
            return area;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Radius: " +radius);
            Console.WriteLine($"Area: {GetArea()}");
            Console.WriteLine($"Circumference: {GetCircumference()}");
        }
    }
    class CircleApp
    {
        Boolean run = true;

        public List<Circle> Circles = new List<Circle>();

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Grand Circus Circle Tester!\n");
                Console.WriteLine("Please enter a radius: ");
                double radius = Convert.ToDouble(Console.ReadLine());

                Circle c = new Circle(radius);
                Circles.Add(c);
                PrintCircles();

                Console.WriteLine("You created {0} Circle object(s).", Circles.Count);

                Console.WriteLine("Would you like to continue? (y/n)");

                string input = Console.ReadLine();
                Boolean run = false;
                input.ToLower();

                if (input == "n")
                {
                    for (int i = 0; i < Circles.Count; i++)
                    {
                        Circles[i].PrintInfo();
                        Console.WriteLine("Goodbye. You created {0} Circle object(s).", Circles.Count);
                        run = false;
                    }
                    break;
                }
                else if (input == "y")
                {
                    run = true;
                }
                else
                {
                    Console.WriteLine("I'm sorry I didn't understand your input. Goodbye.");
                    System.Environment.Exit(0);
                }
            }
        }
        public void PrintCircles()
        {
            for (int i = 0; i < Circles.Count; i++)
            {
                Circles[i].PrintInfo();
                Console.WriteLine("-------------------");
                
            }
        }



        

    }
}

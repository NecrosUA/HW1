using System;

namespace Area_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            string vconsole = "";
            double area = 0; //calulated area 
            double a = 0, b = 0, c = 0, r = 0; //Sides and radius

            if (args.Length > 1)
            {
                switch (args[0].ToLower()) //check what we are transfered
                {
                    case "tri":
                        a = Convert.ToDouble(args[1]);
                        b = Convert.ToDouble(args[2]);
                        c = Convert.ToDouble(args[3]);

                        Triangle vtriangle = new Triangle(a,b,c);
                        area = vtriangle.GetArea();
                        Console.Write($"Area of triangle is {area} ");
                        break;
                    case "rect":
                        a = Convert.ToDouble(args[1]);
                        b = Convert.ToDouble(args[2]);

                        Rectangle vrectangle = new Rectangle(a, b);
                        area = vrectangle.GetArea();
                        Console.Write($"Area of rectangle is {area} ");
                        break;
                    case "circ":
                        r = Convert.ToDouble(args[1]);

                        Circle vcircle = new Circle(r);
                        area = vcircle.GetArea();
                        Console.Write($"Area of circle is {area} ");
                        break;
                    case "sqr":
                        a = Convert.ToDouble(args[1]);

                        Square vsquare = new Square(a);
                        area = vsquare.GetArea();
                        Console.Write($"Area of square is {area} ");
                        break;
                    default:
                        Console.WriteLine("Please insert correct parameter!");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Area calc 2.2 by Rostyslav Kokhanchuk");
                Console.WriteLine("Help: type 'rect' for rectangle, 'tri' for triangle, 'circ' for circle, 'sqr' for sqare \n or 'exit' to terminate program");
                //Circle vcircle = new Circle(5);
                //area = vcircle.GetArea();

                while (vconsole.ToLower() != "exit")
                {
                    //Console.Write("Please enter type of figure and parameters using spaces: ");
                    vconsole = Console.ReadLine();

                    switch (vconsole.ToLower()) //check what we are inserting 
                    {
                        case "tri":
                            Console.WriteLine("Please insert side a: ");
                            vconsole = Console.ReadLine();
                            a = Convert.ToDouble(vconsole);

                            Console.WriteLine("Please insert side b: ");
                            vconsole = Console.ReadLine();
                            b = Convert.ToDouble(vconsole);

                            Console.WriteLine("Please insert side c: ");
                            vconsole = Console.ReadLine();
                            c = Convert.ToDouble(vconsole);

                            Triangle vtriangle = new Triangle(a, b, c);
                            area = vtriangle.GetArea();
                            Console.Write($"Area of triangle is {area} ");
                            break;
                        case "rect":
                            Console.WriteLine("Please insert side a: ");
                            vconsole = Console.ReadLine();
                            a = Convert.ToDouble(vconsole);

                            Console.WriteLine("Please insert side b: ");
                            vconsole = Console.ReadLine();
                            b = Convert.ToDouble(vconsole);

                            Rectangle vrectangle = new Rectangle(a, b);
                            area = vrectangle.GetArea();
                            Console.WriteLine($"Area of rectangle is {area} ");
                            break;
                        case "circ":
                            Console.WriteLine("Please insert radius: ");
                            vconsole = Console.ReadLine();
                            r = Convert.ToDouble(vconsole);

                            Circle vcircle = new Circle(r);
                            area = vcircle.GetArea();
                            Console.WriteLine($"Area of circle is {area} ");
                            break;
                        case "sqr":
                            Console.WriteLine("Please insert side: ");
                            vconsole = Console.ReadLine();
                            a = Convert.ToDouble(vconsole);

                            Square vsquare = new Square(a);
                            area = vsquare.GetArea();
                            Console.WriteLine($"Area of square is {area} ");
                            break;
                        default:
                            Console.WriteLine("Please insert correct parameter!");
                            break;

                    }

                }
            }
            

        }
    }
}

namespace Module1Review;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the desire shape you wish to get the Area from (Circle, Triangle, Rectangle, Square)");
        string selection = Console.ReadLine();

        switch(selection)
        {
            case "Circle":
            case "circle":
                Console.Write("Enter the radius of the circle: ");
                double circleRadius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"\nThe area of the circle with radius {circleRadius} is : {CircleArea(circleRadius)}\n");
                break;

            case "Triangle":
            case "triangle":
                Console.WriteLine("Enter the base of the triangle");
                double triangleBase = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the height of the triangle");
                double triangleHeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"\nThe area of the triangle with base {triangleBase} and height {triangleHeight} is {TriangleArea(triangleBase, triangleHeight)}\n");
                break;

            case "Rectangle":
            case "rectangle":
                Console.WriteLine("Enter the lenght of the rectangle");
                double rectangleLenght = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the width of the rectangle");
                double rectangleWidth = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"\nThe area of the rectangle with lenght {rectangleLenght} and width {rectangleWidth} is {RectangleArea(rectangleLenght, rectangleWidth)}\n");
                break;

            case "Square":
            case "square":
                Console.WriteLine("Enter the lenght of the square");
                double squareLenght = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"\nThe area of the square with lenght {squareLenght} is {SquareArea(squareLenght)}\n");
                break;

            default:
                Console.WriteLine("\nEnter a shape of the selection presented and check your spelling.\n");
                break;
        }
        
        //Console.Write("Enter the radius of the circle: ");
        //double circleRadius = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine($"The area of the circle with radius {circleRadius} is : {CircleArea(circleRadius)}\n");

        //Console.WriteLine("Enter the base of the triangle");
        //double triangleBase = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Enter the height of the triangle");
        //double triangleHeight = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine($"The area of the triangle with base {triangleBase} and height {triangleHeight} is {TriangleArea(triangleBase,triangleHeight)}\n");

        //Console.WriteLine("Enter the lenght of the rectangle");
        //double rectangleLenght = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Enter the width of the rectangle");
        //double rectangleWidth = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine($"The area of the rectangle with lenght {rectangleLenght} and width {rectangleWidth} is {RectangleArea(rectangleLenght, rectangleWidth)}\n");

        //Console.WriteLine("Enter the lenght of the square");
        //double squareLenght = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine($"The area of the square with lenght {squareLenght} is {SquareArea(squareLenght)}\n");

    }

    public static double CircleArea(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public static double TriangleArea(double triangleBase, double triangleHeight)
    {
        return 0.5 * triangleBase * triangleHeight;
    }

    public static double RectangleArea(double lenght, double width)
    {
        return lenght * width;
    }

    public static double SquareArea(double lenght)
    {
        return Math.Pow(lenght, 2);
    }
}

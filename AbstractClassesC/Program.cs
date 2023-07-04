namespace AbstractClassesC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Shape[] shapes =
            {
                new Sphere(4), new Cube(4)
            };

            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine($"{shape.Name} has a volume of {shape.Volume()}");
            }
            Console.ReadLine();
        }
    }
}
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

                Cube iceCube = shape as Cube;
                if (iceCube == null)
                {
                    Console.WriteLine("This Shape is no cube!");
                }

                if (shape is Cube)
                {
                    Console.WriteLine("This Shape is a cube!");
                }

                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;
                Console.WriteLine($"{cube2.Name} has a Voulume of {cube2.Volume()}");
            }
            Console.ReadLine();
        }
    }
}
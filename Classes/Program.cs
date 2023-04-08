namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();

            myCar.Make = "Jeep";
            myCar.Model = "Liberty";
            myCar.Year = 2010;

            Console.WriteLine($"You drive a {myCar.Year} {myCar.Make} {myCar.Model}");

        }
    }
}

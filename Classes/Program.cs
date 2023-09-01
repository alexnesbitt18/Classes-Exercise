namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Corolla";
            myCar.Year = 2010;

            Console.WriteLine($"My car is a {myCar.Make} {myCar.Model} that was made in {myCar.Year}.");
        }
    }
}

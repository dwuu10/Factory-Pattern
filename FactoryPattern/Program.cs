namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of wheels you would like on your vehicle:");

            int.TryParse(Console.ReadLine(), out var output);

            var myVehicle = VehicleFactory.GetVehicle(output);

            myVehicle.Drive();
        }
    }
}

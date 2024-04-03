namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of wheels for your vehicle");
            int wheelCount;
            var winput = int.TryParse(Console.ReadLine(), out wheelCount);

            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
        }
    }
}

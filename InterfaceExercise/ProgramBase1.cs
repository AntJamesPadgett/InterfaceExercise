namespace InterfaceExercise
{
    public class ProgramBase1
    {
        public static void Main(string[] args)
        {
            var car = new Car();
            var truck = new Truck();
            var suv = new SUV();

            var vehcles = new List<IVehicle>() { car, truck };

        }
    }
}
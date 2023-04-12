namespace Dz6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.Write("Enter task (1 - 4): ");
                choice = int.Parse(Console.ReadLine()); 
                switch (choice) 
                {
                    case 1:
                        break;
                    case 2:
                        Console.WriteLine("\nKettle:");
                        Kettle kettle = new Kettle("", 0, 0);
                        kettle.Input();
                        kettle.Sound();
                        kettle.Show();
                        kettle.Desc();
                        Console.WriteLine("\nMicrowave:");
                        Microwave microwave = new Microwave("", 0, 0);
                        microwave.Input();
                        microwave.Sound();
                        microwave.Show();
                        microwave.Desc();
                        Console.WriteLine("\nCar:");
                        Car car = new Car("", 0, 0);
                        car.Input();
                        car.Sound();
                        car.Show();
                        car.Desc();
                        Console.WriteLine("\nStreamer:");
                        Streamer streamer = new Streamer("", 0, 0);
                        streamer.Input();
                        streamer.Sound();
                        streamer.Show();
                        streamer.Desc();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default: Console.WriteLine("Error! Try again!"); break;
                }
            } while (choice < 1 || choice > 4);
        }
    }
}
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
                        Console.Write("\nOriginal price of product\nEnter name of product: ");
                        string name = Console.ReadLine();
                        Console.Write("\nEnter price in dollars: ");
                        int dollar = int.Parse(Console.ReadLine());
                        Console.Write("Enter price in cents: ");
                        int cents = int.Parse(Console.ReadLine());
                        Money price = new Money(dollar, cents);
                        Product product = new Product(name, price.Dollars, price.Cents);
                        product.Display();
                        Console.Write("\nEnter price in dollars to reduce: ");
                        dollar = int.Parse(Console.ReadLine());
                        Console.Write("Enter price in cents to reduce: ");
                        cents = int.Parse(Console.ReadLine());
                        product.ReducePrice(dollar, cents);
                        product.Display(); 
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
                        Console.WriteLine("\nViolin:");
                        Violin violin = new Violin("", 0, 0);
                        violin.Input();
                        violin.Sound();
                        violin.Show();
                        violin.Desc();
                        violin.History();
                        Console.WriteLine("\nTrombone:");
                        Trombone trombone = new Trombone("", 0, 0);
                        trombone.Input();
                        trombone.Sound();
                        trombone.Show();
                        trombone.Desc();
                        trombone.History();
                        Console.WriteLine("\nUkulele:");
                        Ukulele ukulele = new Ukulele("", 0, 0);
                        ukulele.Input();
                        ukulele.Sound();
                        ukulele.Show();
                        ukulele.Desc();
                        ukulele.History();
                        Console.WriteLine("\nCello:");
                        Cello cello = new Cello("", 0, 0);
                        cello.Input();
                        cello.Sound();
                        cello.Show();
                        cello.Desc();
                        cello.History();
                        break;
                    case 4:
                        Console.WriteLine("\nPresident:");
                        President president = new President();
                        president.InputP();
                        president.Print();
                        Console.WriteLine("\nSecurity:");
                        Security security = new Security();
                        security.InputS();
                        security.Print();
                        Console.WriteLine("\nManager:");
                        Manager manager = new Manager();
                        manager.InputM();
                        manager.Print();
                        Console.WriteLine("\nEngineer:");
                        Engineer engineer = new Engineer();
                        engineer.InputE();
                        engineer.Print();
                        break;
                    default: Console.WriteLine("Error! Try again!"); break;
                }
            } while (choice < 1 || choice > 4);
        }
    }
}
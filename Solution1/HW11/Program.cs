using System;


namespace HW11
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info($"Start {typeof(Program)}");

            Shapes[] shapes =
            {
                new Circle(),
                new Square(),
                new Triangle()
            };

            Logger.Log.Info("The process of data output to the Console has started.");
            foreach (var item in shapes)
            {
                item.AreaCalculate();
                
                Console.WriteLine($"> This is {item.Name}\nCLR Type is {item.GetType()}\nSquare is {item.Area}");
            }
            Logger.Log.Info("The program was successfully complated :)");
        }
    }
}

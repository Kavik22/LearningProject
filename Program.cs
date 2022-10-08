using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot bot_1 = new Robot("Botik", 2.33f, new short[] {3, 4, 67});


            bot_1.print_data();
 
            // bot_1.Name = "Bot 1";
            // bot_1.Weight = 3.45f;
            // bot_1.Coordinates =new short[] {1, 2, 3};

            // System.Console.WriteLine("Name: {0}", bot_1.Name);
            // System.Console.WriteLine("Weight: {0}",bot_1.Weight);

        }

    }
}

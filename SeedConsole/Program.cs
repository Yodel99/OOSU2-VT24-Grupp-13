using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatienthanteringDLef;
using PatienthanteringDLef.DataSeed;

namespace SeedConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            PatientMSContext context = new PatientMSContext();
            

            //Console.WriteLine("Would you like to reset the Database? Y/N");
            //if (Console.ReadKey().Key == ConsoleKey.Y)
            //{
            //    context.Database.EnsureCreated();                               
            //    DataSeed.Fill(context);
            //}
        }
    }
}

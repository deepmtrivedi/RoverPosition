using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobertRover
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Give the Command to move the Rover =>\t");
                string command = Console.ReadLine();
                RoverPosition p = new RoverPosition();
                Console.Write($"Final position based on given command => {p.Move(command)}");
                Console.ReadKey();
            }
            catch (Exception)
            {
                throw;
            }

            Console.ReadKey();
        }
    }
}

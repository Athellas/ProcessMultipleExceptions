using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProcessMultipleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Handling Multiple Exceptions *****\n");
            Car myCar = new Car("Rusty", 90);
            //try
            //{
            //    // Trip Arg out of range exception.
            //    myCar.Accelerate(-10);
            //}
            //catch (CarIsDeadException e)
            //{
            //    try
            //    {
            //        // Attempt to open a file named carErrors.txt on the C drive.
            //        FileStream fs = File.Open(@"C:\carErrors.txt", FileMode.Open);
            //    }
            //    catch (Exception e2)
            //    {
            //        // Throw an exception that records the new exception,
            //        // as well as the message of the first exception.
            //        throw new CarIsDeadException(e.Message, e2);
            //    }
            //    Console.WriteLine(e.Message);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    // This will always occur. Exception or not.
            //    myCar.CrankTunes(false);
            //}

            myCar.Accelerate(500);
            Console.ReadLine();

        }
    }
}

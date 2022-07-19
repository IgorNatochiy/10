using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                int gradus_ = Convert.ToInt32(Console.ReadLine());
                int min_ = Convert.ToInt32(Console.ReadLine());
                int sec_ = Convert.ToInt32(Console.ReadLine());

                Radians radians = new Radians(gradus_, min_, sec_);
                //Radians radians = new Radians() {gradus=gradus_, min=min_, sec=sec_};

                //radians.gradus=Convert.ToInt32(Console.ReadLine());
                //radians.min=Convert.ToInt32(Console.ReadLine());
                //radians.sec=Convert.ToInt32(Console.ReadLine());



                int totalRadians = radians.ToRadians();
                Console.WriteLine(totalRadians);
                Console.ReadKey();
            }
        }
    }
}

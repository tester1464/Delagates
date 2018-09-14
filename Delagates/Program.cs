using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delagates
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car { Name = "Audi" };

            //przypisanie polu referencji do metody, która obłuży zdażenie, zabezpieczeniem jest null
            // w klasie Cars
            car.NameChanged = new NameChangedDelegate(Events.carNameChanged);

            //method is called from here
            car.Name = "BMW";

            Console.ReadKey();


        }

    }

}

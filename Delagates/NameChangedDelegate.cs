using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delagates
{
    //delagate with signature:
    // return type - void
    // arguments - 2x string
    // Pole, które przetrzymuje referencję do metody danego obiektu
    public delegate void NameChangedDelegate(string oldName, string newName);

    static class Events
    {
        public static void carNameChanged(string old, string newer)
        {
            Console.WriteLine($"Changed from {old} to {newer}");
        }
    }
}
  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delagates
{
    class Car
    {

        //field with delegate 
        public NameChangedDelegate NameChanged;

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    var oldName = _name;
                    _name = value;
                    //check if nasłuchujący (delegat) isn't null
                    if (NameChanged != null)
                        //jeśli nie jet to wywołujemy zdarzenie
                        NameChanged(oldName, _name);
                }
                
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    class Passengers
    {
        public string name;
        public string secondname;
        public string pasport;
        public string dateofbirthday;
        public Sex sex;
        public Nationality nationality;
    }
    enum Nationality
    { 
        Unknown = 0,
        Ukranian = 1,
        Jew = 2,
        Arab = 3,
        Canadian = 4,
        French = 5
    }
    enum Sex
    {
        Unknown = 0,
        Female = 1,
        Male = 2
    }
}

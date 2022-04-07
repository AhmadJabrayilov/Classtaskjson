using System;
using System.Collections.Generic;
using System.Text;

namespace Jplaceholder.Models
{
    class Adress 
    {
        public string Street { get; set; }

        public string Suite { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }
        public Geo Geo { get; set; }
        public Adress()
        {

        }
    }
}

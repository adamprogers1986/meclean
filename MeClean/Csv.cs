using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeClean
{
    class Csv
    {
        protected string _addresscolumn;

        public int rownumber{get; set;}
        public int columnnumber { get; set; }
        public string postcodecontent { get; set; }
        public string columncontent {
            get
            {
                return _addresscolumn;

            }
            set
            {
                Address address = new Address();
                if (value == address.Postcode)
                {
                    _addresscolumn = "";
                }
                else
                {
                    _addresscolumn = value;
                }


            }
        }
       
    }
}

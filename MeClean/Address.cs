using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MeClean
{
    class Address

    {
        protected string _address1;
        protected string address2;
        protected string address3;
        protected string city;
        protected string county;
        protected string _postcode;
        protected string _addresscolumn;

        public int rownumber { get; set; }
        public int columnnumber { get; set; }
        public string postcodecontent { get; set; }
        public int postcodecolumn { get; set; }
        public string columncontent
        {
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

        public string Addressline1
        {
            get
            {
                return _address1;
            }
            set
            {
                _address1 = value;
            }

        }

        public string Postcode
        {
            get
            {
                return _postcode;
            }
            set
            {
                string postcode = "([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([A-Za-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9]?[A-Za-z]))))\\s?[0-9][A-Za-z]{2})";

                Regex regex = new Regex(postcode, RegexOptions.IgnoreCase);
                Match match = regex.Match(value);
                if (match.Success)
                {
                    _postcode = match.Value;
                }
            }

        }


    }
}

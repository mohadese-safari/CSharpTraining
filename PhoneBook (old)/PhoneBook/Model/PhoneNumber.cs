using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.Model
{
    public class PhoneNumber
    {
        public PhoneNumber(string number)
        {
            Number = number;
            Label = "";
        }

        public PhoneNumber(string number, string label)
        {
            Number = number;
            Label = label;
        }
        public string Number { get; set; }
        public string Label { get; set; }
    }
}

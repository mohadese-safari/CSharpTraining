using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneBookApp.Model
{
    public class PhoneNumber
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Number { get; set; }
        public string Label { get; set; }
        public PhoneNumber()
        {

        }

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

    }
}

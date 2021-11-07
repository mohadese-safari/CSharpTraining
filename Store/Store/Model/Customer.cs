using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Store.Model
{
    class Customer
    {
        [Key]
        public long Id { get; set; }
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public string NickName { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    class Invoice
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string Number { get; set; }
        public Customer Customer { get; set; }
        public List<InvoiceItem> Items { get; set; }
     }
}

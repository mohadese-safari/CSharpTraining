using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    class InvoiceItem
    {
        public long Id { get; set; }
        public int RowNumber { get; set; }
        public Product Product { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal Price { get; set; }
        public Invoice Invoice { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlock
{
    public class SalesItem
    {
        public Sales SalesSale { get; set; }
        public int SalesId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public decimal TotalAmountOfProductQuantity { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlock
{
    public class Sales
    {
        public int SaleId { get; set; }
        public int SalesRepId { get; set; }
        public DateTime TimeCreated { get; set; }
        public decimal TotalAmountOfSales { get; set; }
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public List<SalesItem> ListOfSalesItems { get; set; }
    }
}

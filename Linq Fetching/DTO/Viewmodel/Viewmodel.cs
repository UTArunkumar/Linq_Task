using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Viewmodel
{

 
    public class Root
    {
        public string product1 { get; set; }
        public List<Transaction> transactions { get; set; }
    }

    public class Transaction
    {
        public int TransactionId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public DateTime TransactionDate { get; set; }
    }


}

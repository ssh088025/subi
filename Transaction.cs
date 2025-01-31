using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSecurityApp
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int CustomerID { get; set; }
        public decimal Betrag { get; set; }
        public string Typ { get; set; }
        public DateTime Datum { get; set; }
        public string Status { get; set; }
    }
}

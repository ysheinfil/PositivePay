using System;
using System.Collections.Generic;
using System.Text;

namespace PositivePayCoreLibrary
{
    public interface IBankRecord
    {
        public string AccountNumber { get; set; }
        public int CheckNumber { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Payee { get; set; }
    }
}

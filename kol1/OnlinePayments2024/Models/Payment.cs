using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePayments2024.Models
{
    public class Payment
    {
        public decimal Amount { get; set; }

        public Payment(decimal amount)
        {
            Amount = amount;
        }

        public override string ToString()
        {
            return $"UPLATA : {Amount}  PROVIZIJA : {CalcFee()} VKUPNO : {Amount + CalcFee()}";
        }

        public decimal CalcFee()
        {
            return Math.Round(Amount * 0.0114m);
        }
    }
}

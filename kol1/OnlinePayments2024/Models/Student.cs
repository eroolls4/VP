using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePayments2024.Models
{
    public class Student
    {
        private string id { get; set; }
        private string name { get; set; }

        public List<Payment> Payments { get; set; }



        public Student()
        {
            Payments = new List<Payment>();
        }


        public void AddPayment(Payment payment)
        {
            this.Payments.Add(payment);
        }

        public Student(string id, string name)
        {
            this.id = id;
            this.name = name;
            Payments = new List<Payment>();
        }

        public override string ToString()
        {
            return this.id + "-" + this.name;
        }


        public decimal TotalAmount()
        {
            decimal total = 0;
            for (int i = 0; i < Payments.Count; i++)
            {
                total += Payments[i].Amount;
            }
            return total;
        }


        public decimal TotalFee()
        {
            decimal total = 0;
            for (int i = 0; i < Payments.Count; i++)
            {
                total += Payments[i].CalcFee();
            }
            return total;
        }
        public string Details()
        {
            StringBuilder sb=new StringBuilder();
            sb.Append(ToString()).Append("\n");
            for (int i = 0; i < Payments.Count; i++)
            {
                sb.Append(i + 1).Append('.').Append(Payments[i].ToString()).Append("\n");
            }
            sb.Append($"TOTAL PAID : {TotalAmount()}").Append("\n");
            sb.Append($"TOTAL FEE : {TotalFee()}").Append("\n");
            return sb.ToString();
        }
    }
}

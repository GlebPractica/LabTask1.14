using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Account
    {
        public int Number { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public DateTime OpeningDate { get; set; }
        public Owner Owner { get; set; }
        public bool SmsNotification { get; set; }
        public bool InternetBanking { get; set; }
    }
}

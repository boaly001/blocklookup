using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlockApp.Models
{
    public class EthereumTransaction
    {
        public string BlockHash { get; set; }
        public long BlockNumber { get; set; }

        public string Gas { get; set; }

        public string Hash { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Value { get; set; }
    }
}

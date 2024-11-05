using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BankTransaction
    {
        public string TransationID {  get; }
        public string Type {  get; }
        public int Amount {  get; }
        public DateTime Timestamp {  get; }
    }
}

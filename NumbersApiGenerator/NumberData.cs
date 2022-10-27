using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersApiGenerator
{
    public class NumberData
    {
        public List<string> Messages { get; set; } = new();
        public int Number { get; set; }
        public NumberData(int number)
        {
            this.Number = number;
        }
    }
}

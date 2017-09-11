using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Account
    {
		public int Number;
		public string Name;
		public double Balance;

		public virtual string ToPrint() {
			return $"{Number}: {Name}-{Balance}";
		}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
	public class Savings : Account {
		public double IntRate;

	public override string ToPrint() {
		return base.ToPrint() + $"::{IntRate}";
		}
	}
}

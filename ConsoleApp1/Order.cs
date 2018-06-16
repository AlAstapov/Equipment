using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Order
	{
		public List<Equipment> Equipment { get; set; }

		public Order(List<Equipment> equipment) {
			Equipment = equipment;
		}

		public double CalculateTotal() {
			double total = 0;
			for (int i = 0; i < Equipment.Count; i++) {
				total += Equipment[i].Price;
			}
			return total;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Stock
	{
		public static int SnowBoardCountOnStock;
		public static int SkiCountOnStock;

		public static void GetSnowBoardsFromStock(int countToTake)
		{
			if (SnowBoardCountOnStock > countToTake) SnowBoardCountOnStock -= countToTake;
		}

		public static void GetSkisFromStock(int countToTake)
		{
			if (SkiCountOnStock > countToTake) SkiCountOnStock -= countToTake;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			Stock.SkiCountOnStock = 20;
			Stock.SnowBoardCountOnStock = 10;

			SnowBoard snowBoard = new SnowBoard(20);
			Ski ski = new Ski(7);

			Console.WriteLine("Это программа заказа оборудования.");
			string tempNumber = "";
			while (!tempNumber.Equals("Выход")) {
				List<Equipment> equipmentList = new List<Equipment>();

				Console.WriteLine("Введите кол-во сноубордов:");
				tempNumber = Console.ReadLine();
				int snowBoardCount =  Int32.Parse(tempNumber);
				if (Stock.SnowBoardCountOnStock < snowBoardCount) {
					Console.WriteLine("Нет на складе");
					break;
				}
				Stock.SnowBoardCountOnStock -= snowBoardCount;
				equipmentList.AddRange(FillEquipmentList(snowBoardCount, snowBoard));

				Console.WriteLine("Введите кол-во лыжи:");
				tempNumber = Console.ReadLine();
				int skiCount = Int32.Parse(tempNumber);
				if (Stock.SkiCountOnStock < skiCount)
				{
					Console.WriteLine("Нет на складе");
					return;
				}
				Stock.SkiCountOnStock -= skiCount;
				equipmentList.AddRange(FillEquipmentList(skiCount, ski));

				Order order = new Order(equipmentList);
				Console.WriteLine(order.CalculateTotal());
				Console.WriteLine("SN count" + Stock.SnowBoardCountOnStock);
				Console.WriteLine("Ski count" + Stock.SkiCountOnStock);
				Console.WriteLine("Press enter to continue");
				Console.WriteLine("Для выхода введите 'ВЫХОД'");
				tempNumber = Console.ReadLine();
			}
        }

		public static List<Equipment> FillEquipmentList(int count, Equipment equipment) {
			List<Equipment> equipmentList = new List<Equipment>();
			for (int i = 0; i < count; i++) equipmentList.Add(equipment);
			return equipmentList;
		}
    }
}

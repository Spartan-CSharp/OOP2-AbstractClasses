using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
	public abstract class Vehicle : IInventoryItem
	{
		public decimal SellPrice
		{
			get; set;
		}

		public decimal PurchasePrice
		{
			get; set;
		}

		public int QuantityOnHand
		{
			get; set;
		}

		public string Manufacturer
		{
			get; set;
		}

		public string Model
		{
			get; set;
		}

		public string VIN
		{
			get; set;
		}

		public decimal CalculateGrossProfit()
		{
			throw new NotImplementedException();
		}

		public void SellItem()
		{
			throw new NotImplementedException();
		}
	}
}

namespace AbstractClass
{
	public interface IInventoryItem
	{
		decimal SellPrice
		{
			get; set;
		}
		decimal PurchasePrice
		{
			get; set;
		}
		int QuantityOnHand
		{
			get; set;
		}
		void SellItem();
		decimal CalculateGrossProfit();
	}
}

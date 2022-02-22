namespace Warehouse
{
    class Stock
    {
        public Item ItemName { get; set; }
        public int Amount { get; set; }
        public Stock (Item itemName, int amount) {
            ItemName = itemName;
            Amount = amount;
        }
    }
}
namespace Warehouse
{
    class Warehouse{
        public string Name { get; set; }
        public Warehouse(string name)
        {
            Name = name;
        }
        public List<Stock> Stock = new List<Stock>();
        public void AddStock(Item itemName, int amount)
        {
            Stock.Add(new Stock(itemName, amount));
        }
        public void PrintInventory(Warehouse warehouseName) {
            Console.WriteLine($"{warehouseName.Name}:");
            foreach(Stock stockItem in Stock)
            {
                Console.WriteLine($"{stockItem.ItemName.Name}: {stockItem.Amount}");
            }
        }
    }
}
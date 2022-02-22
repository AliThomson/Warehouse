namespace Warehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Warehouse clothingWhouse = new Warehouse("Clothing Warehouse");
            Warehouse makeUpWhouse = new Warehouse("Make Up Warehouse");
            Item polo = new Item("Polo Shirt", "Mens Tops");
            Item vneck = new Item("V-neck Jumper", "Mens Tops");
            Item lipstick = new Item("Lipstick", "Make-up");
            clothingWhouse.AddStock(polo, 20);
            clothingWhouse.AddStock(vneck, 2);
            makeUpWhouse.AddStock(lipstick, 45);
            clothingWhouse.PrintInventory(clothingWhouse);
            makeUpWhouse.PrintInventory(makeUpWhouse);
        }
    }
}
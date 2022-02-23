namespace Warehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Warehouse clothingWhouse = new Warehouse("Clothing Warehouse");
            Warehouse makeUpWhouse = new Warehouse("Make Up Warehouse");
            Clothing skyBluePolo = new Clothing("Polo Shirt", "Sky Blue", "Menswear", "Mens Tops");
            Clothing fuchsiaPolo = new Clothing("Polo Shirt", "Fuchsia", "Menswear", "Mens Tops");
            Clothing blackVneck = new Clothing("V-neck Jumper","Black", "Menswear", "Mens Tops");
            Clothing greyVneck = new Clothing("V-neck Jumper","Grey", "Menswear", "Mens Tops");
            Clothing looseJeans = new Clothing("Loose Fit Jeans", "Indigo", "Menswear", "Mens Trousers");
            Clothing hoodie = new Clothing("Hoodie", "Grey Marl", "Menswear", "Mens Tops");

            MakeUp glossPlumLipstick = new MakeUp("Gloss Lipstick", "Plum", "LipStick");
            MakeUp blackMascara = new MakeUp("Black Mascara", "Black", "Mascara");
            MakeUp glossCrimsonLipstick = new MakeUp("Gloss Lipstick", "Crimson", "LipStick");
            
            clothingWhouse.AddStock(skyBluePolo, 20);
            clothingWhouse.AddStock(fuchsiaPolo, 20000);
            clothingWhouse.AddStock(blackVneck, 50);
            clothingWhouse.AddStock(greyVneck, 48);
            clothingWhouse.AddStock(looseJeans, 300);

            makeUpWhouse.AddStock(glossPlumLipstick, 45);
            makeUpWhouse.AddStock(blackMascara, 460);
            makeUpWhouse.AddStock(glossCrimsonLipstick, 2);
            
            clothingWhouse.PrintInventory(clothingWhouse);
            makeUpWhouse.PrintInventory(makeUpWhouse);
        }
    }
}
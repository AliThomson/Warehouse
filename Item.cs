namespace Warehouse 
{
    class Item
    {
        public string Name { get; set; }
        public string Colour { get; set; }       
        //constructor
        public Item(string name, string colour) 
        {
            Name = name;
            Colour = colour;
        }

        //methods
    }
}
// enum Type
        // {
        //     Clothing,
        //     MakeUp,
        // }
        //properties
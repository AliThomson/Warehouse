namespace Warehouse 
{
    class Item
    {
        // enum Type
        // {
        //     Clothing,
        //     MakeUp,
        // }
        //properties
        public string Name { get; set; }
        public string Type { get; set; }

        //constructor
        public Item(string name, string type) 
        {
            Name = name;
            Type = type;
        }

        //methods
       
    }
}
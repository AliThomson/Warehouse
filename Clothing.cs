namespace Warehouse
{
    class Clothing : Item
    {
        public string Section { get; set; }
        public string Category { get; set; }
        public Clothing (string name, string colour, string section, string category) : base (name, colour)
        {
            Section = section;
            Category = category;
        }
        
    }
}
// enum SizeRange
        // {
        //     MensSizes,
        //     LadiesSizes,
        //     ShoeSizes,
        // }
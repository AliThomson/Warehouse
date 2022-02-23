namespace Warehouse
{
    class MakeUp : Item
    {
        public string Category { get; set; }
        public MakeUp (string name, string colour, string category) : base (name, colour)
        {
            Category = category;
        }
        
    }
}
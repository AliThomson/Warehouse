namespace Warehouse
{
    class Clothing
    {
        // enum SizeRange
        // {
        //     MensSizes,
        //     LadiesSizes,
        //     ShoeSizes,
        // }
        public string Gender { get; set;}
        //public string SizeRange { get; set; }
        public string Category { get; set; }
        public Clothing(string gender, /*string sizeRange, */string category)
        {
            Gender = gender;
            //SizeRange = sizeRange;
            Category = category;
        }
        
    }
}
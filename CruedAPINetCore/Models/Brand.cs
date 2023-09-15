namespace CruedAPINetCore.Models
{
    public class Brand
    {
        [key]

        public int Id { get; set; }
        public int ID { get; internal set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public int IsActive { get; set;}
    }
}

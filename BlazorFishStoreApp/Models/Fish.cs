using System.ComponentModel.DataAnnotations;

namespace BlazorFishStoreApp.Models
{
    public class Fish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Price { get; set; }
        public int Lifespan { get; set; }
    }
}

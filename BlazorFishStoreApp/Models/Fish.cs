using System.ComponentModel.DataAnnotations;

namespace BlazorFishStoreApp.Models
{
    public class Fish
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Age is required")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Lifespan is required")]
        public int Lifespan { get; set; }
    }
}

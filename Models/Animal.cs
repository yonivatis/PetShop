using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace PetShopProject.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string? Name { get; set; }
        public double Age { get; set; }
        public string? PictureSource { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Comment>? Comments { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public double Price { get; set; }
    }
}

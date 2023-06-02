using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Razor.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name{ get; set; }
        [Display (Name="Display Order")]
        [Range (1,100,ErrorMessage ="Display number between 1 and 100")]
        public int DisplayOrder { get; set; }
    }
}

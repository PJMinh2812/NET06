using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserApi.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Column(TypeName = "nvarchar(255)")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(255)]
        [Column(TypeName = "nvarchar(255)")]
        public string Email { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(1000)")]
        public string? Description { get; set; }

        [Range(1, 120)]
        public int Age { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public bool Deleted { get; set; } = false;
    }
}

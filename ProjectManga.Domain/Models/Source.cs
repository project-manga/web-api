namespace ProjectManga.Domain.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Source : Entity<int>
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }
    }
}
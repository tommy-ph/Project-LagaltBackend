using System.ComponentModel.DataAnnotations;

namespace Project_LagaltBackend.Models.Main
{
    public class Collabrator
    {
        [Required]
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public Project Project { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }

        [Required]
        [StringLength(50)]
        public string? Status { get; set; }
    }
}

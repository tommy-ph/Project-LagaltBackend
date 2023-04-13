using System.ComponentModel.DataAnnotations;

namespace Project_LagaltBackend.Models.Main
{
    public class Skill
    {
        [Required]
        public int? Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? SkillName { get; set; }
        public ICollection<User>? Users { get; set; }
        public ICollection<Project>? Projects { get; set; }
    }
}

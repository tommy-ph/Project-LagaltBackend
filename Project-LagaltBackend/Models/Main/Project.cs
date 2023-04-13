using System.ComponentModel.DataAnnotations;

namespace Project_LagaltBackend.Models.Main
{
    public enum Progress
    {
        Founding,
        InProgress,
        Stalled,
        Achieved
    }
    public class Project
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string? Title { get; set; }

        [Required]
        [StringLength(2000)]
        public string? Description { get; set; }

        [Required]
        [StringLength(50)]
        public Progress? Progress { get; set; }

        [Required]
        [StringLength(50)]
        public string? Category { get; set; }

        [MaxLength(int.MaxValue)]
        public string? Image { get; set; }

        [Url]
        public string? Link { get; set; }
      
        public int? UserId { get; set; }
        public User User { get; set; }

        public ICollection<Tag>? ProjectTags { get; set; }
        public ICollection<User>? Applicants { get; set; }
        public ICollection<Skill>? Skills { get; set; }
        public ICollection<Collabrator>? Collabrators { get; set; }
        public ICollection<Message>? Messages { get; set; }
        public ICollection<ChatMessage>? ChatMessages { get; set; }
    }
}

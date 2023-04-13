using System.ComponentModel.DataAnnotations;

namespace Project_LagaltBackend.Models.Main
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(int.MaxValue)]
        public string? KeycloakId { get; set; }

        [Required]
        [StringLength(50)]
        public string? UserName { get; set; }

        [MaxLength(int.MaxValue)]
        public string? Picture { get; set; }
        
        [MaxLength(30)]
        [Required]
        public string? Status { get; set; }

        [Required]
        [StringLength(255)]
        public string? Description { get; set; }
        public bool? IsProfileHidden { get; set; }
        public ICollection<Skill>? Skills { get; set; }
        public ICollection<Message>? Messages { get; set; }
        public ICollection<Tag>? UserTags { get; set; }
        public ICollection<ChatMessage>? ChatMessages { get; set; }
        public ICollection<Project>? Projects { get; set; }
        public ICollection<Collabrator>? ProjectApplications { get; set; }
    }
}

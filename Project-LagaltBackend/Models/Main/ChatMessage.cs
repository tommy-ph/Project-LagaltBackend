
using System.ComponentModel.DataAnnotations;

namespace Project_LagaltBackend.Models.Main
{
    public enum ChatMessageType
    {
        Join,
        Chat,
        Leave
    }
    public class ChatMessage
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(1000)]
        public string? Content { get; set; }
        [Required]
        [StringLength(50)]
        public string? Sender { get; set; }

        [Required]
        [StringLength(50)]
        public string? Room { get; set; }

        [Required]
        [StringLength(50)]
        public ChatMessageType? Type { get; set; }

        [DataType(DataType.DateTime)]
        public string? Timestamp { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Project_LagaltBackend.Models.Main
{
    public enum MessageType
    {
        Join,
        Chat,
        Leave
    }
    public class Message
    {
        [Required]
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public Project Project { get; set; }
        public int? SenderId { get; set; }
        public User Sender { get; set; }

        [DataType(DataType.DateTime)]
        public string? Timestamp { get; set; }

        [Required]
        [StringLength(50)]
        public MessageType? Type { get; set; }
        [Required]
        [StringLength(1000)]
        public string? Content { get; set; }
    }
}

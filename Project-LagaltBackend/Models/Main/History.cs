using System.ComponentModel.DataAnnotations;

namespace Project_LagaltBackend.Models.Main
{
    public enum ActionType
    {
        Seen,
        Clicked,
        Applied,
        Collabrated
    }
    public class History
    {
        [Required]
        public int Id { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public int? ProjectId { get; set; }
        public Project Project { get; set; }

        [Required]
        [StringLength(50)]
        public ActionType? ActionType { get; set; }

        [DataType(DataType.DateTime)]
        public string? Timestamp { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Project_LagaltBackend.Models.DTOs.UserDTO
{
    public class CreateUserDto
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string? Status { get; set; }
        public string? Picture { get; set; }
        public bool IsProfileHidden { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Project_LagaltBackend.Models.DTOs.UserDTO
{
    public class LoginUserDto
    {
        public string? KeycloakId { get; set; }
        public string? UserName { get; set; }
    }
}

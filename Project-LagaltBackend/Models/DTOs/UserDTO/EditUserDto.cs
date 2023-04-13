using Project_LagaltBackend.Models.Main;
using System.ComponentModel.DataAnnotations;

namespace Project_LagaltBackend.Models.DTOs.UserDTO
{
    public class EditUserDto
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string? Status { get; set; }
        public string? Picture { get; set; }
        public bool IsProfileHidden { get; set; }
       
    }
}

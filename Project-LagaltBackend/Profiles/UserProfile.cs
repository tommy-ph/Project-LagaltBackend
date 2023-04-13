using AutoMapper;
using Project_LagaltBackend.Models.DTOs.UserDTO;
using Project_LagaltBackend.Models.Main;

namespace Project_LagaltBackend.Profiles
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<User, ReadUserDto>();

            CreateMap<User, LoginUserDto>();

            CreateMap<CreateUserDto, User>();

            CreateMap<EditUserDto, User>();
        }
    }
}

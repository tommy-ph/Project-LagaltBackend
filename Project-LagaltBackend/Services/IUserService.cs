﻿using Project_LagaltBackend.Models.Main;

namespace Project_LagaltBackend.Services
{
    public interface IUserService
    {
        Task<User> GetAllUsers();
        Task<User> GetUserById(int id);
        Task RemoveSkillIfLast(string skill);
        Task<User> UpdateUser(User user);
        Task<User> AddUser(User user);
        Task DeleteUser(int id);
        Task<User> GetUserAsyncKeycloak(string keycloakId, string username);
        Task UpdateUserAsyncPatch(User updatedUser, User userToPatch);
        Task<User> PostAsyncKeycloakUsername(string keycloakId, string username);
        Task<bool> UserInDbKeycloak(string keycloakId);
        public User GetUserFromKeyCloak(string keycloakId);

    }
}

using Project_LagaltBackend.Exceptions;
using Microsoft.EntityFrameworkCore;
using Project_LagaltBackend.Data;
using Microsoft.AspNetCore.Mvc;
using Project_LagaltBackend.Models.Main;
using System.Security.Claims;

namespace Project_LagaltBackend.Services
{
    public class UserService : IUserService
    {
        private readonly LagaltDbContext _context;

        public UserService(LagaltDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetAllUser(string keycloakId, string username)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.KeycloakId == keycloakId);
            
            if (user == null)
            {
                return await AddUser(keycloakId, username);
            }
            return user;
        }

        public async Task<User> GetUserById(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id ==id);

            if (user == null)
            {
                throw new UserNotFoundException(id);
            }

            return user;
        }

        public async Task UpdateUser(User patchUser, User userToPatch)
        {
            if (patchUser.UserName != null)
            {
                userToPatch.UserName = patchUser.UserName;
            }
            if (patchUser.IsProfileHidden != null)
            {
                userToPatch.IsProfileHidden = patchUser.IsProfileHidden;
            }
            if (patchUser.Description != null)
            {
                userToPatch.Description = patchUser.Description;
            }
            if (patchUser.Picture != null)
            {
                userToPatch.Picture = patchUser.Picture;
            }
            _context.Entry(userToPatch).State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }

        public async Task<User> AddUser(string keycloakId, string username)
        {     

            User user = new User { KeycloakId = keycloakId, UserName = username, Status = ""};
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<User> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                throw new UserNotFoundException(id);
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<bool> UserInDB(string keycloakId)
        {
            return await _context.Users.AnyAsync(k => k.KeycloakId == keycloakId);
        }
        public User GetuserFromKeycloak(string keycloakId)
        {
            User user = _context.Users.FirstOrDefaultAsync(u => u.KeycloakId == keycloakId).Result;
            return user;
        }

        public Task<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task RemoveSkillIfLast(string skill)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> AddUser(User user)
        {
            throw new NotImplementedException();
        }

        Task IUserService.DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserAsyncKeycloak(string keycloakId, string username)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsyncPatch(User updatedUser, User userToPatch)
        {
            throw new NotImplementedException();
        }

        public Task<User> PostAsyncKeycloakUsername(string keycloakId, string username)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserInDbKeycloak(string keycloakId)
        {
            throw new NotImplementedException();
        }

        public User GetUserFromKeyCloak(string keycloakId)
        {
            throw new NotImplementedException();
        }
    }
}

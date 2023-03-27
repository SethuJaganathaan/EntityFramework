using EFdummy.Context;
using EFdummy.DTO;
using EFdummy.Entities;
using EFdummy.Interface;
using Microsoft.EntityFrameworkCore;

namespace EFdummy.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ADOContext _context;
        public UserRepository()
        {
            _context = new ADOContext();
        }

        public async Task<List<User>> AddUser(UserDTO userDTO)
        {
            User user = new User();
            user.UserId = userDTO.UserId;
            user.UserName = userDTO.UserName;
            user.Dob = userDTO.Dob;
            user.DepartmentId = userDTO.DepartmentId;

            _context.Users.Add(user);
            _context.SaveChanges();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<User>> getAllUser()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<UserDTO> UpdateUser(int id,UserDTO userDTO)
        {
            User user = new User();
            user.UserId = userDTO.UserId;
            user.UserName = userDTO.UserName;
            user.Dob = userDTO.Dob;
            user.DepartmentId = userDTO.DepartmentId;

            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return userDTO;
        }
    }
}

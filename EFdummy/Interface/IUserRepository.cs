using EFdummy.DTO;
using EFdummy.Entities;

namespace EFdummy.Interface
{
    public interface IUserRepository
    {
       Task<List<User>> getAllUser();
       Task<List<User>> AddUser(UserDTO userDTO);  
       Task<UserDTO> UpdateUser(int id,UserDTO userDTO);
    }
}

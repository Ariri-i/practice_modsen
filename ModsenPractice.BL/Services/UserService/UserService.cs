using ModsenPractice.DAL.Repository.ProductRepository;
using ModsenPractice.DAL.Repository.UserRepository;
using ModsenPractice.DAL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsenPractice.BL.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public void AddUser()
        {
            var user = new User();
            _userRepository.Add(user);
        }

        public void DeleteUser()
        {
            throw new NotImplementedException();
        }

        public void GetUserList()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser()
        {
            throw new NotImplementedException();
        }
    }
}

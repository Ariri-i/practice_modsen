using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsenPractice.BL.Services.UserService
{
    public interface IUserService
    {
        public void GetUserList();

        public void AddUser();

        public void UpdateUser();

        public void DeleteUser();
    }
}

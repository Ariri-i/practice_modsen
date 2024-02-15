using ModsenPractice.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsenPractice.DAL.Repository.UserRepository
{
    public class UserRepository(dbContext dbContext) : GenericRepository<User>(dbContext), IUserRepository
    {
        public async Task SoftDelete(int Id)
        {
            var user = await GetById(Id);
            if (user != null)
            {
                user.IsDeleted = true;
                await Update(user);
            }
        }
    }
}

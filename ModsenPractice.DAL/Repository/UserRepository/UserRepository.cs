using ModsenPractice.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsenPractice.DAL.Repository.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly dbContext _dbContext;

        public UserRepository(dbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public void Add(User Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(User Entity)
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetFullList()
        {
            throw new NotImplementedException();
        }

        public void Update(User Entity)
        {
            throw new NotImplementedException();
        }
    }
}

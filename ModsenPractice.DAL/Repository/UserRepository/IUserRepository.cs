using ModsenPractice.DAL.Models;

namespace ModsenPractice.DAL.Repository.UserRepository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        List<User> GetFullList();
    }
}

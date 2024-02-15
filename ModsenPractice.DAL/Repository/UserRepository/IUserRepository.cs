using ModsenPractice.DAL.Models;

namespace ModsenPractice.DAL.Repository.UserRepository
{
    public interface IUserRepository
    {
        Task SoftDelete(int Id);
    }
}

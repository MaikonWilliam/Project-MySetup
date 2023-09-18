using MyPc.Models;

namespace MyPc.Repository
{
    public interface IUserRepository
    {
        List<UserModel> SearchAll();
        UserModel Add(UserModel user);
        bool Edit(UserModel model);
        UserModel Details(int id);
        bool Delete (UserModel modelDeletion);
    }
}

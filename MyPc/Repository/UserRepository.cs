using MyPc.Data;
using MyPc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace MyPc.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly BancoContext _bancoContext;

        public UserRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public UserModel Add(UserModel user)
        {
            
            _bancoContext.User.Add(user);
            _bancoContext.SaveChanges();
            return user;
        }

        public List<UserModel> SearchAll()
        {
            try
            {
                return _bancoContext.User.ToList();
            } catch (Exception ex) 
            { 
                return new List<UserModel>();
            }
            
        }

        public UserModel Details(int id)
        {
            return _bancoContext.User.Where(o => o.Id == id).First();
        }

        public bool Edit(UserModel model)
        {
            var UserDB = Details(model.Id);

            UserDB.Perfil = model.Perfil;
            UserDB.Name = model.Name;
            UserDB.Passaword = model.Passaword;
            UserDB.Login = model.Login;
            UserDB.Email = model.Email;
            UserDB.ChangeDate = model.ChangeDate;
            

            _bancoContext.User.Update(UserDB);
            _bancoContext.SaveChanges();

            return true;
        }

        public bool Delete(UserModel modelDeletion)
        {
            try
            {
                _bancoContext.User.Remove(modelDeletion);
                _bancoContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
           
        }
    }
}

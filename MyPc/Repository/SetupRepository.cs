using MyPc.Data;
using MyPc.Models;
using Microsoft.EntityFrameworkCore;

namespace MyPc.Repository
{
    public class SetupRepository : ISetupRepository
    {
        private readonly BancoContext _bancoContext;

        public SetupRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public SetupModel Add(SetupModel setup)
        {
            _bancoContext.Setup.Add(setup);
            _bancoContext.SaveChanges();
            return setup;
        }

        public List<SetupModel> SearchAll()
        {
             
            return _bancoContext.Setup.ToList(); 
        }

        public SetupModel Details(int id)
        {
            return _bancoContext.Setup.Where(o => o.Id == id).First();
        }
    }
}

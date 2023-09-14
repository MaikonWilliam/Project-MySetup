using MyPc.Data;
using MyPc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Query.Internal;

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
            try
            {
                return _bancoContext.Setup.ToList();
            } catch (Exception ex) 
            { 
                return new List<SetupModel>();
            }
            
        }

        public SetupModel Details(int id)
        {
            return _bancoContext.Setup.Where(o => o.Id == id).First();
        }

        public bool Edit(SetupModel model)
        {
            var setupDB = Details(model.Id);

            setupDB.Cpu = model.Cpu;
            setupDB.RAM = model.RAM;
            setupDB.PowerSupply = model.PowerSupply;
            setupDB.Cabinet = model.Cabinet;
            setupDB.Gpu = model.Gpu;
            setupDB.Motherboard = model.Motherboard;
            setupDB.SSD_or_HD = model.SSD_or_HD;
            setupDB.TotalPrice = model.TotalPrice;

            _bancoContext.Setup.Update(setupDB);
            _bancoContext.SaveChanges();

            return true;
        }

        public bool Delete(SetupModel modelDeletion)
        {
            try
            {
                _bancoContext.Setup.Remove(modelDeletion);
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

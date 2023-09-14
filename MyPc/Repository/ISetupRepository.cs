using MyPc.Models;

namespace MyPc.Repository
{
    public interface ISetupRepository
    {
        List<SetupModel> SearchAll();
        SetupModel Add(SetupModel setup);
        bool Edit(SetupModel model);
        SetupModel Details(int id);
        bool Delete (SetupModel modelDeletion);
    }
}

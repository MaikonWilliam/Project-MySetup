using MyPc.Models;

namespace MyPc.Repository
{
    public interface ISetupRepository
    {
        List<SetupModel> SearchAll();
        SetupModel Add(SetupModel setup);
        SetupModel Details(int id);
    }
}

using Microsoft.AspNetCore.Mvc;
using MyPc.Models;
using MyPc.Repository;

namespace MyPc.Controllers
{
    public class SetupController : Controller
    {
        private readonly ISetupRepository _setupRepository;

        public SetupController(ISetupRepository setupRepository)
        {
            _setupRepository = setupRepository;
        }

        public IActionResult Index()
        {
            var list = _setupRepository.SearchAll();
            return View(list);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(SetupModel setup)
        {
           _setupRepository.Add(setup);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
           var obj = _setupRepository.Details(id);
           return View(obj);
        }
    }
}

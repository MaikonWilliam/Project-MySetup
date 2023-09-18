using Microsoft.AspNetCore.Mvc;
using MyPc.Models;
using MyPc.Repository;

namespace MyPc.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            var list = _userRepository.SearchAll();
            return View(list);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(UserModel setup)
        {
            setup.RegistrationDate = DateTime.Now;
            _userRepository.Add(setup);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var obj = _userRepository.Details(id);
            return View(obj);
        }

        public IActionResult Edit(int id)
        {
            var obj = _userRepository.Details(id);
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(UserModel model)
        {
            _userRepository.Edit(model);
            return RedirectToAction("Index");
        }

        public IActionResult ConfirmDelete(int id)
        {
            var DeletionSetup = _userRepository.Details(id);
            return View(DeletionSetup);
        }

        public IActionResult Delete(int id)
        {
            var model = _userRepository.Details(id);
            bool state = _userRepository.Delete(model);
            return RedirectToAction("Index");
        }
    }
}

using MyPc.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyPc.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Insira o nome")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Insira o Login")]   
        public string Login { get; set; }
        [Required(ErrorMessage = "Insira a senha")]        
        public string Passaword { get; set; }
        [Required(ErrorMessage = "Insira o Email")]
        [EmailAddress(ErrorMessage ="O email digitado não é válido ")]
        public string Email { get; set; }
        public PerfilEnum Perfil { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}

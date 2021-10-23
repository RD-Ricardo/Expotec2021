using System.ComponentModel.DataAnnotations;

namespace Expotec2021.Web.ViewModel.RegisterViewModel
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "E-mail Obrigatório")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar senha")]
        [Compare("Password", ErrorMessage = "Senha diferente")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Cep Obrigatório")]
        public string  Cep { get; set; }
    }
}
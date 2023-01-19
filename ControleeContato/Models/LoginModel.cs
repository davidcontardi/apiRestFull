using System.ComponentModel.DataAnnotations;

namespace ControleeContato.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o nome do contato")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite a senha")]
        public string Senha { get; set; }
    }
}

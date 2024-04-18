using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı girin!")]
        public string userName { get; set; }
     
        [Required(ErrorMessage = "Lütfen mail adresinizi girin!")]
        public string mail { get; set; }
      
        [Required(ErrorMessage = "Lütfen şifrenizi girin!")]
        public string password { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi tekrar girin!")]
        [Compare ("password" , ErrorMessage ="Lütfen şifrelerinizin eşleştiğinden emin olun!")]
        public string passwordConfirm { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace SuperFacil.Infraestructure.CrossCutting.Model
{
    public class VerifyCode
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Codigo")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Lembrar este browser?")]
        public bool RememberBrowser { get; set; }

        [Display(Name ="Lembrar-me")]
        public bool RememberMe { get; set; }
    }
}

using Microsoft.AspNetCore.Antiforgery;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ticari.WebMVC.Models.VMs.Account
{
    public class UserInsertVM
    {
        [Required(ErrorMessage ="Ad alanı zorunlu")]
        [MinLength(2,ErrorMessage ="En az 2 karakter")]
        [MaxLength(20, ErrorMessage ="En fazla 20 karakter")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Soyad alanı zorunlu")]
        [MinLength(2, ErrorMessage = "En az 2 karakter")]
        [MaxLength(20, ErrorMessage = "En fazla 20 karakter")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Tc No alanı zorunlu")]
        [StringLength(11,ErrorMessage ="11 karakter olmalıdır.")]
        public string TcNo { get; set; }

        [Required(ErrorMessage = "Email alanı zorunlu")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon alanı zorunlu")]
        [DataType(DataType.PhoneNumber)]
        public string Gsm { get; set; }
        public bool? Cinsiyet { get; set; }

        [Required(ErrorMessage = "Şifre girmediniz.")]
        [MinLength(2, ErrorMessage = "En az 2 karakter")]
        [MaxLength(20, ErrorMessage = "En fazla 20 karakter")]
        [DisplayName("Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre girmediniz.")]
        [MinLength(2, ErrorMessage = "En az 2 karakter")]
        [MaxLength(20, ErrorMessage = "En fazla 20 karakter")]
        [DisplayName("Şifre Tekrar")]
        [DataType(DataType.Password)]
        public string RePassword { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace MvcApplication1.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }

    [Table("UserProfile")]
    public class UserProfile
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
    }

    public class RegisterExternalLoginModel
    {
        [Required]
        [Display(Name = "Nombre de usuario")]
        public string UserName { get; set; }

        public string ExternalLoginData { get; set; }
    }

    public class LocalPasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña actual")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nueva contraseña")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar la nueva contraseña")]
        [Compare("NewPassword", ErrorMessage = "La nueva contraseña y la contraseña de confirmación no coinciden.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginModel
    {
        [Required]
        [Display(Name = "Nombre de usuario")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Display(Name = "¿Recordar cuenta?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterModel
    {
        [Required]
        [Display(Name = "Nombre de usuario")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contraseña")]
        [Compare("Password", ErrorMessage = "La contraseña y la contraseña de confirmación no coinciden.")]
        public string ConfirmPassword { get; set; }

        [Display(Prompt = "Edad del usuario", Description = "Edad del usuario", Name = "Edad")]
        [Required(ErrorMessage = "Debe indicar una edad para el usuario")]
        [DataType(DataType.Currency, ErrorMessage = "La edad debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 120, ErrorMessage = "La edad debe ser mayor que cero y menor de 120")]
        public int Edad { get; set; }

        [Display(Prompt = "Sexo del usuario", Description = "Sexo del usuario", Name = "Sexo")]
        [Required(ErrorMessage = "Debe indicar un sexo para el usuario")]
        public string sexo { get; set; }

        [Display(Prompt = "Email del usuario", Description = "Email del usuario", Name = "Email")]
        [Required(ErrorMessage = "Debe indicar una email para el usuario")]
        public string Email { get; set; }

        [Display(Prompt = "Foto del usuario", Description = "Unidades del usuario", Name = "Foto")]
        public string Foto { get; set; }

        [Display(Prompt = "Facebook del usuario", Description = "Facebook del usuario", Name = "Facebook")]
        [StringLength(maximumLength: 50, ErrorMessage = "Tu cuenta de facebook no puede tener más de 50 caracteres")]
        public string Facebook { get; set; }

        [Display(Prompt = "Instagram del usuario", Description = "Instagram del usuario", Name = "Instagram")]
        [StringLength(maximumLength: 50, ErrorMessage = "Tu cuenta de instagram no puede tener más de 50 caracteres")]
        public string Instagram { get; set; }

        [Display(Prompt = "Twitter del usuario", Description = "Twitter del usuario", Name = "Twitter")]
        [StringLength(maximumLength: 50, ErrorMessage = "Tu cuenta de twitter no puede tener más de 50 caracteres")]
        public string Twitter { get; set; }
    }

    public class ExternalLogin
    {
        public string Provider { get; set; }
        public string ProviderDisplayName { get; set; }
        public string ProviderUserId { get; set; }
    }
}

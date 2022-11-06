using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Model.Authentication;

public class Register
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [MinLength(6)]
    [MaxLength(50)]
    public string Password { get; set; }
    public string PasswordConfirm { get; set; }

}

using System;
using System.ComponentModel.DataAnnotations;

namespace Winjit.Model
{
    public class UserInfo
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage ="Please Enter The FirstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Please Enter The LastName")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Please Enther The UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Please Enter The Email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please Enter The Password")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Please Enter The DAte")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practice2S5DataAnnotation.Models
{
    public class User
    {
        public int id { get; set; }
        [DisplayName("Tên")]
        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(250, MinimumLength = 6, ErrorMessage = "Tên phải dài hơn 6 kí tự")]
        public string name { get; set; }
        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "Mật khẩu phải có ít nhất 5 kí tự")]
        public string password { get; set; }
        [DisplayName("Xác nhận mật khẩu")]
        [Compare("password", ErrorMessage = "Mật khẩu xác nhận không giống với mật khẩu gốc!")]
        public string confirmPassword { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email sai định dạng!")]
        public string email { get; set; }
    }
}
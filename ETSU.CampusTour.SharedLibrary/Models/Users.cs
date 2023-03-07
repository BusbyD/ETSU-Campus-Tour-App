using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETSU.CampusTour.SharedLibrary.Models
{
    public class User
    {
        [Key]
        public int User_id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        //password needs to become a salted has instead of db literal password
        public string Password { get; set; } = string.Empty;
        public string User_location { get; set; } = string.Empty;
    }
}

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
        public int user_id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        //password needs to become a salted has instead of db literal password
        public string password { get; set; }
        public string user_location { get; set; }
    }
}

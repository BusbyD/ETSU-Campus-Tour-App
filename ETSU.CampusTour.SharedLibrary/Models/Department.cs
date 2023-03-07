using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETSU.CampusTour.SharedLibrary.Models
{
    public class Department
    {
        [Key]
        public int Department_Id { get; set; }
        public string Department_Name { get; set; } = string.Empty;
        public string Department_Description { get; set; } = string.Empty;
        public int College_Id { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETSU.CampusTour.SharedLibrary.Models
{
    public class College
    {
        [Key]
        public int College_Id { get; set; }
        public string College_Name { get; set; } = string.Empty;
        public string College_Description { get; set; } = string.Empty;
    }
}

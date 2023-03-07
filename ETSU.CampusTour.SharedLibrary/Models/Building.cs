using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETSU.CampusTour.SharedLibrary.Models
{
    public class Building
    {
        [Key]
        public int Building_Id { get; set; }
        public string Building_Name { get; set; } = string.Empty;
        public string Building_Description { get; set; } = string.Empty;
        public string Building_Image { get; set; } = string.Empty;
        public int College_Id { get; set; }
        public int Department_Id { get; set; }
    }
}

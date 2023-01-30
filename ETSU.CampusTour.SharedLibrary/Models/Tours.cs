using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETSU.CampusTour.SharedLibrary.Models
{
    public class Tour
    {
        [Key]
        public int Tour_Id { get; set; }
        public string Tour_Name { get; set; }
        public string Tour_Description { get; set; }
        public string Tour_Type { get; set; }
        public string Tour_Route { get; set; }
    }
}

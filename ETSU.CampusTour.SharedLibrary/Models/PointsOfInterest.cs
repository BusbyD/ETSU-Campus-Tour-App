using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETSU.CampusTour.SharedLibrary.Models
{
    public class PointsOfInterest
    {
        [Key]
        public int Poi_Id { get; set; }
        public string Poi_Name { get; set; }
        public string Poi_Description { get; set; }
        public string Poi_Image { get; set; }
        public string Poi_Location { get; set; }
        public string Poi_Qr_Code { get; set; }
        public int Tour_Id { get; set; }
    }
}

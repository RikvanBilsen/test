using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proef_b1k2.Models
{
    public class Speler
    {
        [Key]
        public int SpelerID { get; set; }
        [Display(Name = "Naam")]
        public string Roepnaam { get; set; }

        public string Tussenvoegsels { get; set; }

        public string Achternaam { get; set; }

        [Display(Name = "Schoolnaam")]
        public int SchoolID { get; set; }
        [ForeignKey("SchoolID")]
        public School School { get; set; }
    }
}
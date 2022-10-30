using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proef_b1k2.Models
{
    public class School
    {
        [Key]
        public int SchoolID { get; set; }

        [Display(Name = "Schoolnaam")]
        public string Naam { get; set; }

        public virtual ICollection<Speler> Spelers { get; set; }    
    }
}
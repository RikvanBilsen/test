using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proef_b1k2.Models
{
    public class Toernooi
    {
        [Key]
        public int ToernooiID { get; set; }

        public string Omschrijving { get; set; }

        public string Datum { get; set; }
    }
}
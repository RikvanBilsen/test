using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proef_b1k2.Models
{
    public class Wedstrijd
    {
        [Key]
        public int WedstrijdID { get; set; }

        public int Ronde { get; set; }

        public int Speler1ID { get; set; }

        public int Speler2ID { get; set; }

        public int Score1 { get; set; }

        public int Score2 { get; set; }

        public int WinnaarID { get; set; }

    }
}
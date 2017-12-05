using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Northwest_Solution.Models
{
    public class Compound
    {
        [Required]
        public int LT_ID { get; set; }
        public string Description { get; set; }
        public int OrderID { get; set; }
        //public string CompoundAppearance { get; set; }
        public string Weight { get; set; }
        public string ActualWeight { get; set; }
        public string MTD { get; set; }

    }
}
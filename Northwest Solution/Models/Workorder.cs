using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Northwest_Solution.Models
{
    public class Workorder
    {
        [Required]
        public int OrderID { get; set; }
        public int StatusID { get; set; }
        public int LT_ID { get; set; }
        public DateTime DateArrived { get; set; }
        public int ClientID { get; set; }
        public int FinalPrice { get; set; }
        public int QuotedPrice { get; set; }
        public string CommentID { get; set; }
        public string RecommendationID { get; set; }
        public byte PreApproved { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReportManagement.Models
{
    public class ChiNhanhModel
    {
        [Display(Name = "Id")]
        [DataType(DataType.Text)]
        public string Id { get; set; }
    }
}
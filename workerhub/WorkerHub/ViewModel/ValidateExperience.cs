using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WorkerHub.Utilities;

namespace WorkerHub.ViewModel
{
    public class ValidateExperience
    {
        //for model validation
        public int id { get; set; }

        public string Sector { get; set; }

        public string Position { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        //[Range(1920, 2020, ErrorMessage = "Startdate must be between 1920 to 2020")]
        public DateTime Startdate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        //[Range(1920, 2020, ErrorMessage = "Startdate must be between 1920 to 2020")]
        // [ValidAttributes("Startdate", ErrorMessage = "Year is not valid")]
        public DateTime Enddate{ get; set; }

        public string Description { get; set; }
    }
}

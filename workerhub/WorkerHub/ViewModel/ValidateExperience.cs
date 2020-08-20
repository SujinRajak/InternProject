using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkerHub.ViewModel
{
    public class ValidateExperience
    {

        //for model validation
        public int id { get; set; }

        public string Sector { get; set; }

        public string Position { get; set; }

        [Required]

        [Range(1920, 2020, ErrorMessage = "Startdate must be between 1920 to 2020")]
        public int Startdate { get; set; }

        [Range(1920, 2020, ErrorMessage = "Startdate must be between 1920 to 2020")]
        public int Enddate { get; set; }

        public string Description { get; set; }
    }
}

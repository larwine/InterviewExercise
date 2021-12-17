using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechnicalExercise.Models
{
    public class CandidateModel
    {
        public CandidateModel(){
            PositionList = new List<SelectListItem>();
        }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Position")]
        [Required]
        public List<SelectListItem> PositionList { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Join Date")]
        [Required]
        public DateTime JoinDate { get; set; }

        [Display(Name = "Salary")]
        [Required]
        public double SalaryRange { get; set; }

        [Display(Name = "Are you applying to other companies?")]
        [Required]
        public bool ApplyToOtherJobs { get; set; }

    }

}
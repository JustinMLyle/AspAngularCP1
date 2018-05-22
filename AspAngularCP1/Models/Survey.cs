using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AspAngularCP1.Models
{
    public class Survey
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string SurveyTitle { get; set; }

        public List<Question> SurveyQuestions { get; set; }
        public List<ApplicationUser> Completions { get; set; }
        public List<ApplicationUser> Participants { get; set; }

    }
}

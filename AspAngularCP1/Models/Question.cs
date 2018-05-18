using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AspAngularCP1.Models
{
    public class Question
    {
        [Key]
        public int SurveyID { get; set; }

        public string SurveyQuestion { get; set; }
        public bool Required { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AspAngularCP1.Models
{
    public class Responses
    {
        [Key]
        public int ID { get; set; }

        public int SurveyID { get; set; }
        public int CustomerId { get; set; }
        
        public String SavedAnswer { get; set; }
        public int QuestionId { get; set; }
    }
}

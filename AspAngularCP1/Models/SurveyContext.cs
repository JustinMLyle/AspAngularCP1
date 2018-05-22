using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspAngularCP1.Models
{
    public class SurveyContext:DbContext
    {
        public SurveyContext() : base("AspAngularCP1")
        {
        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Survey> Surveys { get; set; }        
        public DbSet<Responses> Responses { get; set; }        
    }
}
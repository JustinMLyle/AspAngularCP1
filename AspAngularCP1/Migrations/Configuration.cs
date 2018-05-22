namespace AspAngularCP1.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AspAngularCP1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<AspAngularCP1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AspAngularCP1.Models.ApplicationDbContext context)
        {
            
            List<Question> QuestionList = new List<Question>
            {
                new Question { SurveyQuestion = "What is your Favorite Color?", Required = true },
                new Question { SurveyQuestion = "What is your Favorite Food?", Required = true },
                new Question { SurveyQuestion = "What is your Favorite Animal?", Required = true },
                new Question { SurveyQuestion = "What is your Favorite Movie?", Required = true }
            };            

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}

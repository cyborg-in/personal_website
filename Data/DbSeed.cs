using System;
using PersonalWebsite.Models;
using PersonalWebsite.Data;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace PersonalWebsite.Data
{
    public static class DbInitializer
    {
        public static void SeedDatabase(WebsiteContext context) 
        { 

            context.Database.EnsureCreated();
            // context.Database.Migrate();

            var newSkill = new Skill();
            newSkill.Name = "JSON";
            newSkill.Begin = new DateTime(2017, 1, 2);
            newSkill.Type = SkillType.Language;
            newSkill.Level = SkillLevel.Basic;

            context.Skills.Add(newSkill);
            context.SaveChanges();

            // if (context.Skills.Any()) {
            //     return;
            // }

            // skills.Add(new Skill() { Name = "JSON", Begin = new DateTime(2013, 03, 02), Level = SkillLevel.Intermediate, Type = SkillType.Format } ); 
            // skills.Add(new Skill() { Name = "EDI", Begin = new DateTime(2013, 03, 02), Level = SkillLevel.Basic, Type = SkillType.Format } ); 
            // skills.Add(new Skill() { Name = "XML", Begin = new DateTime(2013, 03, 02), Level = SkillLevel.Basic, Type = SkillType.Format } ); 
            // skills.Add(new Skill() { Name = "VBA", Begin = new DateTime(2013, 03, 15), Level = SkillLevel.Expert, Type = SkillType.Language } ); 
            // skills.Add(new Skill() { Name = "SQL", Begin = new DateTime(2013, 03, 15), Level = SkillLevel.Expert, Type = SkillType.Language } ); 
            // skills.Add(new Skill() { Name = "VB.NET", Begin = new DateTime(2014, 03, 15), Level = SkillLevel.Intermediate, Type = SkillType.Language } ); 
            // skills.Add(new Skill() { Name = "C#.NET", Begin = new DateTime(2014, 03, 15), Level = SkillLevel.Advanced, Type = SkillType.Language } ); 
            // skills.Add(new Skill() { Name = "Ruby", Begin = new DateTime(2017, 03, 15), Level = SkillLevel.Advanced, Type = SkillType.Language } );
            // skills.Add(new Skill() { Name = "Java", Begin = new DateTime(2017, 09, 15), Level = SkillLevel.Basic, Type = SkillType.Language } );
            // skills.Add(new Skill() { Name = "JavaScript", Begin = new DateTime(2016, 03, 15), Level = SkillLevel.Intermediate, Type = SkillType.Language } );
            // skills.Add(new Skill() { Name = "JSX", Begin = new DateTime(2017, 03, 15), Level = SkillLevel.Intermediate, Type = SkillType.Language } );
            // skills.Add(new Skill() { Name = "Ruby on Rails", Begin = new DateTime(2017, 08, 15), Level = SkillLevel.Intermediate, Type = SkillType.Framework } );
            // skills.Add(new Skill() { Name = "React", Begin = new DateTime(2017, 08, 15), Level = SkillLevel.Intermediate, Type = SkillType.Framework } );
            // skills.Add(new Skill() { Name = "React Native", Begin = new DateTime(2017, 08, 15), Level = SkillLevel.Intermediate, Type = SkillType.Framework } );
            // skills.Add(new Skill() { Name = "Angular", Begin = new DateTime(2017, 09, 15), Level = SkillLevel.Intermediate, Type = SkillType.Framework } );
            // skills.Add(new Skill() { Name = "ASP.NET Webforms", Begin = new DateTime(2014, 08, 15), Level = SkillLevel.Basic, Type = SkillType.Framework } );
            // skills.Add(new Skill() { Name = "ASP.NET MVC", Begin = new DateTime(2015, 08, 15), Level = SkillLevel.Intermediate, Type = SkillType.Framework } );
            // skills.Add(new Skill() { Name = "ASP.NET Core", Begin = new DateTime(2017, 08, 15), Level = SkillLevel.Advanced, Type = SkillType.Framework } );
            // skills.Add(new Skill() { Name = "Entity Framework 6", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Intermediate, Type = SkillType.Framework } );
            // skills.Add(new Skill() { Name = "Entity Framework Core", Begin = new DateTime(2017, 08, 15), Level = SkillLevel.Advanced, Type = SkillType.Framework } );
            // skills.Add(new Skill() { Name = "Python", Begin = new DateTime(2017, 08, 15), Level = SkillLevel.Intermediate, Type = SkillType.Framework } );
            // skills.Add(new Skill() { Name = "PHP", Begin = new DateTime(2015, 08, 15), Level = SkillLevel.Intermediate, Type = SkillType.Framework } );
            // skills.Add(new Skill() { Name = "AJAX", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Intermediate, Type = SkillType.DesignPatterns } );
            // skills.Add(new Skill() { Name = "Asynchronous Calling", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Intermediate, Type = SkillType.DesignPatterns } );
            // skills.Add(new Skill() { Name = "SQL Server Management Studio", Begin = new DateTime(2017, 08, 15), Level = SkillLevel.Advanced, Type = SkillType.Software } );
            // skills.Add(new Skill() { Name = "SQL Server Integration Services", Begin = new DateTime(2017, 08, 15), Level = SkillLevel.Basic, Type = SkillType.Software } );
            // skills.Add(new Skill() { Name = "SQL Server Reporting Services", Begin = new DateTime(2017, 08, 15), Level = SkillLevel.Basic, Type = SkillType.Software } );
            // skills.Add(new Skill() { Name = "T, SQL", Begin = new DateTime(2013, 03, 15), Level = SkillLevel.Expert, Type = SkillType.Language } );
            // skills.Add(new Skill() { Name = "MySQL", Begin = new DateTime(2014, 03, 01), Level = SkillLevel.Expert, Type = SkillType.Language } );
            // skills.Add(new Skill() { Name = "Postgres", Begin = new DateTime(2017, 06, 01), Level = SkillLevel.Expert, Type = SkillType.Language } );
            // skills.Add(new Skill() { Name = "SQLite", Begin = new DateTime(2017, 03, 21), Level = SkillLevel.Expert, Type = SkillType.Language } );
            // skills.Add(new Skill() { Name = "Visual Studio Code", Begin = new DateTime(2017, 08, 15), Level = SkillLevel.Advanced, Type = SkillType.Software } );
            // skills.Add(new Skill() { Name = "Visual Studio", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Advanced, Type = SkillType.Software } );
            // skills.Add(new Skill() { Name = "Sublime", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Advanced, Type = SkillType.Software } );
            // skills.Add(new Skill() { Name = "Atom", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Basic, Type = SkillType.Software } );
            // skills.Add(new Skill() { Name = "Adobe Photoshop", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Advanced, Type = SkillType.Software } );
            // skills.Add(new Skill() { Name = "Adobe InDesign", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Advanced, Type = SkillType.Software } );
            // skills.Add(new Skill() { Name = "Adobe Illustrator", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Advanced, Type = SkillType.Software } );
            // skills.Add(new Skill() { Name = "Adobe Premiere", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Advanced, Type = SkillType.Software } );
            // skills.Add(new Skill() { Name = "Adobe Acrobat", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Advanced, Type = SkillType.Software } );
            // skills.Add(new Skill() { Name = "Microsoft Office Products", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Advanced, Type = SkillType.Software } );
            // skills.Add(new Skill() { Name = "Team Foundation Server", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Intermediate, Type = SkillType.VersionControl } );
            // skills.Add(new Skill() { Name = "Github", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Advanced, Type = SkillType.VersionControl } );
            // skills.Add(new Skill() { Name = "Bitbucket", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Basic, Type = SkillType.VersionControl } );
            // skills.Add(new Skill() { Name = "Visual Studio Version Control", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Basic, Type = SkillType.VersionControl } );
            // skills.Add(new Skill() { Name = "Agile", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Advanced, Type = SkillType.Methodology } );
            // skills.Add(new Skill() { Name = "Scrum", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Advanced, Type = SkillType.Methodology } );
            // skills.Add(new Skill() { Name = "CMMI", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Basic, Type = SkillType.Methodology } );
            // skills.Add(new Skill() { Name = "TDD", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Intermediate, Type = SkillType.Testing } );
            // skills.Add(new Skill() { Name = "BDD", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Basic, Type = SkillType.Testing } );
            // skills.Add(new Skill() { Name = "RSpec", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Intermediate, Type = SkillType.Testing } );
            // skills.Add(new Skill() { Name = "XUnit", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Basic, Type = SkillType.Testing } );
            // skills.Add(new Skill() { Name = "Jasimine", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Intermediate, Type = SkillType.Testing } );
            // skills.Add(new Skill() { Name = "Jest", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Basic, Type = SkillType.Testing } );
            // skills.Add(new Skill() { Name = "CircleCI", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Basic, Type = SkillType.Testing } );
            // skills.Add(new Skill() { Name = "TravisCI", Begin = new DateTime(2016, 08, 15), Level = SkillLevel.Basic, Type = SkillType.Testing } );

            // context.SaveChanges();

        }
    }
}
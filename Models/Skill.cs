using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalWebsite.Models
{
    public class Skill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(64, MinimumLength = 2)]
        public string Name { get; set; }
        public DateTime Begin { get; set; }

        public SkillLevel LevelId { get; set; }
        
        public SkillType TypeId { get; set; }
    }

    public enum SkillLevel 
    {
        Basic = 1, Intermediate, Advanced, Expert
    }

    public enum SkillType 
    {
        Library = 1, Format, Framework, Language, Software, VersionControl, Methodology, DesignPatterns, Testing
    }
}
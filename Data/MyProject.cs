using SQLite;
using System.ComponentModel.DataAnnotations;

namespace MyProjects.Data
{
    public class MyProject
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Required]
        public string ProjectName { get; set; }
        public string? Label { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public string GithubLink { get; set; }
        [Required]
        public string Category { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? DraftCompletionDate { get; set; }
        public bool IsIterationCompleted { get; set; }
    }

}

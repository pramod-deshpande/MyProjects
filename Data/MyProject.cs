using SQLite;

namespace MyProjects.Data
{
    public class MyProject
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public string GithubLink { get; set; }
        public string Category { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DraftCompletionDate { get; set; }
        public bool IsIterationCompleted { get; set; }
    }

}

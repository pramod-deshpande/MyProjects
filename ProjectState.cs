using MyProjects.Data;

namespace MyProjects;

public class ProjectState
{
    private readonly MyProjectsDatabaseInit _db;
    public event Action RefreshRequested;
    public ProjectState(MyProjectsDatabaseInit db)
	{
        _db = db;
    }

    public List<MyProject> Projects { get; set; } = new();

    public async Task<List<MyProject>> GetMyProjects()
    {
        Projects = await _db.GetProjectsAsync();

        return Projects;

    }

    public void CallRequestRefresh()
    {
        RefreshRequested?.Invoke();
    }
}

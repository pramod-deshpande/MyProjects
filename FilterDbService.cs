using MyProjects.Data;

namespace MyProjects;

public class FilterDbService
{
    private readonly MyProjectsDatabaseInit _db;

    public FilterDbService(MyProjectsDatabaseInit db)
	{
        _db = db;
    }

    public async Task<List<MyProject>> GetProjectsBasedOnCategory(string categoryName)
    {
        return (await _db.GetProjectsAsync()).Where(x => x.Category == categoryName).ToList();
    }
}

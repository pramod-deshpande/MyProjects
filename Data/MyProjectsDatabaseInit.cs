

using SQLite;

namespace MyProjects.Data;

public class MyProjectsDatabaseInit
{
    SQLiteAsyncConnection Database;
    public MyProjectsDatabaseInit()
    {

    }

    async Task Init()
    {
        if (Database is not null)
        {
            return;
        }
        Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        _ = await Database.CreateTableAsync<MyProject>();
    }

    public async Task<List<MyProject>> GetProjectsAsync()
    {
        await Init();
        return await Database.Table<MyProject>().ToListAsync();
    }

    public async Task<MyProject> GetProjectAsync(int id)
    {
        await Init();
        return await Database.Table<MyProject>().Where(i => i.Id == id).FirstOrDefaultAsync();
    }

    public async Task<int> SaveItemAsync(MyProject project)
    {
        await Init();
        if (project.Id != 0)
            return await Database.UpdateAsync(project);
        else
        {
            project.CreationDate = DateTime.Now;
            return await Database.InsertAsync(project);
        }
     
    }

    public async Task<int> DeleteItemAsync(MyProject project)
    {
        await Init();
        return await Database.DeleteAsync(project);
    }


}


namespace MyProjects;

public static class Constants
{
    public const string DatabaseFilename = "MyProjectsDb.db3";
    public const SQLite.SQLiteOpenFlags Flags =
      // open the database in read/write mode
      SQLite.SQLiteOpenFlags.ReadWrite |
      // create the database if it doesn't exist
      SQLite.SQLiteOpenFlags.Create |
      // enable multi-threaded database access
      SQLite.SQLiteOpenFlags.SharedCache;

    public static string DatabasePath =>
        Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);

    //Category in Class
    public const string Filter_Active = "active";
    public const string Filter_Wishlist = "wishlist";
    public const string Filter_Ideas = "ideas";
    public const string Filter_Waitlist = "waitlist";
    public const string Filter_Trash = "dropped";
    public const string Filter_Completed = "completed";

    public static readonly List<string> Filters = new() { Filter_Active, Filter_Completed, Filter_Ideas, Filter_Trash, Filter_Waitlist, Filter_Wishlist };


    public const string Label_Working = "working";
    public const string Label_Stuck = "stuck";
    public const string Label_Bug = "bug";
    public const string Label_OnHold = "on-hold";
    public const string Label_NeedInspiration = "need inspiration";
    public const string Label_NeedBreak = "need a break";
    public const string Label_FuckIt = "fuck it!";

    public static readonly List<string> Labels = new() { Label_Working, Label_Stuck, Label_Bug, Label_OnHold, Label_NeedInspiration, Label_NeedBreak, Label_FuckIt };


}

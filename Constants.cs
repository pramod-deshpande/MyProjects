
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


    public const string Filter_Active = "Active";
    public const string Filter_Wishlist = "Wishlist";
    public const string Filter_Ideas = "Ideas";
    public const string Filter_Waitlist = "Waitlist";
    public const string Filter_Trash = "Trash";
    public const string Filter_Completed = "Completed";

    public static List<string> Filters = new() { Filter_Active, Filter_Completed, Filter_Ideas, Filter_Trash, Filter_Waitlist, Filter_Wishlist };

}

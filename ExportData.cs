using MyProjects.Data;
using System.Text;

namespace MyProjects
{
    public class ExportData
    {
        private string fileName = "my-projects";
        private string path = "C:\\Users\\pramo\\Desktop\\Project Tracker\\MyProjects";
        private string _csvExt = ".csv";
        private string jsonExt = "json";

        private readonly MyProjectsDatabaseInit _db;

        public ExportData(MyProjectsDatabaseInit db)
        {
            _db = db;
        }
        public async Task ExportToCSV()
        {
            var sb = new StringBuilder();
            var fileToCreate = Path.Combine(path, fileName + _csvExt);
            var data = await _db.GetProjectsAsync();
            var header = "";
            var info = typeof(MyProject).GetProperties();
            var file = File.Create(fileToCreate);
            file.Close();
            foreach (var item in info)
            {
                header += item.Name + ", ";
            }
            header = header.Substring(0, header.Length - 2);
            sb.AppendLine(header);
            TextWriter sw = new StreamWriter(fileToCreate, true);
            sw.Write(sb.ToString());
            sw.Close();

            foreach (var obj in data)
            {
                sb = new StringBuilder();
                var line = "";
                foreach (var item in info)
                {
                    line += item.GetValue(obj, null) + ", ";
                }
                line = line.Substring(0, line.Length - 2);
                sb.AppendLine(line);
                TextWriter tw = new StreamWriter(fileToCreate, true);
                tw.Write(sb.ToString());
                tw.Close();
            }



        }
    }
}

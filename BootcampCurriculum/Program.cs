using System;

namespace BootcampCurriculum
{
    class Program
    {
        static void Main(string[] args)
        {
            var gitgithub = new Topic();
            gitgithub.Name = "Git/GitHub";
            gitgithub.Category = "SCM";
            gitgithub.Difficulty = 2;
            gitgithub.Print();

            var sqlserver = new Topic()
            {
                Name = "SQL Server",
                Category = "Database",
                Difficulty = 3
            };
            sqlserver.Print();
        }
    }
}

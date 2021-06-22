using System;

namespace GradeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var gradeFiles = new GradeFiles();

            gradeFiles.Run(args[1]);
        }
    }
}
